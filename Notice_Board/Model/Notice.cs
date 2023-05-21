using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Notice_Board.Model
{
    public class Notice
    {
        public string Id { get; set; }
        public DateTime CreationDate { get; }
        private string _title;
        private string _description;
        private string _textAddress;
        public decimal Price { get; set; }
        public string Creator { get; set; }
        public string Category { get; set; }
        public string Country { get; set; }
        public bool ShowPhone { get; set; }
        public bool ShowEmail { get; set; }

        public string Title
        {
            get { return _title; }
            set
            {
                if (value.Length < 1 || value.Length > 32)
                {
                    throw new ArgumentException("Заголовок повинен бути від 1 до 32 символів у довжину.");
                }
                _title = value;
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (value.Length < 16 || value.Length > 4096)
                {
                    throw new ArgumentException("Опис повинен бути від 16 до 4096 символів у довжину.");
                }
                _description = value;
            }
        }

        public string TextAddress
        {
            get { return _textAddress; }
            set
            {
                if (value.Length < 4 || value.Length > 256)
                {
                    throw new ArgumentException("Текстова адреса повинна бути від 4 до 256 символів у довжину.");
                }
                _textAddress = value;
            }
        }

        public Notice(decimal price, string creator, string description, string title, string category, string country, string textAddress, bool showPhone, bool showEmail)
        {
            Price = price;
            Creator = creator;
            Description = description;
            Title = title;
            Category = category;
            Country = country;
            TextAddress = textAddress;
            ShowPhone = showPhone;
            ShowEmail = showEmail;
            Id = Guid.NewGuid().ToString();
            CreationDate = DateTime.Now;
        }

        [JsonConstructor]
        public Notice(string id, DateTime creationDate, decimal price, string creator, string description, string title, string category, string country, string textAddress, bool showPhone, bool showEmail)
        {
            Id = id;
            CreationDate = creationDate;
            Price = price;
            Creator = creator;
            Description = description;
            Title = title;
            Category = category;
            Country = country;
            TextAddress = textAddress;
            ShowPhone = showPhone;
            ShowEmail = showEmail;
        }

        public override string ToString()
        {
            return $"{Id},{CreationDate.ToString("o")},{Price},{Creator.ToString()},{Description},{Title},{Category.ToString()},{Country.ToString()},{TextAddress},{ShowPhone},{ShowEmail}";
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Notice other = (Notice)obj;
            return (Price == other.Price) && Creator.Equals(other.Creator) && Description.Equals(other.Description) &&
                   Title.Equals(other.Title) && Category.Equals(other.Category) && Country.Equals(other.Country) &&
                   TextAddress.Equals(other.TextAddress) && ShowPhone == other.ShowPhone && ShowEmail == other.ShowEmail;
        }

        public static Notice Parse(string str)
        {
            var parts = str.Split(',');
            if (parts.Length != 11)
            {
                throw new ArgumentException("Недійсний рядок введення.");
            }

            string id = parts[0];

            DateTime creationDate;
            if (!DateTime.TryParse(parts[1], out creationDate))
            {
                throw new ArgumentException("Недійсна дата створення.");
            }

            decimal price;
            if (!decimal.TryParse(parts[2], out price))
            {
                throw new ArgumentException("Недійсна ціна.");
            }

            bool showPhone;
            if (!bool.TryParse(parts[9], out showPhone))
            {
                throw new ArgumentException("Недійсний прапор показу телефону.");
            }

            bool showEmail;
            if (!bool.TryParse(parts[10], out showEmail))
            {
                throw new ArgumentException("Недійсний прапор показу електронної пошти.");
            }

            var creator = parts[3];
            var category = parts[6];
            var country = parts[7];
            return new Notice(id, creationDate, price, creator, parts[4], parts[5], category, country, parts[8], showPhone, showEmail);
        }

        public static bool TryParse(string str, out Notice notice)
        {
            try
            {
                notice = Parse(str);
                return true;
            }
            catch
            {
                notice = null;
                return false;
            }
        }
    }
}