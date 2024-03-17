using System;

namespace Intermediate1_OOP
{

    // Excersies working with properties
    public class Person
    {
        public string Name { get; set; } // prop + enter shortcut
        public DateTime birthDate { get; set; }
        private DateTime _birthdate;

        public void SetBirthDate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthDate()
        {
            return _birthdate;
        }

        public DateTime Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }

        public int age
        {
            get
            {
                var timeSpan = DateTime.Today - birthDate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

        public void PersonName(string personame)
        {
            this.Name = personame;

        }

    }
}
