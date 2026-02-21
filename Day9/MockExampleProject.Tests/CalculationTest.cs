using NUnit.Framework;
using Moq;
using MockedMainProject;

namespace MockExampleProject.Tests
{
    public class CalculationTest
    {
        Mock<Calculation> mockCalculation = new Mock<Calculation> ();
        [SetUp]
        public void Setup()
        {
            mockCalculation.Setup(x => x.Sum(12, 5)).Returns(17);
            mockCalculation.Setup(x => x.Sub(12, 5)).Returns(7);
            mockCalculation.Setup(x => x.Mult(12,5)).Returns(60);
        }

        [Test]
        public void TestMult()
        {
            Assert.AreEqual(60, mockCalculation.Object.Mult(12, 5));
        }

        [Test]
        public void TestSum()
        {
            Assert.AreEqual(17, mockCalculation.Object.Sum(12, 5));
        }

        [Test]
        public void TestSub()
        {
            Assert.AreEqual(7, mockCalculation.Object.Sub(12,5));
        }
    }
}
