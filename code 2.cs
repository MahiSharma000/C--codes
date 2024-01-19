using System;

class Program
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        int digitSum = CalculateDigitSum(inputString);
        Console.WriteLine("Sum of digits: " + digitSum);
    }

    static int CalculateDigitSum(string input)
    {
        int digitSum = 0;
        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                digitSum += int.Parse(c.ToString());
            }
        }

        return digitSum;
    }
}