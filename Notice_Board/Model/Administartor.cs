using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Notice_Board.Model
{
    public class Administrator : Person
    {
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override int Age { get; set; }
        public override string Country { get; set; }
        public override string Phone { get; set; }
        public override string Email { get; set; }
        public override string Login { get; set; }
        public override string Password { get; set; }
        public Administrator(string firstName, string lastName, int age, string country, string phone, string email, string login, string password)
    : base(firstName, lastName, age, country, phone, email, login, password)
        {
        }
        [JsonConstructor]
        public Administrator(string firstName, string lastName, int age, string country, string phone, string email, string login, string password, DateTime creationDate)
       : base(firstName, lastName, age, country, phone, email, login, password, creationDate)
        {
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override string ToString()
        {
            return $"Administrator:{FirstName},{LastName},{Age},{Country},{Phone},{Email},{Login},{Password},{CreationDate:yyyy-MM-dd HH:mm:ss}";
        }

        public static new Administrator Parse(string str)
        {
            if (!str.StartsWith("Administrator:"))
            {
                throw new ArgumentException("Input string does not represent an administrator.");
            }

            var parts = str.Substring("Administrator:".Length).Split(',');
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

            return new Administrator(parts[0], parts[1], age, parts[3], parts[4], parts[5], parts[6], parts[7], creationDate);
        }

        public static bool TryParse(string str, out Administrator admin)
        {
            try
            {
                admin = Parse(str);
                return true;
            }
            catch
            {
                admin = null;
                return false;
            }
        }
    }
}
