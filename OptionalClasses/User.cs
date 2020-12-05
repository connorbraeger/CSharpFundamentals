using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalClasses
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; }
        public DateTime BirthDate { get; set; }

        public User() { }
        public User(string firstName, string lastName, int id, DateTime birthDate) 
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            BirthDate = birthDate;
        }
        public string FullName()
        {
            string fullName = FirstName + " " + LastName;
            return fullName;
        }
        public int AgeInYears()
        {

            int age = DateTime.Now.Year - BirthDate.Year;
            if (DateTime.Now.DayOfYear >= BirthDate.DayOfYear)
            {
                return age;
            }
            else
            {
                return age - 1;
            }
        }
    }
}
