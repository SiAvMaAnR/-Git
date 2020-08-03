using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обучение_Git
{
	class Program
	{
		static decimal factorial(int N,ref string STR)
		{
			if (N > 1)
			{
				STR += N.ToString() + " * ";
				return N * factorial(N - 1, ref STR);
			}
			else
			{
				STR += "1 = ";
				return 1;
			}
		}

		static void Main(string[] args)
		{
			string STR="";
			Console.Write("Факториал: ");
			decimal fact = factorial(int.Parse(Console.ReadLine()), ref STR);
			Console.WriteLine("Алгоритм: "+STR+fact);
			Console.WriteLine();
		}
	}
}
