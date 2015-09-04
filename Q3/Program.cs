/*
 * Vraag 3 - Moving Object
 * Een object zweeft met een vaste snelheid van 20 punten p/s door de ruimte.
 * Op het moment van schrijven bevindt het object zich op positie x: 30, y: 50 en z: 90.
 * Het object beweegt naar x: 4^6, y: 4^8 en z: 9.
 * Wat zijn de coördinaten van het object na 25 minuten. Afgerond op 2 decimalen
 * 
 * Voorbeeldnotatie antwoord: x:1.200,12 y:24.150,00 z:160,98 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	public struct Vector3
	{
		public double x, y, z;

		public Vector3(double x, double y, double z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public override string ToString()
		{
			return (String.Format("(x:{0} y:{1} z:{2})", x, y, z));
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Vector3 a = new Vector3(30, 50, 90);
			Vector3 b = new Vector3(Math.Pow(4, 6), Math.Pow(4, 8), 9);

			Console.WriteLine(Lerp(a, b, (20 * 60 * 25) / Magnitude(Difference(a, b))));

			//Console.WriteLine(Math.Cos(DotProduct(a, b) / (Magnitude(a) * Magnitude(b))));

			Console.ReadKey();
		}

		private static double DotProduct(Vector3 a, Vector3 b)
		{
			return a.x * b.x + a.y * b.y + a.z * b.z;
		}

		private static double Magnitude(Vector3 vector)
		{
			return Math.Sqrt(vector.x * vector.x + vector.y * vector.y + vector.z + vector.z);
		}

		private static Vector3 Difference(Vector3 a, Vector3 b)
		{
			return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
		}

		private static Vector3 Lerp(Vector3 a, Vector3 b, double t)
		{
			return new Vector3(a.x * t + b.x * (1 - t), a.y * t + b.y * (1 - t), a.z * t + b.z * (1 - t));
		}
	}
}