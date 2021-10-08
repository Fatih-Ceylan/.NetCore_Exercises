using System;
namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz: ");
            while (!Int32.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Lütfen sadece sayı giriniz");
            }
            int sayi = Convert.ToInt32(Console.ReadLine());
            //CheckNumber(sayi);


            Console.WriteLine(sayi + " " + "Sayısının faktöryeli: " + factorial_WhileLoop(sayi));
            Console.ReadLine();
        }

        public static double factorial_WhileLoop(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }
    }
}
