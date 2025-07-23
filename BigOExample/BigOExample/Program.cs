
#region Homework

//1. Verilmish ededin 2 quvveti olub olmadigini tapan alqoritm misal:input 6, output quvveti deyil.  input 8 output quvvetidir
//int num = int.Parse(Console.ReadLine());


// 9  1  1  3
//if (num != 0)
//{
//    while (num % 2 == 0)
//    {
//        num /= 2;

//    }
//    if(num ==1)
//    {
//        Console.WriteLine("Quvvetidir"); 
//    }
//    else 
//    {
//        Console.WriteLine("Quvveti deyil");
//    }
//}
//else
//{
//    Console.WriteLine("0 neytral");
//}


//task 2
//2.Ədədlərdən ibarət arrayın ən kiçik elementini tapın

//int[] numbers = { 13,-2,8, 3, 4, -5, 10 };
//int min = numbers[0];
//for (int i = 0;i < numbers.Length; i++)
//{
//    if (numbers[i] < min)
//    {
//        min = numbers[i];
//    }
//}
//Console.WriteLine(min);




//
//3.Sozlerden ibaret arrayde uzunlugu 4-den boyuk olan sozleri ekrana çap edin
//string[] words = { "sun", "moon", "rainbow", "colours", "framework", "cat" };
//int num = 4;

//for (int i = 0; i < words.Length; i++)
//{ 
//    if (words[i].Length>num)
//    {
//        Console.WriteLine(words[i]);
//    }
//}

//4.(optional) 1 - den 10 qeder olan arrayda bir reqem eskikdir. Eskik olan reqemi tapan algorithm yazin ve nezere alin ki verilen arrayda reqemler siralanmadan duzulub misal: input {4, 1, 9, 6, 10, 2, 5, 8, 3} output 7

//1 2 3 4 5 6 7 8 9 10
//int[] nums = { 6, 5, 1, 2, 9, 8, 7, 4, 10 };

//int sum = 0;
//for (int i = 0; i < nums.Length; i++)
//{
//    sum += nums[i];

//}

//int sum2 = 0;
//for (int i = 0; i <= 10; i++)
//{
//    sum2 += i;
//}

//Console.WriteLine(sum2-sum); 
#endregion

#region Big O examples
//int[] arr = { 1, 2, 3,10,11,50,70,80 };


//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}


//int num = 100;
//int step = 0;

//for (int i = 0; i < num; i++)
//{
//    Console.WriteLine("1ci dovr bashladi");
//    for (int j = 0; j < num; j++)
//	{
//        Console.WriteLine("2-ci dovr");
//        step++;
//    }
//}

//Console.WriteLine(step);


//int num = 127;
//bool result = false;
//int step = 0;

//for (int i = 2;i*i<= num; i++)
//{
//    if (num % i == 0)
//    {
//        result = true;
//        break;
//    }
//    step++;
//}

//if (result)
//{
//    Console.WriteLine("Murekkeb");
//}
//else
//{
//    Console.WriteLine("sadedir");
//}
//Console.WriteLine(step);



#endregion

#region Linear and Binary search
//int[] nums = { 67, 4, 12, 45, 13, 7, 4, 5, 10 };

//int search = 10;
//int step = 0;

//for (int i = 0; i < nums.Length; i++)
//{
//    step++;
//    if (nums[i] == search)
//    {
//        Console.WriteLine("bu eded movcuddur: "+i);
//        break;
//    }

//}


//Console.WriteLine("Addimlarin sayi: "+step);










//                0   1  2  3   4   5   6   7   8   9
//int[] numbers = { 1, 6, 9, 11, 15, 20, 23, 27, 50, 60 };
/////////////////  L                               H
//int low = 0;
//int high= numbers.Length - 1;
//int mid= (low + high)/2;

//int search = 9;

//int step = 0;


//while (numbers[mid] != search)
//{
//    step++;
//    if (numbers[mid] > search)
//    {
//        high = mid-1;
//    }
//    else
//    {
//        low = mid+1;
//    }
//    mid = (low + high) / 2;

//}

//Console.WriteLine(numbers[mid]);
//Console.WriteLine("Addimlar:"+step);

#endregion

#region Bubble Sort
//int[] nums = { 56, 12, 75, 5, -5, 0, 9, 100, 17 };
//int step = 0;
//for (int i = 0; i < nums.Length; i++)
//{
//	for (int j = 0; j < nums.Length - 1 - i; j++)
//	{
//		step++;
//		if (nums[j] > nums[j + 1])
//		{
//			int temp = nums[j];
//			nums[j] = nums[j + 1];
//			nums[j + 1] = temp;
//		}
//	}

//}

//for (int i = 0; i < nums.Length; i++)
//{
//	Console.WriteLine(nums[i]);
//}

//Console.WriteLine("Addimlar:" + step); 
#endregion