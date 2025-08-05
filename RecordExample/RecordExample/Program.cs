using RecordExample.Models;

namespace RecordExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person("Test");
            
            //Person person2 = new Person("Test");

            ////Console.WriteLine(person);
            ////Console.WriteLine(person==person2);


            //PersonRecord personRecord = new PersonRecord("Test");

            //personRecord.Name = "Salam";
           
            //Console.WriteLine(personRecord);

            ////Console.WriteLine(personRecord==personRecord2);








            Person person = new Person
            {
                Name = "Salam"
            };

            PersonRecord personRecord = new PersonRecord
            {
                Name = "Salam"
            };





        }
    }
}
