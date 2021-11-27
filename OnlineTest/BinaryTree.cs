using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineTest
{
    public class BinaryTree
    {
        public Node root;
        public BinaryTree()
        {
            root = null;
        }

        public void Insert(int i)
        {
            Node newNode = new Node();
            newNode.Data = i;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.Data)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public void PrintTree()
        {
            if (root == null)
                Console.WriteLine("Tree is empty");
            else
            {
                PrintNode(root);
            }

        }

        private void PrintNode(Node n)
        {
            if (n != null)
            {
                Console.WriteLine("Data {0}", n.Data);
                if (n.left == null)
                {
                    n = n.right;
                    PrintNode(n);
                }
                else
                {
                    n = n.left;
                    PrintNode(n);
                }
            }
            else
                return;
        }

        public void Search(int val)
        {
            Node current = root;
            if (current.Data == val)
                return;
            //while (current != null) //Node & 23 != 15
            //{
            //    if (current.Data > val) //23 > 15 
            //        current = current.left; //
            //    else if (current.Data == val) { 
            //        Console.WriteLine("I Found");
            //        break;
            //    }
            //    else
            //        current = current.right;
            //}
            //Console.WriteLine("Not found");
            Console.WriteLine(SearchRecur(current, val));
        }

        private bool SearchRecur(Node current, int target)
        {
            if (current != null)
            {
                if (current.Data > target)
                    return SearchRecur(current.left, target);
                else if (current.Data < target)
                    return SearchRecur(current.right, target);
                else
                    return true;
            }
            else
                return false;
        }
    }

    public class Node
    {
        public int Data;
        public Node left;
        public Node right;

        public Node()
        {
        }

        public Node(int data)
        {
            this.Data = data;
            this.left = this.right = null;
        }
    }
}
