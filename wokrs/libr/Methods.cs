using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Methods {
	// Методы для делегатов.
	public static int[] GetNumbers(int n) {
		return Array.ConvertAll(n.ToString().ToCharArray(), x => x - '0');
	}
	public static void ShowArray(int[] arr) {
		foreach (var item in arr) {
			Console.Write(item);
			Console.Write(" ");
		}
		Console.WriteLine();
	}
}

