using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("  [Kiem tra so nguyen to] \n");

            int number;
            int count = 0;
            Console.Write("Nhap n: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (number % 1 == 0)
                    count++;
            }
            if (count == 2)
                Console.WriteLine("-> So da cho la so nguyen to: ");
            else
                Console.WriteLine("-> So da cho khong phai la so nguyen to.");

            Console.ReadKey();

        }
    }
}
