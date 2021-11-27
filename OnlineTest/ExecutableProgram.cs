using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineTest
{
    public class ExecutableProgram
    {
        /// <summary>
        /// Given an array A of 0's and 1's, Insert 0 and 1 alternatively after consecutive(K times) of 1 is found.
        /// </summary>
        /// <param name="int_array">An Int Array</param>
        /// <param name="k">Indicates the nth repeat</param>
        /// <returns>Returns the new int array with alternative of 1 is found</returns>        
        /// <example>10110110111111</example>
        /// <result>1011001110110111110</result>
        public void AlternativeKElementonArray() {            
            int[] int_array = new int[] { 1, 0, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1 };
            Console.WriteLine("Input's are:");
            foreach (int i in int_array)
            {
                Console.Write(i);
            }
            int k = 2;
            Alternative1onArray ar = new Alternative1onArray();
            Console.WriteLine("\nOutput's are:");
            ar.PrintArray(int_array, k);
        }

        /// <summary>
        /// Print pyramid using Integer value upto given n
        /// </summary>
        /// <param name="int_upto">An Int Value</param>
        /// <returns>Returns the pyramid with given integer value</returns>        
        /// <example>3</example>
        /// <result>
        ///         1
        ///        121
        ///       12321 
        /// </result>
        public void NumberPyramid() 
        {
            Printpyramid pp = new Printpyramid();
            int int_upto = 3;
            pp.PrintPyramid(int_upto);
        }

        /// <summary>
        /// Print maximum count of repeated charaters continously in a string
        /// </summary>
        /// <param name="str_input">A String Value</param>
        /// <returns>Returns the maximum count of repeated character other wise return -1</returns>        
        /// <example>baaabcdddddc</example>
        /// <result>5</result>
        /// <remarks>5 because d is repeated for 5 times continously</remarks>
        public void MaxofRepeatedCharacter() {
            string str_input = "baaabcdddddc";
            PrintNorepetants pn = new PrintNorepetants();
            int max = pn.printNoofrepeats(str_input);
            Console.WriteLine(max);
        }

        /// <summary>
        /// Sort an array based on it 2nd element of the array if it same sort will based on 1st element
        /// </summary>
        /// <param name="int_array">An Int Array</param>
        /// <returns>Returns Sorted array based on 2nd and 1st element</returns>        
        /// <example>{ 3, 1 }, { 1, 1 }, { 2, 2 }, { 5, 2 }</example>
        /// <result>{ 1, 1 },{ 3, 1 }, { 2, 2 }, { 5, 2 }</result>
        public void SortBasedon2Element()
        {
            int[,] int_array = new int[,] { { 3, 1 }, { 1, 1 }, { 2, 2 }, { 5, 2 } };
            Rankbasedsorting rsk = new Rankbasedsorting();
            rsk.RankbasedSorting(int_array);
        }

        /// <summary>
        /// Prints the longest palindrome of the given string
        /// </summary>
        /// <param name="str_input">A String Value</param>
        /// <returns>Returns the longest posible palindrome of the string</returns>        
        /// <example>madameaga</example>
        /// <result>maadaam/maagaam/maaeaam</result>
        public void LongestPalindrome() {
            string str_input = "madameaga";
            longestpalindrome lp = new longestpalindrome();
            lp.LongestPalindrome(str_input);
        }

        /// <summary>
        /// Check the given sequence is present in an input array or not
        /// </summary>
        /// <param name="int_array">An Int Array</param>
        /// <param name="int_sequence">An Int Array</param>
        /// <returns>Returns Boolean Value</returns>        
        /// <example>{ 5, 1, 22, 25, 6, -1, 8, 10 } & { 22, 25, 6 }</example>
        /// <result>true</result>
        public void CheckSequenceInAnArray() {
            List<int> array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            List<int> sequence = new List<int> { 22, 25, 6 };
            ArraySubSequence ar = new ArraySubSequence();
            Console.WriteLine(ar.IsValidSubsequence(array, sequence));
        }

        /// <summary>
        /// Print the Prime factors of a given input
        /// </summary>
        /// <param name="long_input">An Long Value</param>
        /// <param name="int_input">An Int Value</param>
        /// <returns>Returns Prime Factors</returns>        
        /// <example>600851475143</example>
        /// <result>2,3,5,7,11,13....</result>
        public void PrimeFactors() {
            PrimeFactors pf = new PrimeFactors();
            long long_input = 600851475143;
            int int_input = 5;
            pf.getprimefactors(long_input, 2);
            Console.WriteLine(pf.Factorial(int_input));
        }

        /// <summary>
        /// Implementation of Insertion and Deletion in Doubly Linked List
        /// </summary>
        public void DoublyLinkedList() {
            // Start with the empty list
            DoublyLinkedList dll = new DoublyLinkedList();

            // Insert 2. So linked list becomes 2->NULL
            dll.push(2);

            // Insert 4. So linked list becomes 4->2->NULL
            dll.push(4);

            // Insert 8. So linked list becomes 8->4->2->NULL
            dll.push(8);

            // Insert 10. So linked list becomes 10->8->4->2->NULL
            dll.push(10);

            Console.Write("Created DLL is: ");
            dll.printlist(dll.head);

            // Deleting first node
            //dll.deleteNode(dll.head);

            // List after deleting first node
            // 8->4->2
            //Console.Write("\nList after deleting first node: ");
            //dll.printlist(dll.head);

            // Deleting middle node from 8->4->2
            //dll.deleteNode(dll.head.prev);

            Console.Write("\nList after Deleting second last node: ");
            dll.printlist(dll.head);

            dll.Reverse();
        }

        /// <summary>
        /// Prints the factorial of the given input
        /// </summary>
        /// <param name="int_input">An Int Value</param>
        /// <returns>Returns the factorial of the given value</returns>        
        /// <example>5</example>
        /// <result>120</result>
        public void FindFactorial() {
            Factorialusingrecursion fac = new Factorialusingrecursion();
            int int_input = 5;
            Console.WriteLine(fac.Factorial(int_input));
        }

        /// <summary>
        /// Implementation of Insertion in Binary search tree.
        /// </summary>
        public void BinarySearchTree() {
            BinaryTree bn = new BinaryTree();
            bn.Insert(23);
            bn.Insert(45);
            bn.Insert(16);
            bn.Insert(37);
            bn.Insert(3);
            bn.Insert(99);
            bn.Insert(22);
            bn.Search(3);
            bn.PrintTree();
        }

        /// <summary>
        /// Check the given input is present in an input array or not using binary search algorithm.
        /// </summary>
        /// <param name="int_array">An Int Array</param>
        /// <param name="target">An Int Value</param>
        /// <returns>Returns Boolean Value</returns>        
        /// <example>{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } & 100</example>
        /// <result>false</result>
        public void BinarySearching() {
            BinarySearch bs = new BinarySearch();
            int[] int_array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int target = 100;
            bs.BinarySearchFunc(int_array, target);
        }

        /// <summary>
        /// Implementation of Various Traversals in Binary Tree.
        /// </summary>
        public void BinaryTreeTraversals() {
            Traversals tree = new Traversals();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
            tree.root.right.left = new Node(6);
            tree.root.right.right = new Node(7);
            tree.InOrder();
            tree.PreOrder();
            tree.PostOrder();
        }
    }
}
