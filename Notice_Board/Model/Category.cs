using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Notice_Board.Model
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Category Subcategory { get; set; }

        public Category(string name)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Subcategory = null;
        }

        [JsonConstructor]
        public Category(string id, string name) : this(name)
        {
            Id = id;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var category = (Category)obj;
            return Id == category.Id && Name == category.Name && Subcategory?.Equals(category.Subcategory) == true;
        }

        public override int GetHashCode()
        {
            return new { Id, Name, Subcategory }.GetHashCode();
        }

        public override string ToString()
        {
            string result = Name;
            if (Subcategory != null)
            {
                result += "." + Subcategory.ToString();
            }
            return result;
        }

        public static Category Parse(string str)
        {
            var parts = str.Split('.');
            if (parts.Length == 0 || string.IsNullOrEmpty(parts[0]))
            {
                throw new ArgumentException("Invalid input string.");
            }

            var category = new Category(parts[0]);

            if (parts.Length > 1)
            {
                category.Subcategory = Parse(string.Join(".", parts.Skip(1)));
            }

            return category;
        }

        public static bool TryParse(string str, out Category category)
        {
            try
            {
                category = Parse(str);
                return true;
            }
            catch
            {
                category = null;
                return false;
            }
        }
    }
}