using System;

namespace ReverseNumber
{
    public  class Program
    {
        static void Main(string[] args)
        {
            int Num;
            Console.Write("Enter the Number:  ");
            Num = int.Parse(Console.ReadLine());

            int reverse = 0;

           while (Num > 0)
            {
                int Output = (Num % 10);
                reverse = reverse * 10 + Output;
                Num = (Num / 10);


            }
            Console.WriteLine(+  reverse  + " : is a reverse of a number  ");
            Console.ReadLine();
        }
    }
}
