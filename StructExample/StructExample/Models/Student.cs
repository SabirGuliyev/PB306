using StructExample.Interface;
using StructExample.Utilities.Enums;


namespace StructExample.Models
{
    internal class Student: ICodeAcademy
    {

        public Gender Gender { get; set; }

        private static int s_count;
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

       

        public string CodeEmail { get ; set ; }
        public Student(string name,string surname,Gender gender)
        {
            Name = Capitalize(name);
            Surname = Capitalize(surname);
;            s_count++;
            Id = s_count;
            CodeEmail = GenerateEmail();
            Gender = gender;
        }

        public static string Capitalize(string word)
        {
            return word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
        }
        public static bool CheckName(string name)
        {
            name = name.Trim();
            if (name.Length > 2 && name.Length < 26)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (!char.IsLetter(name[i]))
                    {
                        return false;
                    }
                }
                return true;
            }

            return false;
        }

        public string GenerateEmail()
        {
            return string.Concat(Name.ToLower(), ".", Surname.ToLower(), Id, "@code.edu.az");
        }
    }
}
