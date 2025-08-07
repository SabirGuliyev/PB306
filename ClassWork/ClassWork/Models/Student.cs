
namespace ClassWork.Models
{
    internal class Student
    {
        string _name;
        string _surname;
        int _age;
        //aLi
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                value= value.Trim();
                if (IsValidName(value))
                {
                    _name=Capitalize(value);
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
                if (IsValidName(value))
                {
                    _surname=Capitalize(value);
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
                _age = value;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Age}");
        }


        public bool IsValidName(string name)
        {
            if (name.Length < 3)
            {
                
                return false;
            }
            //alibaba
            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i]))
                {
                    return false;
                }
              
            }
            return true;

        }

        public string Capitalize(string name)
        {
            return char.ToUpper(name[0]) + name.Substring(1).ToLower();
        }

    }
}
