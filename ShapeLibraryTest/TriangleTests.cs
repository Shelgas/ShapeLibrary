using ShapeLibrary.Intefaces;
using ShapeLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibraryTest
{
    public class TriangleTests
    {
        [Fact]
        public void Test1()
        {
            IShape triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.GetArea());
        }

        [Fact]
        public void Test2()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
        }

        [Fact]
        public void Test3()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightTriangle());
        }


        [Fact]
        public void Test4()
        {
            var triangle = new Triangle(3, 4, 6);
            Assert.False(triangle.IsRightTriangle());
        }

        [Fact]
        public void Test5()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 0, 3));
        }

    }
}
