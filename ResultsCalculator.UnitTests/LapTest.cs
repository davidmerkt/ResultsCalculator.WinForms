using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResultsCalculator.WinForms;

namespace ResultsCalculator.UnitTests
{
    [TestClass]
    public class LapTest
    {
        [TestMethod]
        public void Lap_LapNumberConstructor_ReturnsLapNumber()
        {
            //Arrange
            int expectedLapNumber = 3;
            int actualLapNumber;
            Lap newLap = new Lap(expectedLapNumber);

            //Act
            actualLapNumber = newLap.LapNumber;

            //Assert
            Assert.AreEqual(expectedLapNumber, actualLapNumber);
        }

        [TestMethod]
        public void Lap_LapTimeConstructor_ReturnsLapNumber()
        {
            //Arrange
            int expectedLapNumber = 3;
            int actualLapNumber;
            Lap newLap = new Lap(expectedLapNumber, 1, 23, 45.6789F);

            //Act
            actualLapNumber = newLap.LapNumber;

            //Assert
            Assert.AreEqual(expectedLapNumber, actualLapNumber);
        }

        [TestMethod]
        public void Lap_LapTimeConstructor_ReturnsLapTime()
        {
            //Arrange
            int expectedLapNumber = 3;
            TimeSpan expectedLapTime = new TimeSpan(0, 1, 23, 45, 678);
            TimeSpan actualLapTime;
            Lap newLap = new Lap(expectedLapNumber, 1, 23, 45.678F);

            //Act
            actualLapTime = newLap.LapTime;

            //Assert
            Assert.AreEqual(expectedLapTime, actualLapTime);
        }

        [TestMethod]
        public void Lap_LapTimeConstructor_ReturnsLapTime4PrecisionMilliseconds()
        {
            //Arrange
            int expectedLapNumber = 3;
            TimeSpan expectedLapTime = new TimeSpan(0, 1, 23, 45, 678);
            TimeSpan actualLapTime;
            Lap newLap = new Lap(expectedLapNumber, 1, 23, 45.6789F);

            //Act
            actualLapTime = newLap.LapTime;

            //Assert
            Assert.AreEqual(expectedLapTime.TotalSeconds, actualLapTime.TotalSeconds, 0.01D);
        }

        [TestMethod]
        public void Lap_LapTimeConstructor_ReturnsLapTimeMoreThan60Seconds()
        {
            //Arrange
            int expectedLapNumber = 3;
            TimeSpan expectedLapTime = new TimeSpan(0, 1, 24, 45, 678);
            TimeSpan actualLapTime;
            Lap newLap = new Lap(expectedLapNumber, 1, 23, 105.678F);

            //Act
            actualLapTime = newLap.LapTime;

            //Assert
            Assert.AreEqual(expectedLapTime, actualLapTime);
        }

        [TestMethod]
        public void Lap_ClockTypeConstructor_ClockTypeLapReturnsLapNumber()
        {
            //Arrange
            int expectedLapNumber = 3;
            int actualLapNumber;
            Lap newLap = new Lap(expectedLapNumber, ClockType.Lap, 1, 23, 45.6789F);
            
            //Act
            actualLapNumber = newLap.LapNumber;

            //Assert
            Assert.AreEqual(expectedLapNumber, actualLapNumber);
        }

        [TestMethod]
        public void Lap_ClockTypeConstructor_ClockTypeLapReturnsLapTime()
        {
            //Arrange
            int expectedLapNumber = 3;
            TimeSpan expectedLapTime = new TimeSpan(0, 1, 23, 45, 678);
            TimeSpan actualLapTime;
            Lap newLap = new Lap(expectedLapNumber, ClockType.Lap, 1, 23, 45.6789F);

            //Act
            actualLapTime = newLap.LapTime;

            //Assert
            Assert.AreEqual(expectedLapTime.TotalSeconds, actualLapTime.TotalSeconds, 0.01D);
        }

        [TestMethod]
        public void Lap_ClockTypeConstructor_ClockTypeSplitReturnsLapNumber()
        {
            //Arrange
            int expectedLapNumber = 3;
            int actualLapNumber;
            Lap newLap = new Lap(expectedLapNumber, ClockType.Split, 1, 23, 45.6789F);

            //Act
            actualLapNumber = newLap.LapNumber;

            //Assert
            Assert.AreEqual(expectedLapNumber, actualLapNumber);
        }

        [TestMethod]
        public void Lap_ClockTypeConstructor_ClockTypeSplitReturnsSplitTime()
        {
            //Arrange
            int expectedLapNumber = 3;
            TimeSpan expectedSplitTime = new TimeSpan(0, 1, 23, 45, 678);
            TimeSpan actualSplitTime;
            Lap newLap = new Lap(expectedLapNumber, ClockType.Split, 1, 23, 45.6789F);

            //Act
            actualSplitTime = newLap.SplitTime;

            //Assert
            Assert.AreEqual(expectedSplitTime.TotalSeconds, actualSplitTime.TotalSeconds, 0.01D);
        }

        [TestMethod]
        public void Lap_SplitDateTimeConstructor_ReturnsLapNumber()
        {
            //Arrange
            int expectedLapNumber = 3;
            int actualLapNumber;

            DateTime splitTime = Convert.ToDateTime("1/1/2017 1:23PM");
            DateTime startTime = Convert.ToDateTime("1/1/2017 1:03PM");
            Lap newLap = new Lap(expectedLapNumber, splitTime, startTime);

            //Act
            actualLapNumber = newLap.LapNumber;

            //Assert
            Assert.AreEqual(expectedLapNumber, actualLapNumber);
        }

        [TestMethod]
        public void Lap_SplitDateTimeConstructor_CalculatesSplitTime()
        {
            //Arrange
            int expectedLapNumber = 3;
            TimeSpan expectedTimeSpan = new TimeSpan(0, 0, 20, 0, 0);
            TimeSpan actualTimeSpan;

            DateTime splitTime = Convert.ToDateTime("1/1/2017 1:23PM");
            DateTime startTime = Convert.ToDateTime("1/1/2017 1:03PM");
            Lap newLap = new Lap(expectedLapNumber, splitTime, startTime);

            //Act
            actualTimeSpan = newLap.SplitTime;

            //Assert
            Assert.AreEqual(expectedTimeSpan, actualTimeSpan);
        }  
    }
}
