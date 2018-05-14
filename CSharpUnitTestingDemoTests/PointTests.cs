using Xunit;
using CSharpUnitTestingDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUnitTestingDemo.Tests
{
    public class PointTests
    {
        [Fact()]
        public void PointTest()
        {
            int x = 5;
            int y = 6;

            var point = new Point(x, y);

            Assert.Equal(x, point.X);
            Assert.Equal(y, point.Y);
        }

        [Fact()]
        public void DistanceToTest()
        {
            Point p1 = new Point(2, 3);
            Point p2 = new Point(2, 4);
            Assert.Equal(1, p1.DistanceTo(p2));
        }

        [Fact()]
        public void PointEqualsTest() {
            Point p1 = new Point(2, 4);
            Point p2 = new Point(2, 4);
            Assert.True(p1.Equals(p2));
        }

        [Fact()]
        public void PointNotEqualsTest()
        {
            Point p1 = new Point(2, 4);
            Point p2 = new Point(3, 5);
            Assert.False(p1.Equals(p2));
        }
    }
}