using System;

namespace lab1ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            //citim 3 numere si le afisam descrescator
            int x, y, z;
            Console.WriteLine("Introduceti 3 numere: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            if (x < y & y<z) Console.WriteLine(z + " " + y + " " + x);
            else if(x< y & x<z & y>z ) Console.WriteLine(y + " " + z + " " + x);
            else if(y<x & y<z & x<z) Console.WriteLine(z + " " + x + " " + y);
            else if(y < x & y < z & x > z) Console.WriteLine(x + " " + z + " " + y);
            else if(x<y) Console.WriteLine(y + " " + x + " " + z);
            else Console.WriteLine(x + " " + y + " " + z);
        }
    }
}
