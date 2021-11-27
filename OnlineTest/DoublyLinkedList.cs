using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineTest
{
	public class DoublyLinkedList
	{
		public Node head; // head of list

		/* Doubly Linked list Node*/
		public class Node
		{
			public int data;
			public Node prev;
			public Node next;

			// Constructor to create a new node
			// next and prev is by default
			// initialized as null
			public Node(int d) { data = d; }
		}

		// Adding a node at the front of the list
		public void push(int new_data)
		{
			// 1. allocate node
			// 2. put in the data
			Node new_Node = new Node(new_data);

			// 3. Make next of new node as head
			// and previous as NULL
			new_Node.next = null;
			new_Node.prev = head;

			// 4. change prev of head node to new node
			if (head != null)
				head.next = new_Node;

			// 5. move the head to point to the new node
			head = new_Node;
		}

		// This function prints contents of linked list
		// starting from the given node
		public void printlist(Node node)
		{

			while (node != null)
			{
				Console.Write(node.data + " ");
				node = node.prev;
			}

			Console.WriteLine();
		}

		// Function to delete a node in a Doubly Linked List.
		// head_ref --> pointer to head node pointer.
		// del --> data of node to be deleted.
		public void deleteNode(Node del)
		{

			// Base case
			if (head == null || del == null)
			{
				return;
			}

			// If node to be deleted is head node
			if (head == del)
			{
				head = del.prev;
			}

			// Change next only if node to be deleted
			// is NOT the last node
			if (del.next != null)
			{
				del.next.prev = del.prev;
			}

			// Change prev only if node to be deleted
			// is NOT the first node
			if (del.prev != null)
			{
				del.prev.next = del.next;
			}

			// Finally, free the memory occupied by del
			return;
		}

		public void Reverse() {
			Node current = head;
			while (current.prev != null)
			{
				Node newnode = current.prev; //15			
				current.prev = current.next; //null
				current.next = newnode; //15
				current = current.prev; //15
			}

			Console.WriteLine(current);
		}
	}
}
