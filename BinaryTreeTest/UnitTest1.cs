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
        public void givenThreeElements_WhenAddedInBinaryTree_ShouldReturnSize()
        {
            tree.Add(56);
            tree.Add(30);
            tree.Add(70);
            int size = tree.Size();
            Assert.AreEqual(3, size);
        }
    }
}
