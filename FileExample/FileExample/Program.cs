using FileExample.Models;
using Newtonsoft.Json;
using System.Threading.Channels;

namespace FileExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task

            //{
            //    List<Person> people = new List<Person>
            //    {
            //        new()
            //        {
            //            Name="Nazrin",
            //            Surname="Abbasova",
            //            Age=20
            //        },
            //          new()
            //        {
            //            Name="Eynulla",
            //            Surname="Mahmudzade",
            //            Age=18
            //        },
            //            new()
            //        {
            //            Name="Vugar",
            //            Surname="Aliyov",
            //            Age=27
            //        },
            //             new()
            //        {
            //            Name="Vugar",
            //            Surname="Valiyev",
            //            Age=27
            //        }

            //    };

            //string name = Console.ReadLine().Trim();
            //people.FindAll(p => p.Name.ToLower() == name.ToLower());

            //searched.ForEach(p => Console.WriteLine(p.Name+" "+p.Surname));

            //people.FindAll(p => p.Surname.EndsWith("ova") || p.Surname.EndsWith("ov"))
            //    .ForEach(p=>Console.WriteLine(p.Name+" "+p.Surname));

            //people.FindAll(p => p.Age >= 20)
            //    .ForEach(p=>Console.WriteLine(p.Name));

            #endregion

            #region Stream
            //string path= @"C:\Users\sabir\Desktop\Test";


            //Directory.CreateDirectory(@"C:\Users\sabir\Desktop\Test\");

            //if (Directory.Exists(path))
            //{
            //    Directory.Delete(path, true);

            //}
            //Console.WriteLine("1.CReate \n2.SHow3.Exit");



            //if (!File.Exists(@"C:\Users\sabir\Desktop\Test\text.txt"))
            //{
            //    File.Create(@"C:\Users\sabir\Desktop\Test\text.txt");

            //}

            //File.Delete(@"C:\Users\sabir\Desktop\Test\text.txt");

            //FileInfo file = new FileInfo(@"C:\Users\sabir\Desktop\Test\text.txt");

            //file.Create();
            //file.Delete();
            //file.Exists



            //string result;
            //using (StreamReader sr = new(@"C:\Users\sabir\Desktop\Test\text.txt"))
            //{
            //    result=sr.ReadToEnd();
            //}


            //Console.WriteLine(result);


            //Console.WriteLine(result);


            //using (StreamWriter sw = new(@"C:\Users\sabir\Desktop\Test\text.txt"))
            //{
            //    sw.WriteLine("Nasib");
            //    sw.WriteLine("Nazrin");
            //    sw.WriteLine("Elcin");
            //}


            //Console.WriteLine(sr.ReadLine());
            //Console.WriteLine(sr.ReadLine());
            //Console.WriteLine(sr.ReadLine());

            #endregion

            //Category category=new Category { Name="Smartphone"};
            //Category category2=new Category { Name="TV"};

            //Product product = new()
            //{
            //    Id = 1,
            //    Name = "Samsung S24",
            //    Price = 2000m,
            //    Category = category

            //};
            //Product product2 = new()
            //{
            //    Id = 2,
            //    Name = "Iphone 15",
            //    Price = 2500m,
            //    Category = category

            //};
            //Product product3 = new()
            //{
            //    Id = 3,
            //    Name = "Xiaomi POCO",
            //    Price = 800m,
            //    Category = category

            //};


            //Product product4 = new()
            //{
            //    Id = 4,
            //    Name = "Toshiba",
            //    Price = 1800m,
            //    Category = category2

            //};
            //Product product5 = new()
            //{
            //    Id = 5,
            //    Name = "LG Oled",
            //    Price = 2500m,
            //    Category = category2

            //};
            //Product product6 = new()
            //{
            //    Id = 6,
            //    Name = "TLC",
            //    Price = 400m,
            //    Category = category2

            //};

            
            

            //List<Product> products = new List<Product>{
            //    product,
            //    product2,
            //    product3,
            //    product4,
            //    product5,
            //    product6
            //};


           

            //Console.WriteLine(result);

            string path = @"C:\Users\sabir\Desktop\PB306\FileExample\FileExample\Files\productList.json";

            //using (StreamWriter sw = new(path, true))
            //{
            //    sw.Write(result);
            //}
            string result;
            using (StreamReader sr = new(path))
            {
                result = sr.ReadToEnd();
            }

            Console.WriteLine(result);


            var products=JsonConvert.DeserializeObject<List<Product>>(result);

           
            products.Remove(products.Find(p => p.Id == 6));


            result=JsonConvert.SerializeObject(products);
            using (StreamWriter sw = new(path, false))
            {
                sw.Write(result);
            }

        }
    }
}
