using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Person
{
    public abstract string FirstName { get; set; }
    public abstract string LastName { get; set; }
    public DateTime CreationDate { get; }
    public abstract int Age { get; set; }
    public abstract string Country { get; set; }
    public abstract string Phone { get; set; }
    public abstract string Email { get; set; }
    public abstract string Login { get; set; }
    public abstract string Password { get; set; }

    public Person(string firstName, string lastName, int age, string country, string phone, string email, string login, string password)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Country = country;
        Phone = phone;
        Email = email;
        Login = login;
        Password = password;

        CreationDate = DateTime.Now;
    }
    public Person(string firstName, string lastName, int age, string country, string phone, string email, string login, string password, DateTime creationDate)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Country = country;
        Phone = phone;
        Email = email;
        Login = login;
        Password = password;

        CreationDate = creationDate;
    }
    public override string ToString()
    {
        return $"{FirstName},{LastName},{Age},{Country},{Phone},{Email},{Login},{Password},{CreationDate:yyyy-MM-dd HH:mm:ss}";
    }

    public override int GetHashCode()
    {
        return ToString().GetHashCode();
    }

    public static Person Parse(string str)
    {
        var parts = str.Split(',');
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

        return null;
    }

    public static bool TryParse(string str, out Person person)
    {
        try
        {
            person = Parse(str);
            return true;
        }
        catch
        {
            person = null;
            return false;
        }
    }
}