/* Vraag 2 - Fibonacci
 *
 * De Fibonaccireeks is een rij van getallen die ten grondslag ligt aan vele processen in de natuur, 
 * van de structuur van zonnebloemen tot de explosieve groei van een konijnenpopulatie.
 * De reeks begint met de getallen 0 en 1, waarna ieder volgend getal de som is van zijn 2 voorgangers.
 * Het begin is dus: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, etc.
 *
 * Stel dat je van alle Fibonaccigetallen tot 1.000.000.000.000.000.000 (1018) de afzonderlijke cijfers
 * optelt, hoe vaak komt daar een getal uit dat zelf het kwadraat is van een geheel getal?
 */

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