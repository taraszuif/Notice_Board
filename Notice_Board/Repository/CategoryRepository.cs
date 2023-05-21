using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Notice_Board.Model;

namespace Notice_Board.Repository
{
    public class CategoryRepository : ICrudRepository<Category>
    {
        private static CategoryRepository _instance;
        private string FilePath;
        private List<Category> _categories;
        public event Action OnDataUpdated;

        private CategoryRepository(string filePath)
        {
            FilePath = filePath;
            _categories = new List<Category>();
        }

        public static CategoryRepository GetInstance(string filePath)
        {
            if (_instance == null)
            {
                _instance = new CategoryRepository(filePath);
            }
            return _instance;
        }

        public static CategoryRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CategoryRepository("categories.json");
            }
            return _instance;
        }

        public void Create(Category item)
        {
            _categories.Add(item);
            OnDataUpdated?.Invoke();
        }

        public Category Read(string id)
        {
            return _categories.FirstOrDefault(c => c.Id == id);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category item)
        {
            var index = _categories.FindIndex(c => c.Id == item.Id);
            if (index != -1)
            {
                _categories[index] = item;
                OnDataUpdated?.Invoke();
            }
        }

        public void Delete(string id)
        {
            var item = _categories.FirstOrDefault(c => c.Id == id);
            if (item != null)
            {
                _categories.Remove(item);
                OnDataUpdated?.Invoke();
            }
        }
        public void Clear()
        {
            _categories.Clear();
        }
        public void Save()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            var jsonData = JsonSerializer.Serialize(_categories, options);
            File.WriteAllText(FilePath, jsonData);
        }

        public void Load()
        {
            if (File.Exists(FilePath))
            {
                var jsonData = File.ReadAllText(FilePath);
                var options = new JsonSerializerOptions();
                _categories = JsonSerializer.Deserialize<List<Category>>(jsonData, options) ?? new List<Category>();
            }
        }
    }
}