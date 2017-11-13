using System;

class TryCatch 
{
    static void Main()
    {
        double d = 5e9d;
        try
        { Console.WriteLine(d); }
        catch
        {
            int i = checked((int)d);
            Console.WriteLine(i);
        }

    }
}












