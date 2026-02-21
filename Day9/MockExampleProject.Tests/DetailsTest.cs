using NUnit.Framework;
using Moq;
using MockedMainProject;
using System;

namespace Tests
{
    [TestFixture]
    public class DetailsTest
    {
        Mock<IDetails> mock = new Mock<IDetails>();
        [SetUp]
        public void TestSetup()
        {
            string res = string.Empty;
            int hr = DateTime.Now.Hour;
            if (hr < 12)
            {
                res = "Good Morning to All...Mocked Data";
            }
            else if (hr >= 12 && hr < 16)
            {
                res = "Good Afternoon to All...Mocked Data";
            }
            mock.Setup(x => x.Greeting()).Returns(res);
            //Mock<IDetails> mock = new Mock<IDetails>();
            mock.Setup(x => x.ShowCompany()).
                Returns("Hi Company is Wipro Bangalore Offline Batch...");
            mock.Setup(x => x.ShowStudent()).
                Returns("Hi I am Tushar from Wipro Online");
        }

        [Test]
        public void TestGreeting()
        {
           int hr = DateTime.Now.Hour;
            if (hr < 12)
            {
                Console.WriteLine(mock.Object.Greeting());
                Assert.AreEqual("Good Morning to All...Mocked Data",
                            mock.Object.Greeting());
            }
            if (hr >= 12 && hr < 16)
            {
                Assert.AreEqual("Good Afternoon to All...Mocked Data",
                           mock.Object.Greeting());
            }
          
        }

        [Test]
        public void TestShowStudent()
        {
            Assert.AreEqual("Hi I am Tushar from Wipro Online",
                mock.Object.ShowStudent());
        }
        [Test]
        public void TestShowCompany()
        {

            Assert.AreEqual("Hi Company is Wipro Bangalore Offline Batch...",
                mock.Object.ShowCompany());
        }
    }
}