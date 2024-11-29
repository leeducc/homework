using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Input a phone number: ");
        string input = Console.ReadLine();

        string pattern = @"(\d{4})(\d{3})(\d{3})";
        string replacement = "($1) $2-$3";

        string formattedPhoneNumber = Regex.Replace(input, pattern, replacement);

        Console.WriteLine($"Formatted phone number: {formattedPhoneNumber}");
    }
}
