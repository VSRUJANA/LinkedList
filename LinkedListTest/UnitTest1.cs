using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DataStructure_LinkedList;

namespace LinkedListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenNodePresentInTheList_WhenSearched_ShouldReturnNodeWithThatValue()
        {
            int data = 30;
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            Node node = list.Search(data);
            int expected = data;
            Assert.AreEqual(expected, node.data);
        }
        
        [TestMethod]
        public void GivenNodeWhichIsNotInTheList_WhenSearched_ShouldReturnNull()
        {
            int data = 100;
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            Node node = list.Search(data);
            Assert.AreEqual(null, node);
        }

        [TestMethod]
        public void GivenNodePresentInTheList_WhenSearcheed_ShouldReturnNodeWithThatValue()
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            int existingnode = 30;
            int newnode = 40;
            Node node = list.InsertAfterValue(existingnode,newnode);
            int expected = newnode;
            Assert.AreEqual(expected, node.data);
        }

        [TestMethod]
        public void GivenNodePresentInTheList_WhenSearrched_ShouldReturnNodeWithThatValue()
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70); 
            int existingnode = 100;
            int newnode = 40;
            Node node = list.InsertAfterValue(existingnode, newnode);
            Assert.AreEqual(null, node);
        }
    }
}
