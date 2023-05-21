using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notice_Board.Model
{
    public class Country
    {

        public string Name { get; set; }
        public string ShortName { get; set; }
        public string CurrencySymbol { get; set; }
        public int PhoneCode { get; set; }

        public Country(string name, string shortName, string currencySymbol, int phoneCode)
        {
            Name = name;
            ShortName = shortName;
            CurrencySymbol = currencySymbol;
            PhoneCode = phoneCode;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var country = (Country)obj;
            return Name == country.Name && ShortName == country.ShortName && CurrencySymbol == country.CurrencySymbol && PhoneCode == country.PhoneCode;
        }

        public override int GetHashCode()
        {
            return new { Name, ShortName, CurrencySymbol, PhoneCode }.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Name},{ShortName},{CurrencySymbol},{PhoneCode}";
        }

        public static Country Parse(string str)
        {
            var parts = str.Split(',');
            if (parts.Length != 4)
            {
                throw new ArgumentException("Invalid input string.");
            }

            int phoneCode;
            if (!int.TryParse(parts[3], out phoneCode))
            {
                throw new ArgumentException("Invalid phone code.");
            }

            return new Country(parts[0], parts[1], parts[2], phoneCode);
        }

        public static bool TryParse(string str, out Country country)
        {
            try
            {
                country = Parse(str);
                return true;
            }
            catch
            {
                country = null;
                return false;
            }
        }
    }
}
