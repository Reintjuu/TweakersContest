/* Vraag 1 - Reversible Numbers
 * 
 * Sommige positieve getallen n hebben de eigenschap dat de som [ n + reverse(n) ] volledig bestaat uit oneven nummers.
 * Bijvoorbeeld, 36 + 63 = 99 en 409 + 904 = 1313. Deze getallen noemen we omkeerbaar; dus 36, 63, 409, en 904 zijn omkeerbaar.
 * Voorlopende nullen in n or reverse(n) zijn niet toegestaan.
 *
 * Er zijn 120 omkeerbare getallen onder 1000.
 *
 * Hoeveel omkeerbare getallen zijn er onder 100 miljoen (108)?
 */

using System;

namespace Q1
{
	class Program
	{
		static void Main(string[] args)
		{
			double x = Math.Pow(10, 8);
			int count = 0;
			for (int i = 0; i < x; i++)
			{
				if (i % 10 != 0)
				{
					int y = i + GetReverse(i);
					if (!HasEvenNumber(y))
						count++;
				}
			}

			Console.WriteLine(count);
			Console.ReadKey();
		}

		static int GetReverse(int x)
		{
			int y = 0;
			while (x > 0)
			{
				y = y * 10 + x % 10;
				x /= 10;
			}
			return y;
		}

		static bool HasEvenNumber(int x)
		{
			while (x > 0)
			{
				if (x % 2 == 0)
					return true;
				x /= 10;
			}

			return false;
		}
	}
}
