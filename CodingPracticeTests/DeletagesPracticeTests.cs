using CodingPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPracticeTests
{
    [TestClass]
    public class DeletagesPracticeTests
    {
        delegate double FindArea(double x);        

        //TODO: Put all the dp instantiation into a constructor

        [TestMethod]
        public void TestDelegateSquare()
        {
            //Arrange            
            DelegatesPractice dp = new DelegatesPractice();
            FindArea fa = dp.FindSquareArea;

            //Act
            double area = fa(2);

            //Assert
            Assert.AreEqual(4, area);
        }

        [TestMethod]
        public void TestDelegateCircle()
        {
            //Arrange
            DelegatesPractice dp = new DelegatesPractice();
            FindArea fa = dp.FindCircleArea;

            //Act
            double area = fa(2);

            //Assert
            Assert.AreEqual(12.56, area);
        }

        [TestMethod]
        public void TestLambdaDelegate()
        {
            //Arrange
            FindArea fa = (x => x * 10);

            //Act
            double result = fa(2);

            //Assert
            Assert.AreEqual(result, 20);
        }

        [TestMethod]
        public void TestFunc()
        {
            //Arrange
            //First int is the method paramater, second int is the return type.
            Func<int, int> multiplyByTwenty = x => x * 20;

            //Act
            int result = multiplyByTwenty(2);

            //Assert
            Assert.AreEqual(result, 40);
        }

        [TestMethod]
        public void TestMulticastDelegate()
        {
            //Arrange
            DelegatesPractice dp = new DelegatesPractice();

            //I don't think you'd normally do this when you've got a return type.
            //TODO: Create some methods that have a void return type for this "test."
            FindArea fa = dp.FindSquareArea;
            fa += dp.FindCircleArea;

            //Act
            double area = fa(2);

            //Assert
            Assert.AreEqual(12.56, area);
        }
    }
}
