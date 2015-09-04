/* Vraag 4 - Fungi
 * De schimmel F. ellipsoidea wordt erg groot. De fibonacci reeks bepaald het aantal
 * centimeters dat de schimmel dagelijks in diameter toeneemt.
 *
 * Bereken de omtrek van de schimmel na 1000 dagen groeien.
 */

using System;

namespace Q4
{
	class Program
	{
		static void Main(string[] args)
		{
			RecursiveFibonacci(0, 1, 0, 1000, 0);

			Console.ReadKey();
		}

		private static void RecursiveFibonacci(double a, double b, int i, int length, double sum)
		{
			if (i < length)
			{
				RecursiveFibonacci(b, a + b, i + 1, length, sum + a);
			}
			else
			{
				Console.Write("{0:#.####E+000} ", sum * Math.PI);
			}
		}
	}
}