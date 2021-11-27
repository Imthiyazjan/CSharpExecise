using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineTest
{
	public class Traversals
	{
		public Node root;
		public Traversals()
		{
			root = null;
		}

		public void InOrder()
		{
			PrintInOrder(root);
		}

		private void PrintInOrder(Node root)
		{
			if (root == null)
				return;
			PrintInOrder(root.left);
			Console.WriteLine(root.Data);
			PrintInOrder(root.right);
		}

		public void PreOrder()
		{
			PrintPreOrder(root);
		}

		private void PrintPreOrder(Node root)
		{
			if (root == null)
				return;
			Console.WriteLine(root.Data);
			PrintPreOrder(root.left);
			PrintPreOrder(root.right);
		}

		public void PostOrder()
		{
			PrintPostOrder(root);
		}

		private void PrintPostOrder(Node root)
		{
			if (root == null)
				return;
			PrintPostOrder(root.left);
			PrintPostOrder(root.right);
			Console.WriteLine(root.Data);
		}
	}
}
