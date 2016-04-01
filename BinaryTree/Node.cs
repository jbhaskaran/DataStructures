using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinaryTree
{
    public class Node
    {
        public int Value { get; set; }
        //pointers for binary tree
        public Node Left { get; set; }
        public Node Right { get; set; }
        //pointers for linked list
        public Node Next { get; set; }
    }
}
