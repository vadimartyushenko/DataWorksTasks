using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataWorksTasks.Tests
{
	[TestClass]
	public class DoubleLinkedListTest
	{
		[TestMethod]
		public void Reverse_1_14_18_return_18_14_1()
		{
			//arrange
			var linkedList = new DoubleLinkedList<int>();
			linkedList.AddFirst(14);
			linkedList.AddFirst(1);
			linkedList.AddLast(18);

			var expected = new DoubleLinkedList<int>();
			expected.AddFirst(1);
			expected.AddFirst(14);
			expected.AddFirst(18);

			//act
			linkedList.Reverse();
			var actual = linkedList;

			//assert
			actual.Select(x => x).Should().Equal(expected.Select(x => x));
		}
	}
}
