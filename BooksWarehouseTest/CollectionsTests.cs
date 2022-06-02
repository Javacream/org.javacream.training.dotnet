using NUnit.Framework;
using System.Collections.Generic;
using System;
namespace Javacream.BooksWarehouse.Test
{
    public class CollectionTests
    {
        [Test]
        public void TestList()
        {
            List<string> names = new List<string>();
            names.Add("Hugo");
            names.Add("Emil");
            names.Add("Fritz");
            names.Add("Hugo");
            Assert.AreEqual(4, names.Count);
            Action<string> loopStep = (string element) => Console.WriteLine(element);
            names.ForEach(loopStep);
        }
    }
}