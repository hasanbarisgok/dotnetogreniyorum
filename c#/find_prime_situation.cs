using System;

void Find_Prime_Situation(int num)
{
    int counter = 0;
    int i = 2;

    while (i < num)
    {
        
        if (num % i == 0)
        {
            counter += 1;
        }

        i += 1;
    
    }

    if (counter > 0 || num == 1)
    {
        Console.WriteLine($"The number you selected, {num}, is not a prime number.");
    }
    
    else
    {
        Console.WriteLine($"The number you selected, {num}, is a prime number.");
    }

}

void Nums_Count_Info()
{
    Console.Write("How many different prime numbers will be entered: ");
    
    int num_count = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < num_count; i++)
    
    {
        Console.Write($"Please enter the {i + 1}th number you want to enter: ");
        int entered_num = Convert.ToInt32(Console.ReadLine());
        Find_Prime_Situation(entered_num);
    }
}

Nums_Count_Info();
