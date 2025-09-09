using MiniApp.Models;
using MiniApp.Repositories;
using MiniApp.Services;
using MiniApp.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace MiniApp
{
    internal class ManagementApplication
    {
        public GroupService GroupService { get; set; }
        public ManagementApplication()
        {
            GroupService=new GroupService(new Test<Group>());
        }
        public void Run()
        {
            int num = 0;
            string str = null;
            bool result = false;

            while (!(num == 0 && result))
            {

                Console.WriteLine("1.Create Group\n2.Show Groups\n3.Edit Group\n4.Show Students of Group\n5.Show All Students\n6.Create Student\n\n0.Exit");
                str = Console.ReadLine();
                Console.Clear();
                result = int.TryParse(str, out num);


                switch (num)
                {
                    case 1:
                        GroupService.CreateGroup();
                        break;
                    case 2:
                        GroupService.ShowALlGroups();
                        
                        break;
                    case 3:
                        GroupService.EditGroup();
                        break;
                    case 4:

                        Console.WriteLine("Students list");
                        break;
                    case 5:

                        Console.WriteLine("All Students");
                        break;
                    case 6:

                        Console.WriteLine("Student created");
                        break;


                    case 0:
                        Console.WriteLine("Program bitdi");
                        break;
                    default:
                 
                        Console.WriteLine("Wrong input, Please try again");
                        break;
                }
            }
        }
    }
}
