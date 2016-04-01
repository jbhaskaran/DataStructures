using System;
using DataStructures.BinaryTree;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinaryTree();
            LinkedList();
        }

        static void BinaryTree()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.InorderTraversal(bst.Root);
            bst.Insert(100);
            bst.Insert(75);
            bst.Insert(50);
            bst.Insert(99);
            bst.Insert(80);
            bst.Insert(78);
            bst.Insert(55);
            //bst.Insert(60);
            bst.Insert(51);
            bst.Insert(59);
            bst.Insert(91);
            bst.Insert(44);
            bst.Insert(23);
            bst.Insert(39);
            bst.Insert(10);
            bst.InorderTraversal(bst.Root);
            Console.WriteLine("---------");
            //bst.Delete(75);
            //bst.InorderTraversal(bst.Root);
            Console.WriteLine("---------");
            bst.PreorderTraversal(bst.Root);
            Console.WriteLine("---------");
            bst.PostorderTraversal(bst.Root);
            Console.WriteLine("---------");
            Console.ReadLine();
        }

        static void LinkedList()
        {
            LinkedList linkedList = new DataStructures.BinaryTree.LinkedList();
            linkedList.Insert(100);
            linkedList.Insert(200);
            linkedList.Insert(300);
            linkedList.Insert(400);
            linkedList.Insert(500);
            //linkedList.Print(linkedList.Head);
            //Node revNode = linkedList.ReverseLinkedList(linkedList.Head, false);
            //Node node = linkedList.ReverseLinkedList(linkedList.Head);
            //linkedList.Print(node);
            LinkedList linkedList2 = new DataStructures.BinaryTree.LinkedList();
            linkedList2.Insert(600);
            linkedList2.Insert(700);
            linkedList2.Insert(800);
            linkedList2.Insert(900);
            linkedList2.Insert(1000);
            linkedList2.Insert(1100);
            linkedList2.Insert(1200);
            //Node result = linkedList2.Union(linkedList.Head, linkedList2.Head);
            linkedList2.Print(linkedList2.Head);
            Console.WriteLine("----------------");
            //linkedList2.RemoveDuplicates(linkedList2.Head);
            //Node mergedNode = linkedList2.MergeSort(linkedList2.Head);
            //linkedList2.Print(mergedNode);
            //Node kthNode = linkedList2.FindNodeFromEnd(linkedList2.Head, 3);
            //linkedList2.FoldLinkedList(linkedList2.Head);
            Console.ReadLine();
        }


    }
}
