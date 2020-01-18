using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1 {
	class Program {
		// Делегат-тип.
		public delegate int cast(double val); 
		public static Random rnd = new Random(113);
		static void Main(string[] args) {
			// Создание переменных и их инстанцирование.
			cast cast1 = delegate (double val) { return (int)val % 2 == 0 ? (int)val : (int)val + 1; };
			cast cast2 = delegate (double val) { return (int)Math.Log10(val) + 1; };
			cast castsumm = cast1;
			castsumm += cast2;

			// Проверка на одном значении.
			int k = 9;
			Console.WriteLine(k);
			Console.WriteLine(cast1(k));
			Console.WriteLine(cast2(k));
			Console.WriteLine(castsumm(k));
			Console.WriteLine();
			// Проверка на большем количестве значений.
			for (int i = 0; i < 10; i++, Console.WriteLine()) {
				double q = rnd.Next() * rnd.NextDouble();
				Console.WriteLine(q);
				Console.WriteLine(cast1(q));
				Console.WriteLine(cast2(q));
				// Вызов методов через многоадересный делегат.
				Console.WriteLine(castsumm(q));
			}
		}
	}
}
