using Notice_Board.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Notice_Board.Repository
{
    public class CountryRepository : ICrudRepository<Country>, IEnumerable<Country>
    {
        private static CountryRepository _instance;
        private Dictionary<string, Country> _items = new Dictionary<string, Country>();
        private string _filename;

        private CountryRepository(string filename)
        {
            _filename = filename;
        }
        public static CountryRepository GetInstance(string filename)
        {
            if (_instance == null)
            {
                _instance = new CountryRepository(filename);
            }
            return _instance;
        }
        public static CountryRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CountryRepository("countries.json");
                _instance.Load();
            }
            return _instance;
        }

        public void Create(Country item)
        {
            if (_items.ContainsKey(item.Name))
            {
                throw new ArgumentException("A country with the same name already exists.");
            }
            _items.Add(item.Name, item);
        }

        public Country Read(string id)
        {
            if (!_items.TryGetValue(id, out var item))
            {
                throw new KeyNotFoundException("No country found with the given name.");
            }
            return item;
        }

        public void Update(Country item)
        {
            if (!_items.ContainsKey(item.Name))
            {
                throw new KeyNotFoundException("No country found with the given name.");
            }
            _items[item.Name] = item;
        }

        public void Delete(string id)
        {
            if (!_items.Remove(id))
            {
                throw new KeyNotFoundException("No country found with the given name.");
            }
        }

        public List<Country> GetAll()
        {
            return _items.Values.ToList();
        }

        public void Save()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            var json = JsonSerializer.Serialize(_items.Values, options);
            File.WriteAllText(_filename, json);
        }

        public void Clear()
        {
            _items.Clear();
        }
        public void Load()
        {
            if (!File.Exists(_filename))
            {
                throw new FileNotFoundException("The file does not exist.");
            }
            var json = File.ReadAllText(_filename);
            var options = new JsonSerializerOptions();
            _items = JsonSerializer.Deserialize<List<Country>>(json, options)
                .ToDictionary(item => item.Name);
        }

        public IEnumerator<Country> GetEnumerator()
        {
            return _items.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}