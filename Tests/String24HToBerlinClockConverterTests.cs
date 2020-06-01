using BerlinClock.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace BerlinClock.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public sealed class String24HToBerlinClockConverterTests
    {
        [TestMethod]
        public void String24HToBerlinClockConverter_Convert__should_raise_exception_on_null_time24H_value()
        {
            Test_invalid_time_value(null);
        }

        [TestMethod]
        public void String24HToBerlinClockConverter_Convert__should_raise_exception_on_string_empty_time24H_value()
        {
            Test_invalid_time_value(string.Empty);
        }

        [TestMethod]
        public void String24HToBerlinClockConverter_Convert__should_raise_exception_on_white_space_time24H_value()
        {
            Test_invalid_time_value("    ");
        }

        [TestMethod]
        public void String24HToBerlinClockConverter_Convert__should_raise_exception_on_bad_string_time24H_value()
        {
            Test_invalid_time_value("bla");
        }

        [TestMethod]
        public void String24HToBerlinClockConverter_Convert__should_raise_exception_on_bad_time24H_value()
        {
            Test_invalid_time_value("34:56:78");
        }

        private void Test_invalid_time_value(string time24H)
        {
            //Arrange
            var string24HToBerlinClockConverter = new String24HToBerlinClockConverter();
            bool exceptionWasRaised = false;

            //Act
            //Assert
            try
            {
                string24HToBerlinClockConverter.Convert(time24H);
            }
            catch (Exception e)
            {
                exceptionWasRaised = true;
                Assert.IsInstanceOfType(e, typeof(InvalidTimeFormat));
            }

            Assert.IsTrue(exceptionWasRaised);
        }

        [TestMethod]
        public void String24HToBerlinClockConverter_Convert__should_returns_00_00_00_time24H_value()
        {
            //Arrange
            var string24HToBerlinClockConverter = new String24HToBerlinClockConverter();


            //Act
            Classes.BerlinClock berlinClock = string24HToBerlinClockConverter.Convert("00:00:00");


            //Assert
            Assert.IsNotNull(berlinClock);
            Assert.IsFalse(berlinClock.Hour1);
            Assert.IsFalse(berlinClock.Hour2);
            Assert.IsFalse(berlinClock.Hour3);
            Assert.IsFalse(berlinClock.Hour4);
            Assert.IsFalse(berlinClock.Hours5);
            Assert.IsFalse(berlinClock.Hours10);
            Assert.IsFalse(berlinClock.Hours15);
            Assert.IsFalse(berlinClock.Hours20);

            Assert.IsFalse(berlinClock.Minute1);
            Assert.IsFalse(berlinClock.Minute2);
            Assert.IsFalse(berlinClock.Minute3);
            Assert.IsFalse(berlinClock.Minute4);
            Assert.IsFalse(berlinClock.Minutes5);
            Assert.IsFalse(berlinClock.Minutes10);
            Assert.IsFalse(berlinClock.Minutes15);
            Assert.IsFalse(berlinClock.Minutes20);
            Assert.IsFalse(berlinClock.Minutes25);
            Assert.IsFalse(berlinClock.Minutes30);
            Assert.IsFalse(berlinClock.Minutes35);
            Assert.IsFalse(berlinClock.Minutes40);
            Assert.IsFalse(berlinClock.Minutes45);
            Assert.IsFalse(berlinClock.Minutes50);
            Assert.IsFalse(berlinClock.Minutes55);

            Assert.IsTrue(berlinClock.Second);
        }

        [TestMethod]
        public void String24HToBerlinClockConverter_Convert__should_returns_24_time24H_value()
        {
            //Arrange
            var string24HToBerlinClockConverter = new String24HToBerlinClockConverter();


            //Act
            Classes.BerlinClock berlinClock = string24HToBerlinClockConverter.Convert("24:00:00");


            //Assert
            Assert.IsNotNull(berlinClock);
            Assert.IsTrue(berlinClock.Hour1);
            Assert.IsTrue(berlinClock.Hour2);
            Assert.IsTrue(berlinClock.Hour3);
            Assert.IsTrue(berlinClock.Hour4);
            Assert.IsTrue(berlinClock.Hours5);
            Assert.IsTrue(berlinClock.Hours10);
            Assert.IsTrue(berlinClock.Hours15);
            Assert.IsTrue(berlinClock.Hours20);

            Assert.IsFalse(berlinClock.Minute1);
            Assert.IsFalse(berlinClock.Minute2);
            Assert.IsFalse(berlinClock.Minute3);
            Assert.IsFalse(berlinClock.Minute4);
            Assert.IsFalse(berlinClock.Minutes5);
            Assert.IsFalse(berlinClock.Minutes10);
            Assert.IsFalse(berlinClock.Minutes15);
            Assert.IsFalse(berlinClock.Minutes20);
            Assert.IsFalse(berlinClock.Minutes25);
            Assert.IsFalse(berlinClock.Minutes30);
            Assert.IsFalse(berlinClock.Minutes35);
            Assert.IsFalse(berlinClock.Minutes40);
            Assert.IsFalse(berlinClock.Minutes45);
            Assert.IsFalse(berlinClock.Minutes50);
            Assert.IsFalse(berlinClock.Minutes55);

            Assert.IsTrue(berlinClock.Second);
        }

        [TestMethod]
        public void String24HToBerlinClockConverter_Convert__should_returns_13_17_01_time24H_value()
        {
            //Arrange
            var string24HToBerlinClockConverter = new String24HToBerlinClockConverter();


            //Act
            Classes.BerlinClock berlinClock = string24HToBerlinClockConverter.Convert("13:17:01");


            //Assert
            Assert.IsNotNull(berlinClock);
            Assert.IsTrue(berlinClock.Hour1);
            Assert.IsTrue(berlinClock.Hour2);
            Assert.IsTrue(berlinClock.Hour3);
            Assert.IsFalse(berlinClock.Hour4);
            Assert.IsTrue(berlinClock.Hours5);
            Assert.IsTrue(berlinClock.Hours10);
            Assert.IsFalse(berlinClock.Hours15);
            Assert.IsFalse(berlinClock.Hours20);

            Assert.IsTrue(berlinClock.Minute1);
            Assert.IsTrue(berlinClock.Minute2);
            Assert.IsFalse(berlinClock.Minute3);
            Assert.IsFalse(berlinClock.Minute4);
            Assert.IsTrue(berlinClock.Minutes5);
            Assert.IsTrue(berlinClock.Minutes10);
            Assert.IsTrue(berlinClock.Minutes15);
            Assert.IsFalse(berlinClock.Minutes20);
            Assert.IsFalse(berlinClock.Minutes25);
            Assert.IsFalse(berlinClock.Minutes30);
            Assert.IsFalse(berlinClock.Minutes35);
            Assert.IsFalse(berlinClock.Minutes40);
            Assert.IsFalse(berlinClock.Minutes45);
            Assert.IsFalse(berlinClock.Minutes50);
            Assert.IsFalse(berlinClock.Minutes55);

            Assert.IsFalse(berlinClock.Second);
        }

        [TestMethod]
        public void String24HToBerlinClockConverter_Convert__should_returns_23_59_59_time24H_value()
        {
            //Arrange
            var string24HToBerlinClockConverter = new String24HToBerlinClockConverter();


            //Act
            Classes.BerlinClock berlinClock = string24HToBerlinClockConverter.Convert("23:59:59");


            //Assert
            Assert.IsNotNull(berlinClock);
            Assert.IsTrue(berlinClock.Hour1);
            Assert.IsTrue(berlinClock.Hour2);
            Assert.IsTrue(berlinClock.Hour3);
            Assert.IsFalse(berlinClock.Hour4);
            Assert.IsTrue(berlinClock.Hours5);
            Assert.IsTrue(berlinClock.Hours10);
            Assert.IsTrue(berlinClock.Hours15);
            Assert.IsTrue(berlinClock.Hours20);

            Assert.IsTrue(berlinClock.Minute1);
            Assert.IsTrue(berlinClock.Minute2);
            Assert.IsTrue(berlinClock.Minute3);
            Assert.IsTrue(berlinClock.Minute4);
            Assert.IsTrue(berlinClock.Minutes5);
            Assert.IsTrue(berlinClock.Minutes10);
            Assert.IsTrue(berlinClock.Minutes15);
            Assert.IsTrue(berlinClock.Minutes20);
            Assert.IsTrue(berlinClock.Minutes25);
            Assert.IsTrue(berlinClock.Minutes30);
            Assert.IsTrue(berlinClock.Minutes35);
            Assert.IsTrue(berlinClock.Minutes40);
            Assert.IsTrue(berlinClock.Minutes45);
            Assert.IsTrue(berlinClock.Minutes50);
            Assert.IsTrue(berlinClock.Minutes55);

            Assert.IsFalse(berlinClock.Second);
        }
    }
}