using Notice_Board.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Notice_Board.Repository
{
    public class NoticeRepository : ICrudRepository<Notice>, IEnumerable<Notice>
    {
        private static NoticeRepository _instance;
        private List<Notice> _notices;
        private string FilePath;

        public event Action OnSave;
        public event Action OnLoad;

        private NoticeRepository(string filename)
        {
            _notices = new List<Notice>();
            UserRepository.GetInstance().UserDeleted += OnUserDeleted;
            FilePath = filename;
        }

        public static NoticeRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new NoticeRepository("notices.json");
            }
            return _instance;
        }
        public static NoticeRepository GetInstance(string filename)
        {
            if (_instance == null)
            {
                _instance = new NoticeRepository(filename);
            }
            return _instance;
        }
        public void Clear()
        {
            _notices.Clear();
        }

        public void Create(Notice item)
        {
            _notices.Add(item);
        }

        public Notice Read(string id)
        {
            return _notices.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Notice item)
        {
            var index = _notices.FindIndex(x => x.Id == item.Id);
            if (index != -1)
            {
                _notices[index] = item;
            }
        }

        public void Delete(string id)
        {
            var notice = _notices.FirstOrDefault(x => x.Id == id);
            if (notice != null)
            {
                _notices.Remove(notice);
            }
        }

        public void Save()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            Console.WriteLine("Save " + _notices.Count);
            var json = JsonSerializer.Serialize(_notices, options);
            Console.WriteLine("json " + json);
            File.WriteAllText(FilePath, json);
            OnSave?.Invoke();
        }

        public List<Notice> GetAll()
        {
            return _notices;
        }

        public void Load()
        {
            if (File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);
                var options = new JsonSerializerOptions();
                _notices = JsonSerializer.Deserialize<List<Notice>>(json, options) ?? new List<Notice>();
            }
            OnLoad?.Invoke();
        }

        public IEnumerator<Notice> GetEnumerator()
        {
            return _notices.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int GetNoticeCountByUser(string login)
        {
            return _notices.Count(x => x.Creator.Equals(login));
        }

        public List<Notice> SortByPriceAscending(List<Notice> notices)
        {
            return notices.OrderBy(x => x.Price).ToList();
        }

        public List<Notice> SortByPriceDescending(List<Notice> notices)
        {
            return notices.OrderByDescending(x => x.Price).ToList();
        }

        public List<Notice> FilterByCategory(string category)
        {
            return _notices.Where(x => x.Category.ToString().Equals(category)).ToList();
        }

        private void OnUserDeleted(string login)
        {
            var noticesToDelete = _notices.Where(n => n.Creator.Equals(login)).ToList();
            foreach (var notice in noticesToDelete)
            {
                _notices.Remove(notice);
            }
        }
    }
}