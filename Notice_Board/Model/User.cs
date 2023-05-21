using System;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace Notice_Board.Model
{
    public class User : Person
    {
        private string _login;
        public override string Login
        {
            get { return _login; }
            set
            {
                if (value.Length < 3 || value.Length > 32)
                {
                    throw new ArgumentException("Логін повинен містити від 3 до 32 символів.");
                }
                _login = value;
            }
        }

        private string _password;
        public override string Password
        {
            get { return _password; }
            set
            {
                if (!Regex.IsMatch(value, @"^(?=.*[a-zA-Z])(?=.*\d)") || value.Length < 6 || value.Length > 256)
                {
                    throw new ArgumentException("Пароль повинен містити принаймні одну літеру і одну цифру, і бути від 6 до 256 символів.");
                }
                _password = value;
            }
        }

        private string _firstName;
        public override string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value.Length < 2 || value.Length > 32)
                {
                    throw new ArgumentException("Ім'я повинно містити від 2 до 32 символів.");
                }
                _firstName = value;
            }
        }

        private string _lastName;
        public override string LastName
        {
            get { return _lastName; }
            set
            {
                if (value.Length < 2 || value.Length > 32)
                {
                    throw new ArgumentException("Прізвище повинно містити від 2 до 32 символів.");
                }
                _lastName = value;
            }
        }

        private int _age;
        public override int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 200)
                {
                    throw new ArgumentException("Вік повинен бути в межах від 0 до 200.");
                }
                _age = value;
            }
        }

        private string _email;
        public override string Email
        {
            get { return _email; }
            set
            {
                if (!value.Contains("@") || !value.Contains("."))
                {
                    throw new ArgumentException("Електронна пошта повинна містити символ '@' та домен.");
                }
                _email = value;
            }
        }

        public override string Country { get; set; }
        public override string Phone { get; set; }

        public User(string firstName, string lastName, int age, string country, string phone, string email, string login, string password)
            : base(firstName, lastName, age, country, phone, email, login, password)
        {
        }
        [JsonConstructor]
        public User(string firstName, string lastName, int age, string country, string phone, string email, string login, string password, DateTime creationDate)
  : base(firstName, lastName, age, country, phone, email, login, password, creationDate)
        {
        }
        public override string ToString()
        {
            return $"User:{FirstName},{LastName},{Age},{Country},{Phone},{Email},{Login},{Password},{CreationDate:yyyy-MM-dd HH:mm:ss}";
        }

        public static new User Parse(string str)
        {
            if (!str.StartsWith("User:"))
            {
                throw new ArgumentException("Input string does not represent a user.");
            }

            var parts = str.Substring("User:".Length).Split(',');
            if (parts.Length != 9)
            {
                throw new ArgumentException("Invalid input string.");
            }

            int age;
            if (!int.TryParse(parts[2], out age))
            {
                throw new ArgumentException("Invalid age.");
            }

            if (!DateTime.TryParseExact(parts[8], "yyyy-MM-dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out var creationDate))
            {
                throw new ArgumentException("Invalid creation date.");
            }

            return new User(parts[0], parts[1], age, parts[3], parts[4], parts[5], parts[6], parts[7], creationDate);
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }


        public static bool TryParse(string str, out User user)
        {
            try
            {
                user = Parse(str);
                return true;
            }
            catch
            {
                user = null;
                return false;
            }
        }
    }
}
