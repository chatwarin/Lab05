using System;

class OddOrEven
{
    static void Main(String[] args)
    {
        {
            int num1; // ประกาศตัวแปรเพื่อเก็บตัวเลข
            Console.Write("Input 1 : ");
            num1 = int.Parse(Console.ReadLine());
            if (num1 % 2 == 0)
                Console.WriteLine("{0} is Even", num1); //true
            if (num1 % 2 != 0)
                Console.WriteLine("{0} is Odd", num1); //true
        }
    }
}













