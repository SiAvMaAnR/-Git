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
			if (N != 0)
			{
				return N * factorial(N - 1,ref STR);
			}
			else
				return 1;
		}

		static void Main(string[] args)
		{
			string STR="";
			int N=int.Parse(Console.ReadLine());
			Console.WriteLine(factorial(N,ref STR));
		}
	}
}
