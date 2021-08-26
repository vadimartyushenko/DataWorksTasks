using System;

namespace DataWorksTasks
{
	#region Useful Tools
	public static class Tools
	{
		public static bool In(this int num, params int[] items)
		{
			foreach (var i in items)
				if (num == i)
					return true;

			return false;
		}
	}

 #endregion

 class Program
 {
	 static void Main(string[] args)
	 {
		 Test3();
	 }

	 static void Test1()
	 {
		 var converter = new ConverterRomanNumbers();

		 Console.Write("Введите римское число: ");
		 var s = Console.ReadLine();

		 if (!string.IsNullOrWhiteSpace(s))
		 {
			 var result = converter.RomanToInt(s);

			 Console.WriteLine(result > 0
				 ? $"Римское число {s} соответствует {result}"
				 : "Конвертировать Ваше число не удалось");
		 }
		 else
			 Console.WriteLine("Вы ввели пустую строку!");
	 }

	 static void Test2()
	 {
		 var example = "((1+3)()(4+(3-5)))";

		 var result = BracketBalance.Check(example, out string message);

		 Console.WriteLine(result ? "Баланс скобок соблюдается" : message);
	 }

	 static void Test3()
	 {
		 var linkedList = new DoubleLinkedList<int>();

		 linkedList.AddFirst(14);
		 linkedList.AddFirst(1);
		 linkedList.AddLast(18);

		 foreach (var i in linkedList)
		 {
			  Console.WriteLine(i); 
		 };

		 linkedList.Reverse();

		 Console.WriteLine("After reverse: ");

		 foreach (var i in linkedList)
		 {
			 Console.WriteLine(i);
		 };

		}
 }
}
