using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;

namespace HashTable
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void ThreeElements()
        {
            var List = new HashTableList(3);

            List.PutPair("BMW", "E39");
            List.PutPair("Audi", "A6");
            List.PutPair("JDM", "Tourer V");

            Assert.AreEqual("E39", List.GetValueByKey("BMW"));
            Assert.AreEqual("A6", List.GetValueByKey("Audi"));
            Assert.AreEqual("Tourer V", List.GetValueByKey("JDM"));
        }

        [Test]
        public void AddingTheSameElement()
        {
            var List = new HashTableList(2);

            List.PutPair("BMW", "E39");
            List.PutPair("BMW", "M5");

            Assert.AreEqual("M5", List.GetValueByKey("BMW"));
        }
        [Test]
        public void SearchingOneElement()
        {
            var rnd = new Random();
            var List = new HashTableList(10000);
            var toFindKey = RandomString(10);
            var toFindValue = RandomString(10);
            var put = rnd.Next(0, 1000);
            for (int i = 0; i < 10000; i++)
            {
                if (i == put)
                    List.PutPair(toFindKey, toFindValue);
                else
                    List.PutPair(RandomString(5), RandomString(5));
            }
            Assert.AreEqual(toFindValue, List.GetValueByKey(toFindKey));
            for (int i = 1; i < 10000; i++)
            {
                List.PutPair(RandomString(10), RandomString(10));
            }
            Assert.AreEqual(toFindValue, List.GetValueByKey(toFindKey));
        }
        [Test]
        public void Searching()
        {
            var List = new HashTable.HashTableList(10000);
            for (int i = 0; i < 10000; i++)
                List.PutPair(RandomString(10), RandomString(10));

            for (int i = 0; i < 1000; i++)
                Assert.AreEqual(null, List.GetValueByKey(i));
        }
        private string RandomString(int size)
        {
            var rnd = new Random();
            string randomString = "";
            char letter;
            int randomNumber;
            for (int i = 0; i < size; i++)
            {
                randomNumber = rnd.Next(0, 11);
                if (randomNumber % 2 == 0)
                    letter = Convert.ToChar(rnd.Next(97, 123));
                else
                    letter = Convert.ToChar(rnd.Next(65, 91));
                randomString += letter;
            }
            return randomString;
        }
    }
}
