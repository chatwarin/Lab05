using System;
class CountE
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string s = Console.ReadLine();
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'E') count++;
        }
        Console.WriteLine("There are {0} E's in the string", count);
    }
}












