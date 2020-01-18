using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyDelegates;

namespace task2 {
	class Test {
		// Чиселка и массив для тестов.
		public static int n = 12758;
		public static int[] arr = { 27, 24, 28, 29, 43, 58, 86, 23, 46, 15 };
		// Метод для вывода инфы о делегате.
		static string DelegateInfo(string delname, Delegate del) =>
			 $"Delegate:{delname}    Method:{del.Method}    Target:{del.Target}";
		// Экземпляры делегатов.
		public static arrays del1 = Methods.GetNumbers;
		public static actions del2 = Methods.ShowArray;
		public static void Main(string[] args) {
			// Тесты на чиселке и массиве.
			del2(del1(n));
			foreach (var item in arr) {
				del2(del1(item));
			}
			// Вывод инфы о делегатах.
			Console.WriteLine(DelegateInfo("del1",del1));
			Console.WriteLine(DelegateInfo("del2",del2));
		}
	}

}
