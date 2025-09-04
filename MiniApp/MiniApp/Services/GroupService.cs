using MiniApp.Models;
using MiniApp.Repositories;
using MiniApp.Utilities.Enums;
using Newtonsoft.Json;


namespace MiniApp.Services
{
    internal class GroupService
    {
        public readonly string _path = @"C:\Users\sabir\Desktop\PB306\MiniApp\MiniApp\Data\Groups.json";

        public Repository<Group> GroupRepository { get; set; } = new Repository<Group>();
        private Category? GetCategory()
        {
            int num;
            string answer = Console.ReadLine();
            int.TryParse(answer, out num);
            Category category = default;

            switch (num)
            {
                case (int)Category.Programming:
                    category = Category.Programming;
                    break;
                case (int)Category.Design:
                    category = Category.Design;
                    break;
                case (int)Category.Cybersecurity:
                    category = Category.Cybersecurity;
                    break;
                default:
                    return null;

            }

            return category;
        }

        private string GetName(Category category)
        {
            string name = string.Empty;
            switch (category)
            {

                case Category.Programming:
                    name = "P";
                    break;
                case Category.Design:
                    name = "D";
                    break;
                case Category.Cybersecurity:
                    name = "C";
                    break;
            }

            while (true)
            {
                Console.WriteLine("Please choose number of group:\n\n0.Main Menu");

                bool result = true;
                string no = Console.ReadLine().Trim();

                if (no == "0") return null;
                if (no.Length != 3)
                {
                    Console.Clear();
                    Console.WriteLine("Wrong input");
                    continue;
                }

                for (int i = 0; i < no.Length; i++)
                {
                    if (!Char.IsDigit(no[i]))
                    {
                        Console.Clear();
                        Console.WriteLine("Characaters must be Digit");
                        result = false;
                        break;
                    }
                }

                if (result)
                {
                    name += no;
                    break;
                }

            }


            return name;


        }
        private bool? IsOnlineOrNot()
        {
            Console.WriteLine("Is group Online?(y/n)");
            string online = Console.ReadLine().Trim().ToLower();


            if (online == "yes" || online == "y") return true;
            else if (online != "no" && online != "n") return null;

            return false;
        }
        public void CreateGroup()
        {
            Console.Clear();

            Console.WriteLine("Please choose Group Category:");
            foreach (Category item in Enum.GetValues(typeof(Category)))
            {
                Console.WriteLine((int)item + " " + item);
            }

            Category? category = GetCategory();
            if (category == null) return;

            string name = string.Empty;
            List<Group> groups = GroupRepository.Deserialize(_path);
            Console.Clear();
            while (true)
            {

                name = GetName(category.Value);
                if (name is null) return;


                bool isDuplicate = groups.Any(g => g.No == name);

                if (isDuplicate)
                {
                    Console.Clear();
                    Console.WriteLine($"Group named {name} already exist");
                    continue;
                }
                break;
            }


            Console.Clear();
            bool? isOnline = IsOnlineOrNot();
            if (isOnline == null) return;


            Group group = new Group(name, isOnline.Value, category.Value);

            Console.Clear();
            Console.WriteLine(group.No + " " + group.Category + " " + group.Limit + " " + group.IsOnline);

            groups.Add(group);
            GroupRepository.Serialize(_path, groups);
        }

        public void ShowALlGroups()
        {
            List<Group> groups = GroupRepository.Deserialize(_path);

            groups.ForEach(g => Console.WriteLine(g.No + " " + g.Category));

            Console.WriteLine("\n\nPress any key back to Menu...");
            Console.ReadKey();
            Console.Clear();
        }

        public void EditGroup()
        {
            Console.Clear();

            Console.WriteLine("Please enter Group No:");
            string name = Console.ReadLine();

            List<Group> groups = GroupRepository.Deserialize(_path);
            Group existed = groups.Find(g => g.No.ToLower() == name.ToLower());
            if (existed is null)
            {
                Console.Clear();
                Console.WriteLine($"Group named {name} not found\n");
                return;
            }


            Console.Clear();

            string newName = string.Empty;
            while (true)
            {
                newName = GetName(existed.Category);
                if (newName is null) {

                    Console.Clear();
                    return;
                }
                bool isDuplicate = groups.Any(g => g.No == newName);

                if (isDuplicate)
                {
                    Console.Clear();
                    Console.WriteLine($"Group named {newName} already exist");
                    continue;
                }
                break;
            }

            existed.No = newName;

            GroupRepository.Serialize(_path,groups);
            Console.Clear();
            Console.WriteLine("Group successfully edited\n");
        }
    }
}
