using System.Collections.Generic;
using System.Linq;

namespace DataWorksTasks
{
	public class ConverterRomanNumbers
	{
		private readonly Dictionary<char, int> _romanNumbers = new Dictionary<char, int>
		{
			{'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
		};

		public int RomanToInt(string source)
		{
			
			int result = 0, previous = 0;

			foreach (var i in source.Trim().Reverse())
			{
				if (!_romanNumbers.ContainsKey(i))
					return -1;
				
				var current = _romanNumbers[i];
				
				if (current < previous)
					if (current.In(1, 10, 100, 1000) && previous / 5 < 3*current)//проверка правил вычитания
						result -= current;
					else
						return -1;
				else
					result += current;

				previous = current;
			}

			return result;
		}
	}
}
