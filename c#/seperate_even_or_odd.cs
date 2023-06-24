using System;


void Nums_Count_Info()
{
    Console.Write("How many different numbers will be entered: ");

    int num_count = Convert.ToInt32(Console.ReadLine());

    Get_Nums(num_count);

}

void Get_Nums(int num_count)
{

    int[] nums = new int[num_count];

    for (int i =0; i < num_count; i++)
    {
        Console.Write($"Please enter the {i + 1}th num: ");

        int entered_num = Convert.ToInt32(Console.ReadLine());

        nums[i] = entered_num;        
    }

    Sort_Nums(nums);

    Seperate_Even_or_Odd(nums);
}

void Sort_Nums(int[] nums)
{
    int[] sorted_nums = (int[])nums.Clone();
    Array.Sort(sorted_nums);

    Console.Write("Sorted Nums:\n");
    foreach(int num in sorted_nums)
    {
        Console.WriteLine(num);
    }

}

void Seperate_Even_or_Odd(int[] nums)
{
    List<int> oddNums = new List<int>();
    List<int> evenNums = new List<int>();

    foreach (int num in nums)
    {
        if (num % 2 == 0)
        {
            evenNums.Add(num);
        } else
        
        {
            oddNums.Add(num);
        }

    }

    Console.Write("Even Nums:\n");

    foreach (int num in evenNums)
    {
        Console.WriteLine(num);
    }

    Console.Write("Odd Nums:\n");

    foreach (int num in oddNums)
    {
        Console.WriteLine(num);
    }
}




Nums_Count_Info();
