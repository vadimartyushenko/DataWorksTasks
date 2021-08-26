using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWorksTasks
{
	public class DoubleLinkedListNode<T>
	{
		public DoubleLinkedListNode(T data)
		{
			Value = data;
		}
		public T Value { get; set; }
		public DoubleLinkedListNode<T> Next { get; set; }
		public DoubleLinkedListNode<T> Prev { get; set; }
	}
	public class DoubleLinkedList<T> : IEnumerable<T>
	{
		public DoubleLinkedList()
		{
			CountNode = 0;
		}
		public DoubleLinkedListNode<T> First { get; private set; }
		public DoubleLinkedListNode<T> Last { get; private set; }

		public int CountNode { get; private set; }

		#region Public methods

		public void AddFirst(T value)
		{
			var node = new DoubleLinkedListNode<T>(value);
			{
				node.Next = First;
			}

			if (CountNode == 0)
				Last = node;
			else
				First.Prev = node;

			First = node;

			CountNode++;
		}

		public void AddLast(T value)
		{
			var node = new DoubleLinkedListNode<T>(value);
			{
				node.Prev = Last;
			}

			if (CountNode == 0)
				First = node;
			else
				Last.Next = node;

			Last = node;

			CountNode++;
		}

		public void Reverse()
		{
			if (CountNode < 2)
				return;

			var startNode = First;
			DoubleLinkedListNode<T> temp = null;

			while (startNode != null)
			{
				temp = startNode.Next;
				startNode.Next = startNode.Prev;
				startNode.Prev = temp;
				
				if (startNode.Prev == null)
				{
					First = startNode;
				}

				startNode = startNode.Prev;
			}
		}

		#endregion

		#region Implementation IEnumerable

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable) this).GetEnumerator();
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			var currentNode = First;
			while (currentNode != null)
			{
				yield return currentNode.Value;
				currentNode = currentNode.Next;
			}
		}

		#endregion
	}
}
