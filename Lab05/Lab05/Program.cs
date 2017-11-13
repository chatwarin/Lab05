using System;
class Triangle
{
    static double TriangleArea(double totalW, double h)
    {
        double area =  h * 0.5 * totalW;
        return area;
    }

    static void Main()
    {
        Console.Write("Enter width1: ");
        double width1 = double.Parse(Console.ReadLine());
        Console.Write("Enter width2: ");
        double width2 = double.Parse(Console.ReadLine());
        double totalW = width1 + width2; // ผลรวมของความยาวของด้านคู่ขนาน
        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("The area of the triangle is {0:f2}.", TriangleArea(height,totalW));
    }
}












