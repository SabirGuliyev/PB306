using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AccessModifiersExample.Models
{
    class User
    {

        private string _name;
        private string _surname;
        private int _age;
        private string _username;
        private string _password;

        public string Name
        {
            get
            {
                Console.WriteLine("Get ishe dushdu");
                return _name;
            }
            set
            {
                Console.WriteLine("Set ishe dushdu");
                value = value.Trim();
                if (value.Length >= 3)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Ad minim 3 xarakternden ibaret olmalidir");
                }
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                value = value.Trim();
                if (value.Length >= 3)
                {
                    _surname = value;
                }
            }
        }

        public int Age
        {
            get
            {

                return _age;
            }
            set
            {
                if (value >= 18)
                {
                    _age = value;
                }


            }
        }

        public string Username
        {
            get
            {
                return _username;
            }

        }

        public string Password
        {
            set
            {
                _password = value;
            }
        }

        public User(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            _username = string.Concat(name, ".", surname);
        }
        //   sa  
        //public void SetName(string name)
        //{
        //    name = name.Trim();
        //    if (name.Length >= 3)
        //    {
        //        Name = name;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ad minim 3 xarakternden ibaret olmalidir");
        //    }
        //}

        //public string GetName()
        //{

        //}







        //public string Surname;
        // string Password;

        // public User(string name,string surname,string password)
        //{
        //    Name= name;
        //    Surname= surname;
        //    Password= password;
        //}
        //public void PrintInfo()
        //{
        //    Console.WriteLine($"{Name} {Surname}");
        //}
    }
}
