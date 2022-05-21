// Robert Calero - App displaying Linked Lists
using System;

class LinkedList
	{
		private int _Count;
		LinkedListNode _Head = null;

		public LinkedList()
			{
				_Head=  null;
				_Count = 0;
			}

		public void AddNodeToFront(int paramData)
			{
				LinkedListNode node = new LinkedListNode(paramData);
				node._Next = _Head;
				_Head = node;
				_Count++;
			}

		public void PrintList()
			{
				LinkedListNode runner = _Head;

				while(runner != null)
					{
						Console.WriteLine(runner._Data);
						runner = runner._Next;
					}
			}
	}