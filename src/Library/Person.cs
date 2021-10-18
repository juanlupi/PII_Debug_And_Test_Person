using System;

namespace UnitTestAndDebug
{
    public class Person
    {

        public Person(string name, string id, string date)
        {
            this.Name = name;
            this.ID = id;
            this.Date = date;
        }

        private string name;

        private string id;

        private string date;

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
            }
        }

        public string Date
        {
            get
            {
                return this.date;
            }
            
            set
            {
                if (IdUtils.DateIsValid(value))
                {
                    this.date = value;
                }
            }
        }

        public void IntroduceYourself()
        {   
            Console.WriteLine($"Soy {this.Name}, mi cédula es {this.ID} y nací el {this.Date}");
        }
    }
}
