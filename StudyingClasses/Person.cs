using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingClasses
{
    public class Person
    {

        public Person(DateTime birthdate)
        {
                Birthdate = birthdate;
        }

        private DateTime _birthdate;
        public DateTime Birthdate { get; private set; }
        public string Name { get; set; }
        public string Username { get; set; }

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }

        public void Introduce(string to)
        {
            Console.WriteLine("Hi, {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person(new DateTime(1982, 1, 1));
            person.Name = str;

            return person;
        }

        public int Age
        {
            get 
            { 
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days/365;

                return years;
            }
        }
    }
}
