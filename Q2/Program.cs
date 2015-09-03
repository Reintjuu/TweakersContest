using System;

namespace Q2
{
	class Program
	{
		private static int count;

		static void Main(string[] args)
		{
			count = 0;
			RecursiveFibonacci(0, 1, 1);
			Console.Write("\n\nThere's a total of " + count + " perfect squares.");
			Console.ReadKey();
		}

		private static void RecursiveFibonacci(long a, long b, int counter)
		{
			if (a <= Math.Pow(10, 18))
			{
				Console.Write("{0} ", a);

				if (IsPerfectSquare(SumOfDigits(a)))
				{
					count++;
				}

				RecursiveFibonacci(b, a + b, counter + 1);
			}
		}

		private static long SumOfDigits(long x)
		{
			long y = 0;
			while (x > 0)
			{
				y += x % 10;
				x /= 10;
			}

			return y;
		}

		private static bool IsPerfectSquare(long number)
		{
			if (number > 0)
			{
				double result = Math.Sqrt(number);
				return result % 1 == 0;
			}
			return false;
		}
	}
}