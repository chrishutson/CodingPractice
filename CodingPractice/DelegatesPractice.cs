using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    //Write a delegate using the "Func" keyword.  Also just figure out delegates in general
    public class DelegatesPractice
    {
        //Area of a square
        public double FindSquareArea(double sideLength)
        {
            return Math.Pow(sideLength, 2);
        }


        //Area of a circle
        public double FindCircleArea(double radiusLength)
        {
            double pi = 3.14;
            return pi * Math.Pow(radiusLength, 2);
        }
    }
}
