using System;

namespace DataWorksTasks
{
	class BracketBalance
	{
		public static bool Check(string source, out string errorMessage, string bracketType = "()")
		{
			if (string.IsNullOrWhiteSpace(source))
				throw new Exception("string for check is empty");

			int openCount = 0, closeCount = 0;

			foreach (var c in source)
			{
				if (c == bracketType[0])
					openCount++;

				if (c == bracketType[1])
					closeCount++;
			}

			if (openCount > closeCount)
			{
				errorMessage = "В строке не хватает закрывающихся скобок";
				return false;
			}

			if (openCount < closeCount)
			{
				errorMessage = "В строке не хватает открывающихся скобок";
				return false;
			}

			errorMessage = string.Empty;
			return true;
		}
	}
}
