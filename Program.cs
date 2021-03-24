using System;

namespace Recursion_Prectice
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercises obj1 = new Exercises();
            Exercises obj2 = new Exercises();
            Exercises obj3 = new Exercises();
            Exercises obj4 = new Exercises();

            obj1.SumNum(6);
            obj2.SumDig(45);
            obj3.PrimeNum(11);
            obj4.JumpsQuantity(1);


            Console.WriteLine("Spiderman can jump " + obj4.t + " diffrent forms");
            Console.WriteLine("The sum of the numbers is " + obj1.s);
            Console.WriteLine("The sum of digits is " + obj2.n);
        }
    }
}
