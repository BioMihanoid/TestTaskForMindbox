using FiguresLibrary;

namespace UnitTestFiguresLibrary
{
    [TestClass]
    public sealed class TriangleTest
    {
        [TestMethod]
        public void CheckAreaTriangle()
        {
            //Arrange
            var firstSide = 68;
            var secondSide = 61;
            var thirdSide = 43;
            var expected = 1290;

            //Act
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            var result = triangle.GetArea();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckSquarenessTriangle()
        {
            //Arrange
            var firstSide = 3;
            var secondSide = 4;
            var thirdSide = 5;
            var expected = true;

            //Act
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            var result = triangle.IsSquarenessTriangle();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}