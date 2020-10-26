using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace SearchString
{
    [TestClass]
    public class SearchTests
    {
        [TestMethod]
        public void SubTextFoundInMainString()
        {
            // Arrange 
            var search = new Search();
            var expected = new List<int> { 1, 4 };

            //Act 
            var results = search.FindOccurencesOfString("ABCDBC", "BC");
            
            // Assert 
            Assert.IsTrue(results.Count == 2);
            AssertListsAreSame(expected, results);
        }

        [TestMethod]
        public void SubTextNotFoundInMainString()
        {
            //Arrange
            var search = new Search();
            
            //Act 
            var results = search.FindOccurencesOfString("ABCDBC", "XX");
            
            //Assert
            Assert.IsTrue(results.Count == 0);
        }

        [TestMethod]
        public void SubTextIsNullOrEmpty()
        {
            var search = new Search();
            var results = search.FindOccurencesOfString("ABCDBC", String.Empty);
            Assert.IsTrue(results.Count == 0);
        }

        [TestMethod]
        public void MainTextIsNullOrEmpty()
        {
            var search = new Search();
            var results = search.FindOccurencesOfString(String.Empty, String.Empty);
            Assert.IsTrue(results.Count == 0);
        }
        private void AssertListsAreSame(List<int> expected, List<int> actual)
        {
            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(actual[i], expected[i]);
            }
        }

    }
}
