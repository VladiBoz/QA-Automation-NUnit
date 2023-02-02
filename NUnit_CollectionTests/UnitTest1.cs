using Collections;


namespace Collection.UnitTests
{
    public class Collection_UnitTests
    {

        [Test]
        public void Test_Collection_EmptyConstructor()
        {
            //Arrange
            string expectedCollection = "[]";

            //Act
            var collection = new Collection<int>();

            //Assert
            Assert.That(expectedCollection, Is.EqualTo(collection.ToString()));
        }


        [Test]
        public void Test_Collection_Add()
        {
            //Arrange
            var collection = new Collection<int>();

            //Act
            collection.Add(5);

            //Assert
            Assert.AreEqual(collection.ToString(), "[5]");
        }
        [Test]
        public void Test_Collection_CountAndCapacity()
        {
            //Arrange
            var collection = new Collection<int>(2, 9);

            //Assert
            Assert.AreEqual(collection.Count, 2);
            Assert.That(collection.Capacity, Is.GreaterThan(collection.Count));
        }
        [Test]
        public void Test_Collection_GetByIndex()
        {
            //Arrange
            var names = new Collection<string>("Vladi");

            //Assert
            Assert.AreEqual(names[0], "Vladi");

        }
        [Test]
        public void Test_Collection_SetByIndex()
        {
            //Arrange
            var names = new Collection<string>("Vladi");

            //Act
            names[0] = "Gosho";

            //Assert
            Assert.AreEqual(names[0], "Gosho");

        }
        [Test]
        public void Test_Collection_Clear()
        {
            //Arrange
            var collection = new Collection<int>(5, 6);
            //Act
            collection.Clear();
            //Assert
            Assert.AreEqual(collection.ToString(), "[]");
        }
        [Test]
        public void Test_Collection_AddRange()
        {
            //Arrange
            var collection = new Collection<string>("Vladi", "Desi", "Poly");

            //Act
            collection.AddRange("Peter");

            //Assert
            Assert.AreEqual(collection.ToString(), "[Vladi, Desi, Poly, Peter]");

        }
        [Test]
        public void Test_Collection_InsertAt()
        {
            //Arrange
            var collection = new Collection<string>("Vladi");

            //Act
            collection.InsertAt(1, "1");


            //Assert
            Assert.AreEqual(collection.ToString(), "[Vladi, 1]");

        }
        [Test]
        public void Test_Collection_RemoveAt()
        {
            //Arrange
            var collection = new Collection<string>("Vladi", "Boz");

            //Act
            collection.RemoveAt(0);

            //Assert
            Assert.AreEqual(collection.ToString(), "[Boz]");

        }

        [Test]
        public void Test_Collection_Exchange()
        {   //Arrange
            var collection = new Collection<string>("Bozveliev", "Vladislav");

            //Act
            collection.Exchange(0, 1);

            //Assert
            Assert.AreEqual(collection.ToString(), "[Vladislav, Bozveliev]");
        }

        [Test]
        public void Test_Collection_GrowCapacity()
        {    //Arrange
            var collection = new Collection<int>(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            //Act
            for (int i = 1; i <= 20; i++)
                collection.Add(i);
            //Assert
            Assert.AreEqual(collection.ToString(), "[1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20]");
        }
        [Test]
        public void Test_Collection_ByInvalidIndex()
        {
            //Arrange
            var collection = new Collection<string>("Vladi", "Peter");

            //Assert
            Assert.That(() => { var name = collection[-1]; },
        Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.That(() => { var name = collection[2]; },
      Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.That(() => { var name = collection[500]; },
     Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.AreEqual(collection.ToString(), "[Vladi, Peter]");
        }


        [Test]
        public void Test_Collection_InsertAtWithGrow()
        {
            var collection = new Collection<int>(1, 2, 3);
            int oldCapacity = collection.Capacity;
            var newCollection = Enumerable.Range(10, 50).ToArray();
            collection.AddRange(newCollection);
            collection.InsertAt(20, 50);
            string expectedCollection = "[" + string.Join(", ", newCollection) + "]";
            Assert.AreNotEqual(collection.ToString(), expectedCollection);
            Assert.That(collection.Capacity, Is.GreaterThanOrEqualTo(oldCapacity));
            Assert.That(collection.Capacity, Is.GreaterThanOrEqualTo(collection.Count));
        }
    }
}