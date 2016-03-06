using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinaryTree
{
    public class LinkedList
    {
        private Node head;
        private int count;


        public LinkedList()
        {
            head = null;
            count = 0;
        }

        public Node Head
        {
            get
            {
                return head;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Insert(int data)
        {
            Node node = new Node { Value = data };
            count++;
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node current = head;
                Node previous = null;
                while (true)
                {
                    previous = current;
                    current = current.Next;
                    if(current == null)
                    {
                        previous.Next = node;
                        break;
                    }
                }
            }
        }

        public void Print(Node node)
        {
            //Node current = head;
            while(node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }

        public Node ReverseLinkedList(Node node, bool isRecursive = false)
        {
            Node current = node;
            Node prev = null;
            Node next = null;
            while(current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }

        public Node ReverseLinkedList(Node current)
        {
            if (current.Next == null) return current;
            Node node = ReverseLinkedList(current.Next);
            current.Next.Next = current;
            current.Next = null;
            return node;
        }

        public Node Union(Node first, Node second)
        {
            Node current = first;
            Node previous = null;
            while(current != null)
            {
                previous = current;
                current = current.Next;
            }
            current = second;
            while(current != null)
            {
                previous.Next = current;
                previous = current;
                current = current.Next;
            }
            return previous;
        }

        public Node Intersection(Node first, Node second)
        {
            return null;
        }

        public void RemoveDuplicates(Node node)
        {
            Node current = node;
            Node itr = null;
            while (current != null)
            {
                itr = current;
                while(itr.Next != null)
                {
                    if (current.Value == itr.Next.Value)
                    {
                        itr.Next = itr.Next.Next;
                    }
                    else
                    {
                        itr = itr.Next;
                    }
                }
                current = current.Next;
            }
        }

        public Node FindNodeFromEnd(Node node, int k)
        {
            Node current = node;
            int count = 0;
            while(count < k)
            {
                count++;
                current = current.Next;
            }
            Node n = node;
            while (current != null)
            {
                current = current.Next;
                n = n.Next;
            }
            return n;
        }

        public void FoldLinkedList(Node node)
        {
            Node slowNode = node;
            Node fastNode = node;
            while(fastNode != null)
            {
                fastNode = fastNode.Next;
                slowNode = slowNode.Next;
                if(fastNode != null)
                {
                    fastNode = fastNode.Next;
                }
            }
            Node middleNode = slowNode;
            //reverse right half
            var reversedNode = ReverseLinkedList(middleNode);
            Node current = node;
            Node next = null;
            Node reverseNext = null;
            while(current.Value != middleNode.Value && reversedNode != null)
            {
                next = current.Next;
                reverseNext = reversedNode.Next;
                reversedNode.Next = next;
                current.Next = reversedNode;
                current = next;
                reversedNode = reverseNext;
                //current = current.Next;
            }
            if(reversedNode != null)
            {
                reversedNode.Next = null;
            }
            else
            {
                current.Next = null;
            }

        }

        #region MergeSort
        public Node MergeSort(Node node)
        {
            if (node == null || node.Next == null)
                return node;

            int middle = count / 2;
            Node left = head;
            Node right = null;
            int i = 0;
            while(node != null)
            {
                i++;
                Node next = node.Next;
                if (i == middle)
                {
                    node.Next = null;
                    right = next;
                }
                node = next;
            }
            //recursively sort them
            Node h1 = MergeSort(left);
            Node h2 = MergeSort(right);

            // merge together
            Node merged = Merge(h1, h2);
            return merged;
        }

        public Node Merge(Node l, Node r)
        {
            Node p1 = l;
            Node p2 = r;

            Node fakeHead = new Node { Value = 100 };
            Node pNew = fakeHead;

            while (p1 != null || p2 != null)
            {

                if (p1 == null)
                {
                    pNew.Next = new Node{Value = p2.Value };
                    p2 = p2.Next;
                    pNew = pNew.Next;
                }
                else if (p2 == null)
                {
                    pNew.Next = new Node{Value = p1.Value };
                    p1 = p1.Next;
                    pNew = pNew.Next;
                }
                else
                {
                    if (p1.Value < p2.Value)
                    {
                        // if(fakeHead)
                        pNew.Next = new Node{Value = p1.Value };
                        p1 = p1.Next;
                        pNew = pNew.Next;
                    }
                    else if (p1.Value == p2.Value)
                    {
                        pNew.Next = new Node{Value = p1.Value };
                        pNew.Next.Next = new Node{Value = p1.Value };
                        pNew = pNew.Next.Next;
                        p1 = p1.Next;
                        p2 = p2.Next;

                    }
                    else
                    {
                        pNew.Next = new Node { Value = p2.Value };
                        p2 = p2.Next;
                        pNew = pNew.Next;
                    }
                }
            }

            // printList(fakeHead.Next);
            return fakeHead.Next;
        }
        #endregion
    }
}
