using System;

class Program
{
    static void Main()
    {
        string inputString1 = Console.ReadLine();

        string stringWithoutSpecialChars = RemoveDigitsAndSpecialChars(inputString1);

        string inputString2 = Console.ReadLine();

        // Concatenate the two strings
        string resultString = stringWithoutSpecialChars +" "+ inputString2;

        // Display the result
        Console.WriteLine("Result String: " + resultString);
    }

    static string RemoveDigitsAndSpecialChars(string input)
    {
        string result = "";
        foreach (char c in input)
        {
            if (char.IsLetter(c) || char.IsWhiteSpace(c))
            {
                result += c;
            }
        }
        return result;
    }
}