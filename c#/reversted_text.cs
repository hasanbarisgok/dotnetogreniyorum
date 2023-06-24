using System;

void Enter_Sentence()
{
    Console.Write("Enter the sentence you want to reverse");

    string? text = Console.ReadLine();

    Print_Reverse(text);
}

void Print_Reverse(string text)
{
    string reversted_text = "";

    for (int i = text.Length - 1; i>=0; i--)
    {
        reversted_text += text[i];
    }

    Console.WriteLine($"Reversted Text: {reversted_text}");
    
}

Enter_Sentence();
