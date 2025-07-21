

//ctrl+k+s region yaratmaq
#region HomeWork solutions
//1) 3 ədəd verilir ən böyük olanı ekrana çıxaran algorithm yazın. Misal: input a = 3, b = 15, c = 9  output 15



//ctrl+k+c -> ctrl+k+u
//int a = 12;
//int b = 12;
//int c = 3;


//if (a > b)
//{
//    if (a > c)
//    {
//        Console.WriteLine(a);
//        return;
//    }

//}
//else
//{
//    if (b > c)
//    {
//        Console.WriteLine(b);
//        return;
//    }

//}

//Console.WriteLine(c);




//int grade = 10;

//if(!(grade >=0 && grade <= 100))
//{
//    Console.WriteLine("Wrong input");
//    return;
//}


//if (grade < 65)
//{
//    Console.WriteLine("Kesilib");
//}
//else if(grade >=65 && grade < 85)
//{
//    Console.WriteLine("Adi");
//}
//else if (grade >= 85 && grade < 95)
//{
//    Console.WriteLine("Sheref");
//}
//else
//{
//    Console.WriteLine("Yuksek sheref");
//}




//58/10 int b=5     5  + 8 =13    58%10 - > 50/10   int a=8 



//int num = 5;
//int a = num % 10; //8
//int b= num / 10; //5
//int sum = (num % 10) + (num / 10);
//Console.WriteLine(sum); 
#endregion

#region Switch

//int choice = 3;
//if (choice == 1)
//{
//    Console.WriteLine("Az");
//}
//else if (choice == 2)
//{
//    Console.WriteLine("Ru");
//}
//else if (choice == 3)
//{
//    Console.WriteLine("Eng");
//}
//else
//{
//    Console.WriteLine("Wrong Input");
//}


//int choice = 9;

//switch (choice)
//{
//    case 1:
//        Console.WriteLine("Az dili secildi");
//        break;
//    case 2:
//        Console.WriteLine("Rus dili secildi");
//        break;
//    case 3:
//        Console.WriteLine("Eng dili secildi");
//        break;
//    default:
//        Console.WriteLine("Wrong input");
//        break;
//}


//string day = "Saturday";

//switch (day)
//{
//    case "Monday" or "Tuesday" or "Wednesday": 
//    case "Thursday":
//    case "Friday":
//        Console.WriteLine("Ish gunudur");
//        break;
//    case "Saturday": 
//    case "Sunday":
//        Console.WriteLine("Qeyri Ish gunudur");
//        break;

//} 
#endregion


//for (int i = 0; i <100; i++)
//{
//    Console.WriteLine(i);
//}

//for (int i =100; i >0; i--)
//{
//    Console.WriteLine(i);
//}





//for (int i = 1; i < 100; i++)
//{
//    if (i % 21 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}


//int count = 0;

//for (int i = 1; i < 100; i++)
//{
//    if(i%21==0)
//    {
//        count++;

//    }
//}
//Console.WriteLine(count);

//int sum = 0;

//for (int i = 1; i < 100; i++)
//{
//    if (i % 21 == 0)
//    {
//        sum += i;

//    }
//}
//Console.WriteLine(sum);

bool result = false;

Console.WriteLine("Please enter number:");
int start = int.Parse(Console.ReadLine());
int finish = int.Parse(Console.ReadLine());



for (int i = start; i <finish ; i++)
{
    if (i % 21 == 0)
    {
        result = true;
        Console.WriteLine(i);
        break;
    }

}

Console.WriteLine(result);
