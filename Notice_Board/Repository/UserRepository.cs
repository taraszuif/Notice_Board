using Notice_Board.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Notice_Board.Repository
{
    public delegate void UserDeletedEventHandler(string login);

    public class UserRepository : ICrudRepository<Person>
    {
        private static UserRepository _instance;
        private Dictionary<string, Person> _items = new Dictionary<string, Person>();
        private string _userFile;
        private string _adminFile;

        public event UserDeletedEventHandler UserDeleted;

        private UserRepository(string userFile, string adminFile)
        {
            _userFile = userFile;
            _adminFile = adminFile;
        }

        public static UserRepository GetInstance()
        {
            if (_instance == null)
            {
                Console.WriteLine("New User Repository Instance");
                _instance = new UserRepository("users.json", "admins.json");
            }
            return _instance;
        }
        public static UserRepository GetInstance(string userFile, string adminFile)
        {
            if (_instance == null)
            {
                Console.WriteLine("New User Repository Instance");
                _instance = new UserRepository(userFile, adminFile);
            }
            return _instance;
        }
        public void Create(Person item)
        {
            if (_items.ContainsKey(item.Login))
            {
                throw new ArgumentException("An item with the same login already exists.");
            }
            _items.Add(item.Login, item);
        }

        public Person Read(string id)
        {
            if (!_items.TryGetValue(id, out var item))
            {
                throw new KeyNotFoundException("No item found with the given login.");
            }
            return item;
        }

        public void Update(Person item)
        {
            if (!_items.ContainsKey(item.Login))
            {
                throw new KeyNotFoundException("No item found with the given login.");
            }
            _items[item.Login] = item;
        }

        public void Delete(string login)
        {
            if (!_items.Remove(login))
            {
                throw new KeyNotFoundException("No item found with the given login.");
            }
            var noticesToDelete = NoticeRepository.GetInstance().GetAll().Where(n => n.Creator.Equals(login)).ToList();
            foreach (var notice in noticesToDelete)
            {
                NoticeRepository.GetInstance().Delete(notice.Id);
            }

            UserDeleted?.Invoke(login);
        }

        public List<Person> GetAll()
        {
            return _items.Values.ToList();
        }

        public List<User> GetAllUsers()
        {
            return _items.Values.Where(item => item is User).Cast<User>().ToList();
        }

        public List<Administrator> GetAllAdmins()
        {
            return _items.Values.Where(item => item is Administrator).Cast<Administrator>().ToList();
        }

        public void Save()
        {
            var users = _items.Values.Where(item => item is User).Cast<User>().ToList();
            var admins = _items.Values.Where(item => item is Administrator).Cast<Administrator>().ToList();

            var jsonOptions = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            Console.WriteLine("Saving users: " + users.Count);
            Console.WriteLine("Saving admins: " + admins.Count);

            var userJson = JsonSerializer.Serialize(users, jsonOptions);
            var adminJson = JsonSerializer.Serialize(admins, jsonOptions);

            var backupUserDirectory = "backup";
            var backupUserFileName = Path.Combine(backupUserDirectory, GetBackupFileName(_userFile));
            var backupAdminDirectory = "backup";
            var backupAdminFileName = Path.Combine(backupAdminDirectory, GetBackupFileName(_adminFile));

            Directory.CreateDirectory(backupUserDirectory);
            Directory.CreateDirectory(backupAdminDirectory);

            File.WriteAllText(backupUserFileName, File.ReadAllText(_userFile));
            File.WriteAllText(backupAdminFileName, File.ReadAllText(_adminFile));

            File.WriteAllText(_userFile, userJson);
            File.WriteAllText(_adminFile, adminJson);
        }

        public bool Exists(string login)
        {
          return _items.ContainsKey(login);
        }

        public void Load()
        {
            Console.WriteLine("Loading all users");
            if (File.Exists(_userFile))
            {
                var userJson = File.ReadAllText(_userFile);
                var jsonOptions = new JsonSerializerOptions();
                var users = JsonSerializer.Deserialize<List<User>>(userJson, jsonOptions);
                foreach (var user in users)
                {
                    Console.WriteLine("Adding user " + user.Login);
                    if (!_items.ContainsKey(user.Login))
                        _items.Add(user.Login, user);
                }
            }

            Console.WriteLine("Loading all admins");
            if (File.Exists(_adminFile))
            {
                var adminJson = File.ReadAllText(_adminFile);
                var jsonOptions = new JsonSerializerOptions();
                var admins = JsonSerializer.Deserialize<List<Administrator>>(adminJson, jsonOptions);
                foreach (var admin in admins)
                {
                    Console.WriteLine("Adding admin " + admin.Login);
                    if (!_items.ContainsKey(admin.Login))
                        _items.Add(admin.Login, admin);
                }
            }
        }

        private string GetBackupFileName(string originalFileName)
        {
            var backupFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + originalFileName;
            return backupFileName;
        }
    }
}