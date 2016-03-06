using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinaryTree
{
    public class BinarySearchTree
    {
        private Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public Node Root
        {
            get
            {
                return root;
            }
        }

        public void Insert(int data)
        {
            Node node = new Node() { Value = data };
            if(root == null)
            {
                root = node;
            }
            else
            {
                Node current = root;
                Node parent = null;
                while(current != null)
                {
                    if(data < current.Value)
                    {
                        parent = current;
                        current = current.Left;
                    }
                    else
                    {
                        parent = current;
                        current = current.Right;
                    }
                }
                if (data < parent.Value)
                {
                    parent.Left = node;
                }
                else
                {
                    parent.Right = node;
                }
            }

        }

        public void Insert()
        {
            int data = 10;
            Node node = new Node { Value = data };
            if (root == null)
            {
                root = node;
            }
            else
            {
                Node current = root;
                Node parent = null;
                while (true)
                {
                    parent = current;
                    if(data < current.Value)
                    {
                        current = current.Left;
                        if(current == null)
                        {
                            parent.Left = node;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = node;
                            break;
                        }
                    }
                }
            }
        }

        public void Delete(int data)
        {
            Node current = root;
            Node parent = null;
            int count = 0;
            while(current != null)
            {
                count++;
                if (data < current.Value)
                {
                    parent = current;
                    current = current.Left;
                }
                else if (data > current.Value)
                {
                    parent = current;
                    current = current.Right;
                }
                else if (data == current.Value)
                {
                    break;
                }
            }
            //case 1: Node to be deleted has no right child
            if (current.Right == null)
            {
                if (data < parent.Value)
                {
                    parent.Left = current.Left;
                }
                else
                {
                    parent.Right = current.Left;
                }
            }
            //case 2: Node to deleted has a right child with no left child
            else if (current.Right.Left == null)
            {
                if (data < parent.Value)
                {
                    parent.Left = current.Right;
                    parent.Left.Left = current.Left;
                }
                else
                {
                    parent.Right = current.Right;
                    parent.Right.Left = current.Left;
                }
            }
            //case 3: Node to be deleted has a right child with left child
            else
            {
                // we need to find the right node's left-most child
                Node leftmost = current.Right.Left;
                Node lmParent = current.Right;
                while (leftmost.Left != null)
                {
                    lmParent = leftmost;
                    leftmost = leftmost.Left;
                }
                // the parent's left subtree becomes the leftmost's right subtree
                lmParent.Left = leftmost.Right;

                // assign leftmost's left and right to current's left and right
                leftmost.Left = current.Left;
                leftmost.Right = current.Right;

                if (parent == null)
                    root = leftmost;
                else
                {
                    if (data < parent.Value)
                        // parent.Value > current
                        // therefore, the parent's left subtree is now current's right subtree
                        parent.Left = leftmost;
                    else if (data > parent.Value)
                        // parent.Value < current.Value
                        // therefore, the parent's right subtree is now current's right subtree
                        parent.Right = leftmost;
                }
            }
        }

        public void InorderTraversal(Node node)
        {
            if(node != null)
            {
                Node current = node;
                //visit left child
                InorderTraversal(current.Left);
                Console.WriteLine(current.Value);
                //visit right child
                InorderTraversal(current.Right);
            }
        }

        public void PreorderTraversal(Node node)
        {
            if (node != null)
            {
                Node current = node;
                Console.WriteLine(current.Value);
                //visit left child
                PreorderTraversal(current.Left);
                //visit right child
                PreorderTraversal(current.Right);
            }
        }

        public void PostorderTraversal(Node node)
        {
            if (node != null)
            {
                Node current = node;
                //visit left child
                PostorderTraversal(current.Left);
                //visit right child
                PostorderTraversal(current.Right);
                Console.WriteLine(current.Value);
            }
        }

    }
}
