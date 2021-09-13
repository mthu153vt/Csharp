using System;

namespace Bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
			int j, number1, number2;
			int USCLN = 1;

			Console.Write("[Tim uoc chung lon nhat] \n");
			Console.Write("\n");
			Console.Write("Nhap so thu nhat: ");
			number1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Nhap so thu hai: ");
			number2 = Convert.ToInt32(Console.ReadLine());
			j = (number1 < number2) ? number1 : number2;
			for (int i = 1; i <= j; i++)
			{
				if (number1 % i == 0 && number2 % i == 0)
				{
					USCLN = i;
				}
			}
			Console.Write("USCLN cua {0},{1} la: {2}", number1, number2, USCLN);
			Console.ReadKey();
		}
    }
}
