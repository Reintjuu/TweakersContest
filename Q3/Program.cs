/* Vraag 3 - Moving Object
 * 
 * Een object zweeft met een vaste snelheid van 20 punten p/s door de ruimte.
 * Op het moment van schrijven bevindt het object zich op positie x: 30, y: 50 en z: 90.
 * Het object beweegt naar x: 4^6, y: 4^8 en z: 9.
 * Wat zijn de coördinaten van het object na 25 minuten. Afgerond op 2 decimalen
 * 
 * Voorbeeldnotatie antwoord: x:1.200,12 y:24.150,00 z:160,98 
 */

using System;

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

		public static Vector3 operator *(Vector3 a, float d)
		{
			return new Vector3(a.x * d, a.y * d, a.z * d);
		}

		public static Vector3 operator +(Vector3 a, Vector3 b)
		{
			return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Vector3 a = new Vector3(30, 50, 90);
			Vector3 b = new Vector3(Math.Pow(4, 6), Math.Pow(4, 8), 9);

			Vector3 movement = Difference(b, a);
			Vector3 position = Normalize(movement) * 20f * 60f * 25f + a;
			Console.WriteLine(position);

			Console.ReadKey();
		}

		private static Vector3 Difference(Vector3 a, Vector3 b)
		{
			return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
		}

		private static Vector3 Normalize(Vector3 a)
		{
			double distance = Math.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z);
			return new Vector3(a.x / distance, a.y / distance, a.z / distance);
		}
	}
}