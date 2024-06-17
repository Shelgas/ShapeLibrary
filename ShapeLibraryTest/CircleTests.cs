using ShapeLibrary.Intefaces;
using ShapeLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ShapeLibraryTest
{
    public class CircleTests
    {
        [Fact]
        public void Test1()
        {
            IShape circle = new Circle(1);
            Assert.Equal(Math.PI, circle.GetArea());
        }

        [Fact]
        public void Test2()
        {
            IShape circle = new Circle(25);
            Assert.Equal(Math.PI * Math.Pow(25, 2), circle.GetArea());
        }

        [Fact]
        public void Test3()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }

    }
}
