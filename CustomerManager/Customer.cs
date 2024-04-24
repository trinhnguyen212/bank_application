using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager
{
    public class Customer
    {

        private static int nextID = 1;
        public enum SexOfPerson
        {
            Male = 1,
            Female = 2
        }

        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                if (value.Length > 50)
                    Console.WriteLine("Error! FirstName must be less than 51 characters!");
                else
                    _FirstName = value;
            }
        }

        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set
            {
                if (value.Length > 50)
                    Console.WriteLine("Error! LastName must be less than 51 characters!");
                else
                    _LastName = value;
            }
        }

        private string _ID;
        public string ID
        {
            get { return _ID; }
            set
            {
                if (value.Length > 9)
                    Console.WriteLine("Error! ID must be less than 10 characters!");
                else
                    _ID = value;
            }
        }

        private string _Nationality;
        public string Nationality
        {
            get { return _Nationality; }
            set { _Nationality = value; }
        }

        private SexOfPerson _Sex;
        public SexOfPerson Sex
        {
            get { return _Sex; }
            set { _Sex = value; }
        }

        public Customer()
        {
            ID = nextID.ToString();
            nextID++;

        }
        public Customer(string firstname, string lastname, string nationality, SexOfPerson sex) : this()
        {
            FirstName = firstname;
            LastName = lastname;
            //  ID          = nextID.ToString();
            Nationality = nationality;
            Sex = sex;
            // nextID++;

        }
    }
    
}
