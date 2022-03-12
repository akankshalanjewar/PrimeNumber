using System;

namespace PrimeNumber
{
    public class Program
    {
        static void Main(string[] args)
        {

            int Num;
            Console.Write("Enter  the number: ");
            Num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Num / 2; i++)
            {
                if (Num % 2==0)
                {
                    Console.WriteLine(" is not a  prime number"); 
                }
                else
                {
                    Console.WriteLine("is a prime number");
                   
                }

            }

            Console.ReadLine();

        }
    }
}
