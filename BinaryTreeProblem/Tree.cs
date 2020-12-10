using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeProblem
{
    public class Tree<K> where K : IComparable
    {
        public Node<K> root;

        /// <summary>
        /// To add data
        /// </summary>
        /// <param name="key"></param>
        public void Add(K key)
        {
            this.root = this.AddingRecursively(root, key);
        }

        /// <summary>
        /// To add data recursively
        /// </summary>
        /// <param name="current"></param>
        /// <param name="key"></param>
        /// <returns></returns>
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

        /// <summary>
        /// to get size
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return GetSizeRecursively(root);
        }

        /// <summary>
        /// to get size recursively
        /// </summary>
        /// <param name="current"></param>
        /// <returns></returns>
        public int GetSizeRecursively(Node<K> current) {
            return current == null ? 0 : 1 + this.GetSizeRecursively(current.left) +
                                     this.GetSizeRecursively(current.right);
        }

        /// <summary>
        /// to search data recursively
        /// </summary>
        /// <param name="current"></param>
        /// <param name="key"></param>
        /// <returns></returns>
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

        /// <summary>
        /// To search data
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool SearchData(K key)
        {
            bool isPresent = SearchRecursively(root, key);
            return isPresent;
        }
    }
}
