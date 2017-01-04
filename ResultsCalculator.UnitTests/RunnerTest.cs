using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResultsCalculator.WinForms;

namespace ResultsCalculator.UnitTests
{
    [TestClass]
    public class RunnerTest
    {
        [TestMethod]
        public void Runner_GetTotalTime_ReturnTime()
        {
            //Arrange
            TimeSpan expectedTime = new TimeSpan(1, 10, 0);
            TimeSpan actualTime;
            Runner newRunner = new Runner() { StartTime = Convert.ToDateTime("1/1/2017 8:07:50AM"), EndTime = Convert.ToDateTime("1/1/2017 9:17:50AM") };

            //Act
            actualTime = newRunner.TotalTime;

            //Assert
            Assert.AreEqual(expectedTime, actualTime);
        }

        [TestMethod]
        public void Runner_GetTotalLaps_ReturnLaps()
        {
            //Arrange
            int expectedLapCount = 10;
            int actualLapCount;
            Runner newRunner = new Runner() { TotalLaps = expectedLapCount };

            //Act
            actualLapCount = newRunner.TotalLaps;

            //Assert
            Assert.AreEqual(expectedLapCount, actualLapCount);
        }

        [TestMethod]
        public void Runner_GetLapOneLap_ReturnValidLap()
        {
            //Arrange
            Runner newRunner = new Runner();
            Lap expectedLap = new Lap(4);
            Lap actualLap;

            //Act
            newRunner.AddLap(expectedLap);
            actualLap = newRunner.GetLap(4);

            //Assert
            Assert.AreEqual(expectedLap, actualLap);
        }

        [TestMethod]
        public void Runner_GetLapThreeLaps_ReturnValidLap()
        {
            //Arrange
            Runner newRunner = new Runner();
            Lap expectedLap = new Lap(4);
            Lap actualLap;


            //Act
            newRunner.AddLap(new Lap(8));
            newRunner.AddLap(expectedLap);
            newRunner.AddLap(new Lap(12));
            actualLap = newRunner.GetLap(4);

            //Assert
            Assert.AreEqual(expectedLap, actualLap);
        }

        [TestMethod]
        public void Runner_GetLap0Laps_ReturnsException()
        {
            //Arrange
            Runner newRunner = new Runner();
            Lap actualLap;

            //Assert
            try
            {
                actualLap = newRunner.GetLap(4);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Lap was not found");
                return;
            }
            Assert.Fail("No exception was thrown.");
        }

        [TestMethod]
        public void Runner_GetLapThreeLaps_ReturnsException()
        {
            //Arrange
            Runner newRunner = new Runner();
            Lap actualLap;

            //Act
            newRunner.AddLap(new Lap(1));
            newRunner.AddLap(new Lap(2));
            newRunner.AddLap(new Lap(3));
            
            //Assert
            try
            {
                actualLap = newRunner.GetLap(4);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Lap was not found");
                return;
            }
            Assert.Fail("No exception was thrown.");
        }

        [TestMethod]
        public void Runner_AddLap0_ReturnsException()
        {
            Runner newRunner = new Runner();
            try
            {
                newRunner.AddLap(new Lap(0));
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Laps must be numbered greater than 0");
                return;
            }
            Assert.Fail("No exception was thrown");
        }

        [TestMethod]
        public void Runner_AddLapNegative_ReturnsException()
        {
            Runner newRunner = new Runner();
            try
            {
                newRunner.AddLap(new Lap(-1));
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Laps must be numbered greater than 0");
                return;
            }
            Assert.Fail("No exception was thrown");
        }

        [TestMethod]
        public void Runner_GetLapSplitTime_ReturnsSplitTime()
        {
            //Arrange
            TimeSpan expectedTimeSpan = new TimeSpan(0, 1, 20, 15);
            TimeSpan actualTimeSpan;
            Runner newRunner = new Runner();
            newRunner.AddLap(new Lap(4, ClockType.Split, 1, 20, 15F));

            //Act
            actualTimeSpan = newRunner.GetLap(4).SplitTime;

            Assert.AreEqual(expectedTimeSpan, actualTimeSpan);
        }
    }
}
