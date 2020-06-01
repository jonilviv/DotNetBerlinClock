using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace BerlinClock.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public sealed class BerlinClockTests
    {
        [TestMethod]
        public void BerlinClock_default_constructor__should_create_correct_instance()
        {
            //Arrange
            //Act
            var berlinClock = new Classes.BerlinClock();


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

            Assert.IsFalse(berlinClock.Second);
        }


        [TestMethod]
        public void BerlinClock_hms_constructor_00_00_00__should_create_correct_instance()
        {
            //Arrange
            //Act
            var berlinClock = new Classes.BerlinClock(0);


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
        public void BerlinClock_hms_constructor_24_00_00__should_create_correct_instance()
        {
            //Arrange
            //Act
            var berlinClock = new Classes.BerlinClock(24);


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
        public void BerlinClock_hms_constructor_13_17_01__should_create_correct_instance()
        {
            //Arrange
            //Act
            var berlinClock = new Classes.BerlinClock(13, 17, 1);


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
        public void BerlinClock_hms_constructor_23_59_59__should_create_correct_instance()
        {
            //Arrange
            //Act
            var berlinClock = new Classes.BerlinClock(23, 59, 59);


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


        [TestMethod]
        public void BerlinClock_DateTime_constructor_00_00_00__should_create_correct_instance()
        {
            //Arrange
            //Act
            var berlinClock = new Classes.BerlinClock(DateTime.MinValue);


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
        public void BerlinClock_DateTime_constructor_13_17_01__should_create_correct_instance()
        {
            //Arrange
            DateTime dateTime = new DateTime(1, 1, 1, 13, 17, 1);


            //Act
            var berlinClock = new Classes.BerlinClock(dateTime);


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
        public void BerlinClock_DateTime_constructor_23_59_59__should_create_correct_instance()
        {
            //Arrange
            DateTime dateTime = new DateTime(1, 1, 1, 23, 59, 59);

            //Act
            var berlinClock = new Classes.BerlinClock(dateTime);


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


        [TestMethod]
        public void BerlinClock_ToString_00_00_00__should_returns_correct_value()
        {
            //Arrange
            var berlinClock = new Classes.BerlinClock(0);


            //Act
            string actualValue = berlinClock.ToString();


            //Assert
            Assert.IsNotNull(berlinClock);
            Assert.AreEqual(@"Y
OOOO
OOOO
OOOOOOOOOOO
OOOO", actualValue);
        }

        [TestMethod]
        public void BerlinClock_ToString_24_00_00__should_returns_correct_value()
        {
            //Arrange
            var berlinClock = new Classes.BerlinClock(24);


            //Act
            string actualValue = berlinClock.ToString();


            //Assert
            Assert.IsNotNull(berlinClock);
            Assert.AreEqual(@"Y
RRRR
RRRR
OOOOOOOOOOO
OOOO", actualValue);
        }

        [TestMethod]
        public void BerlinClock_ToString_13_17_01__should_returns_correct_value()
        {
            //Arrange
            var berlinClock = new Classes.BerlinClock(13, 17, 1);


            //Act
            string actualValue = berlinClock.ToString();


            //Assert
            Assert.IsNotNull(berlinClock);
            Assert.AreEqual(@"O
RROO
RRRO
YYROOOOOOOO
YYOO", actualValue);
        }

        [TestMethod]
        public void BerlinClock_ToString_23_59_59__should_returns_correct_value()
        {
            //Arrange
            var berlinClock = new Classes.BerlinClock(23, 59, 59);


            //Act
            string actualValue = berlinClock.ToString();


            //Assert
            Assert.IsNotNull(berlinClock);
            Assert.AreEqual(@"O
RRRR
RRRO
YYRYYRYYRYY
YYYY", actualValue);
        }
    }
}