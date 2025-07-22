
#region HomeWork
//string month = Console.ReadLine();

//switch(month)
//{
//    case "Januray":
//    case "March":
//        Console.WriteLine(31);
//        break;
//    case "April":
//    case "September":
//        Console.WriteLine(30);
//        break;
//    case "Fevral":
//        Console.WriteLine(28);
//        break;
//    default:
//        Console.WriteLine("Wrong Input");
//        break;
//}



//int cem = 0;

//for (int i = 0; i < 100; i++)
//{
//    if (i % 2 == 0)
//        cem += i;
//}

//Console.WriteLine(cem);




//20      2 3 4 5 6 7 8 9 10 11 ... 19

//int num =int.Parse(Console.ReadLine());

//if (num > 1)
//{
//    bool result = false;

//    for (int i = 2; i < num; i++)
//    {
//        if (num % i == 0)
//        {
//            result = true;
//            break;
//        }
//    }


//    if (result)
//    {
//        Console.WriteLine(num + " Murekkebdir");
//    }
//    else
//    {
//        Console.WriteLine(num + " Sadedir");
//    }

//}
//else
//{
//    Console.WriteLine(num +" Neyrtal ededdir");
//}

#endregion







//int num = 81;
//int count = 0;
//while (num % 2 == 0)
//{
//    num /= 2;
//    count++;
//}

//do
//{
//    num /= 2;
//    count++;
//} while (true);

//Console.WriteLine(count);


//for (; num % 2 == 0; )
//{
//    num /= 2;
//    count++;
//}

//Console.WriteLine(count);




//int i = 0;
//int sum = 0;

//while (i < 100)
//{
//    if (i % 2 == 0)
//    {
//        sum += i;
//    }

//    i++;
//}

//Console.WriteLine(sum);


//int i = 0;
//int sum2 = 0;

//while (i < 100)
//{
//    if (i % 2 == 0)
//    {
//        sum += i;
//    }

//    i++;
//}

//Console.WriteLine(sum);





//string answer = "";
//while (answer == "y" || answer == "yes")
//{

//    Console.WriteLine("Program devam etsinmi?(y/n)");
//    answer = Console.ReadLine();
//}

//Console.WriteLine("Program bitdi");

//string answer = "";
//do
//{
//    Console.WriteLine("Program devam etsinmi?(y/n)");
//    answer = Console.ReadLine();
//} while (answer == "y" || answer == "yes");

//Console.WriteLine("Program bitdi");



//int sum = 0;

//for (int i = 0; i < 100; i++)
//{
//    if (i % 2 == 0)
//    {
//        sum += i;
//    }

//}

//Console.WriteLine(sum);




//111  10000 12312323423432

//int num = 0;// 123/ 10     12/10   1/10  0/10
//int count = 0;

//while (num != 0)
//{

//    num /= 10;
//    count++;
//}

//Console.WriteLine(count);

//int num = 12322;// 123/ 10     12/10   1/10  0/10
//int count = 0;

//do
//{
//    num /= 10;
//    count++;
//} while (num != 0);

//Console.WriteLine(count);
//                       1       2         3         4         5         6

string name = "Fidan";
string[] students = { "Nasib",name, "Eynulla", "Konul", "Rafiq" };

Console.WriteLine(students.Rank);

//////////////////////// 0       1          2         3        4          5
///

//for(int i = 0; i < students.Length; i++)
//{
//    students[i] += " PB306";
//    Console.WriteLine(students[i]);
//}


//int[] numbers = { 1, 7, 21, 9, 13 };
////int count = 0;
//bool result = false;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 2 == 0)
//    {
//        result = true;
//        break;
//        //count++;
//    }
//}

//Console.WriteLine(result);



//string word = "sAlwm ";
//bool result = false;
//Console.WriteLine(word.Length);

//for (int i = 0; i < word.Length; i++)
//{
//    if (word[i] == 'a' || word[i]=='A')
//    {
//        result=true;
//        break;
//    }
//}
//Console.WriteLine(result);

//jagged aa


int[,] numbers =
{
    { 1,2,3},
    { 4,5,6},
    { 5,8,7}
};

Console.WriteLine(numbers.Rank);













//students[0] = null;


//Console.WriteLine(students[0]);


