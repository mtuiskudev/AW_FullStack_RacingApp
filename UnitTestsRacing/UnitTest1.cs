using NUnit.Framework;
using AW_FullStack_Checkpoint_RacingApp;

namespace UnitTestsRacing
{
    public class Tests
    {


        [Test]
        public void Test1()
        {
            Car car = new Car("test", "test", new Driver("testdriver"));


            Assert.AreEqual("testdriver", car.Racer.Name);
        }

        [Test]
        public void Test2()
        {
            Car car = new Car("test2", "test2", new Driver("testdriver2"));


            Assert.AreEqual("testdriver2", car.PrintRacer());
        }


        [Test]
        public void Test3()
        {
            Car car = new Car("test3", "test3", new Driver("testdriver3"));
            car.CarStatus = "OK";

            Assert.IsTrue(car.IsOk());
        }

        [Test]
        public void Test4()
        {
            Driver testDriver = new Driver("testDriver");

            Assert.AreEqual("Radio Ok", testDriver.RadioTest());
        }

    }
}