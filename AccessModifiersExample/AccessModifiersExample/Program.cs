using AccessModifiersExample.Models;

namespace AccessModifiersExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HomeTask
            //Student student = new Student("Test","Testov","PB306",45);
            //student.PrintInfo();
            //student.CheckGraduation();
            //student.GetDiplomDegree();

            //Product product = new Product("Samsung", "A22", 450m, 400m, 2);



            //product.PrintInfo();

            //product.Sale(2);
            //product.PrintInfo();
            //product.Sale(3);

            //product.Refill(20);

            //product.Sale(10);

            //product.PrintInfo(); 
            #endregion

            //User user = new User("sabir","guliyev",27);


            ////user.Username = "Test";
            //user.Password = "Sabir123";

            //user.Name= "Test";

            //user.Age = -90;

            //Console.WriteLine(user.Name+" "+user.Age+" "+user.Username+" "+user.Password);








            Phone phone = new Phone("Samsung", "A55", 900m, 750m, 17, 8, "red");

            phone.Call(20);

            phone.Pay(2m);

            phone.Call(10);


            Console.WriteLine($"Yekun:{phone.Balance}");








        }
    }

}
