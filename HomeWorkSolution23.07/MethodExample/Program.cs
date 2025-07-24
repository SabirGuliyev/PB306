

using System;

//int[] nums = { 0,11, 13, 20, 55, 127,27 };


//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] < 2)
//    {
//        continue;
//    }
//    for (int j = 2; j * j <= nums[i]; j++)
//    {
//        if (nums[i] % j == 0)
//        {
//            Console.WriteLine(nums[i] + " Murekkebdir");
//            break;
//        }
//    }
//}



int[] numbers = { 288, 34, 1, -5, 9, 7 ,-5,34};

int step = 0;
for (int i = 0; i < numbers.Length-1; i++)
{
    step++;
    if (numbers[i] > numbers[i + 1])
    {
        //a=5  b=10   a+=b  a=15  b=5   a=10
        numbers[i] += numbers[i + 1];
        numbers[i+1]= numbers[i]-numbers[i+1];
        numbers[i] = numbers[i]-numbers[i+1];
        i = -1;
    }
}


for (int i = 0;i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

Console.WriteLine("Addimlar: "+step);