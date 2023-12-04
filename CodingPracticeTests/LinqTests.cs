using CodingPractice;

namespace CodingPracticeTests
{
    [TestClass]
    public class LinqTests
    {
        [TestMethod]
        public void TestLinq()
        {
            //Arrange
            LinqPractice lp = new LinqPractice();
            Person firstPerson = new Person { FirstName = "Cassian", LastName = "Andor", Age = 32 };

            //Act
            var linqSortedList = lp.LinqSort();
            //var temp = lp.ComparatorSort();
            Person sortedPerson = linqSortedList.First();

            //Assert
            Assert.AreEqual(firstPerson.LastName, linqSortedList.First().LastName);

        }
    }
}