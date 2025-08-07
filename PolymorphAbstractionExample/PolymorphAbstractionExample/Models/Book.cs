
namespace PolymorphAbstractionExample.Models
{
    internal class Book
    {
        string _name;
        string _author;
        bool _isAvailable;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public bool IsAvailable
        {
            get { return _isAvailable; }
            set { _isAvailable = value; }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} {Author} {IsAvailable}");
        }

    }
}
