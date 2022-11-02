using FiguresLibrary;

namespace UnitTestFiguresLibrary
{
    [TestClass]
    public sealed class CircleTest
    {
        [TestMethod]
        public void CheckAreaCircle()
        {
            //Arrange
            var radius = 2;
            var expected = 12.566370614359172953850573533118;

            //Act
            var circle = new Circle(radius);
            var result = circle.GetArea();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
