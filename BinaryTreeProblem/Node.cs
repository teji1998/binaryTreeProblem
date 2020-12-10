using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeProblem
{
    public class Node<K> where K : IComparable
    {
        public K key;
        public Node<K> left;
        public Node<K> right;

        public Node(K key)
        {
            this.key = key;
            this.left = null;
            this.right = null;
        }
    }
}
