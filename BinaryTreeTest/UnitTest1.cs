using BinaryTreeProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTreeTest
{
    [TestClass]
    public class UnitTest1
    {
        Tree<int> tree;

        public UnitTest1()
        {
            tree = new Tree<int>();
        }


        [TestMethod]
        public void givenElements_WhenSearchedElement_ShouldReturnTrue()
        {
            tree.Add(56);
            tree.Add(30);
            tree.Add(70);
            tree.Add(22);
            tree.Add(40);
            tree.Add(60);
            tree.Add(95);
            tree.Add(11);
            tree.Add(3);
            tree.Add(16);
            tree.Add(65);
            tree.Add(63);
            tree.Add(67);
            bool searchResult = tree.SearchData(16);
            Assert.IsTrue(searchResult);

        }

        /// <summary>
        /// Seaches the not present element inthe tree shoul return false.
        /// </summary>
        [TestMethod]
        public void givenElements_WhenSearchedElement_ShouldReturnFalse()
        {
            tree.Add(56);
            tree.Add(30);
            tree.Add(70);
            tree.Add(22);
            tree.Add(40);
            tree.Add(60);
            tree.Add(95);
            tree.Add(11);
            tree.Add(3);
            tree.Add(16);
            tree.Add(65);
            tree.Add(63);
            tree.Add(67);
            bool searchResult = tree.SearchData(190);
            Assert.IsFalse(searchResult);

        }
    }
}
