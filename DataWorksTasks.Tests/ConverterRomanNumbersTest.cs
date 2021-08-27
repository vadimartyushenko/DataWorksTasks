using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataWorksTasks.Tests
{
	[TestClass]
	public class ConverterRomanNumbersTest
	{
		[TestMethod]
		public void RomanToInt_MCMXCIX_1999returned()
		{
			//arrange
			var source = "MCMXCIX";
			var expected = 1999;

			//act
			var converter = new ConverterRomanNumbers();
			var actual = converter.RomanToInt(source);

			//assert
			Assert.AreEqual(expected, actual);
		}
	}
}
