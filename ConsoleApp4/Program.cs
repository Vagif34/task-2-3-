using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //static int Area(int a, int b,int c,int p,int r);

            int a = 2;//int.Parse(Console.ReadLine());
            int b = 4; //int.Parse(Console.ReadLine());
            int c = 6; //int.Parse(Console.ReadLine());
            int p = 8; //int.Parse(Console.ReadLine());
            int r = 10; //int.Parse(Console.ReadLine());
            
            Console.WriteLine("Duzbucaqlini sahesi");
            Print(a*b);
            Console.WriteLine("Cevrenin sahesi");
            Print(p * (r * r));
            Console.WriteLine("Duzbucaqli paralelpipedin sahesi");
            Print(2 * (a * b + a * c + b * c));
            Console.WriteLine("Ucbucaqin daxiline cekilmis cerenin sahesi");
            Print(p * r);
        } 
        static void Print (int S)
        { 
            Console.WriteLine(S);
        }
        


    }
}
