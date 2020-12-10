using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeProblem
{
    public class Tree<K> where K : IComparable
    {
        public Node<K> root;

        public void Add(K key)
        {
            this.root = this.AddingRecursively(root, key);
        }

        public Node<K> AddingRecursively(Node<K> current, K key)
        {
            if (current == null)
                return new Node<K>(key);
            int compareResult = key.CompareTo(current.key);
            if (compareResult == 0)
                return current;
            if (compareResult < 0)
                current.left = AddingRecursively(current.left, key);
            if (compareResult > 0)
                current.right = AddingRecursively(current.right, key);
            return current;

        }

        public int Size()
        {
            return GetSizeRecursively(root);
        }

        public int GetSizeRecursively(Node<K> current) {
            return current == null ? 0 : 1 + this.GetSizeRecursively(current.left) +
                                     this.GetSizeRecursively(current.right);

        }
        public bool SearchRecursively(Node<K> current, K key)
        {
            if (current == null)
                return false;
            int compareResult = key.CompareTo(current.key);
            if (compareResult == 0)
                return true;
            if (compareResult < 0)
                return SearchRecursively(current.left, key);
            else
                return SearchRecursively(current.right, key);

        }

        public bool SearchData(K key)
        {
            bool isPresent = SearchRecursively(root, key);
            return isPresent;
        }
        /* {
             if (current == null)
             {
                 return 0;
             }
             else if (current = this.GetSizeRecursively(current.left)) ;

                 return 1;

             else current = this.GetSizeRecursively(current.right); {
                 return 1;
             }*/


    }
}
