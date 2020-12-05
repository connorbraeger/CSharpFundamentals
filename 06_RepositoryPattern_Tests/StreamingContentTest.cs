using System;
using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTest
    {
        [TestMethod]
        public void Settle_ShouldSetCorrectString()
        {
            StreamingContent content = new StreamingContent();

            content.Title = "Toy Story";

            string expected = "Toy Story";

            string actual = content.Title;

            Assert.AreEqual(expected, actual);
        }
    }
}
