using Collections;
using NUnit.Framework.Constraints;
using System.Globalization;

namespace Collection.UnitTests
{
    public class Collection_UnitTests
    {

        [Test]
        public void Test_Collection_EmptyConstructor()
        {
            //Arange
            var coll = new Collection<int>();

            //Assert
            Assert.AreEqual(coll.ToString(), "[]");
        }
        [Test]
        public void Test_Collection_ConstructorSigleItem()
        {
            //Arange
            var coll = new Collection<int>(5);

            //Assert
            Assert.AreEqual(coll.ToString(), "[5]");
        }
        [Test]
        public void Test_Collection_ConstructorMultipleItems()
        {
            //Arange
            var coll = new Collection<int>(5, 2);

            //Assert
            Assert.AreEqual(coll.ToString(), "[5, 2]");
        }
        [Test]
        public void Test_Collection_Add()
        {
            //Arange
            var coll = new Collection<int>();

            //Act
            coll.Add(5);
            coll.Add(6);

            //Assert
            Assert.AreEqual(coll.ToString(), "[5, 6]");
        }
        [Test]
        public void Test_Collection_CountAndCapacity()
        {
            //Arange
            var coll = new Collection<int>(2, 9);

            //Assert
            Assert.AreEqual(coll.Count, 2);
            Assert.That(coll.Capacity, Is.GreaterThan(coll.Count));
        }
        [Test]
        public void Test_Collection_GetByIndex()
        {
            //Arange
            var names = new Collection<string>("Vladi", "Poly");

            //Assert
            Assert.AreEqual(names[0], "Vladi");
            Assert.AreEqual(names[1], "Poly");
        }
        [Test]
        public void Test_Collection_SetByIndex()
        {
            //Arange
            var names = new Collection<string>("Vladi", "Poly");

            //Act
            names[0] = "Gosho";

            //Assert
            Assert.AreEqual(names[0], "Gosho");
            Assert.AreEqual(names[1], "Poly");
        }
        [Test]
        public void Test_Collection_Clear()
        {
            //Arange
            var coll = new Collection<int>(5, 6);
            //Act
            coll.Clear();
            //Assert
            Assert.AreEqual(coll.ToString(), "[]");
        }
        [Test]
        public void Test_Collection_AddRange()
        {
            //Arange
            var coll = new Collection<string>("Vladi", "Desi", "Poly");

            //Act
            coll.AddRange("Peter");

            //Assert
            Assert.AreEqual(coll.ToString(), "[Vladi, Desi, Poly, Peter]");
        }
        [Test]
        public void Test_Collection_InsertAt()
        {
            //Arange
            var coll = new Collection<string>("Vladi");

            //Act
            coll.InsertAt(1, "1");

            //Assert
            Assert.AreEqual(coll.ToString(), "[Vladi, 1]");

        }
        [Test]
        public void Test_Collection_RemoveAt()
        {
            //Arange
            var coll = new Collection<string>("Vladi", "Boz");

            //Act
            coll.RemoveAt(0);

            //Assert
            Assert.AreEqual(coll.ToString(), "[Boz]");

        }
        [Test]
        public void Test_Collection_CheckRange()
        {
            //Arange
            var coll = new Collection<string>("Vladi", "Boz");

            //Act
            coll.RemoveAt(0);

            //Assert
            Assert.AreEqual(coll.ToString(), "[Boz]");

        }

    }
}