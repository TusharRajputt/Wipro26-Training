using NUnit.Framework;
using Moq;
using MockedMainProject;
using System.Collections.Generic;

namespace MockExampleProject.Tests
{
    public class EmployTest
    {
        List<Employ> employList = new List<Employ>()
         {
                new Employ{Empno=1,Name="Akhil",Basic=88323},
                new Employ{Empno=2,Name="Yash",Basic=91911},
                new Employ{Empno=3,Name="Manali",Basic=86444},
        };
        Employ e1 = new Employ { Empno = 1, Name = "Prathyusha", Basic = 84234 };
        Employ e2 = new Employ { Empno = 2, Name = "Rohith", Basic = 82234 };

        Employ e3 = null;

        Mock<IEmployDao> mockDao = new Mock<IEmployDao>();
        [SetUp]
        public void Setup()
        {
            mockDao.Setup(x => x.SearchEmploy(1)).Returns(e1);
            mockDao.Setup(x => x.SearchEmploy(100)).Returns(e2);
            mockDao.Setup(x => x.SearchEmploy(1000)).Returns(e3);
            mockDao.Setup(x => x.ShowEmploy()).Returns(employList);
        }

        [Test]
        public void TestSearchEmploy()
        {
            Assert.NotNull(mockDao.Object.SearchEmploy(1));
            Assert.NotNull(mockDao.Object.SearchEmploy(100));
            Assert.Null(mockDao.Object.SearchEmploy(1000));
        }

        [Test]
        public void TestShowEmploy()
        {
            Assert.AreEqual(3, mockDao.Object.ShowEmploy().Count);
        }
    }
}
