using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataWorksTasks.Tests
{
	[TestClass]
	public class BracketBalanceTest
	{
		[TestMethod]
		public void Check_ValidString_TrueReturned()
		{
			//arrange
			var source = "((1+3)()(4+(3-5)))";
			var expected = true;

			//act
			var actual = BracketBalance.Check(source, out string message);

			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Check_InvalidString_FalseReturned()
		{
			//arrange
			var source = "((1+3)()))(4+(3-5)))";
			var expected = false;

			//act
			var actual = BracketBalance.Check(source, out string message);

			//assert
			Assert.AreEqual(expected, actual);
		}

	}
}
