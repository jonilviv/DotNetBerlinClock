using BerlinClock.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace BerlinClock.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public sealed class InvalidTimeFormatTests
    {
        [TestMethod]
        public void InvalidTimeFormat_Message__should_returns_correct_message()
        {
            //Arrange
            var i = new InvalidTimeFormat();


            //Act
            string message = i.Message;


            //Assert
            Assert.AreEqual(CommonResources.InvalidTimeFormat, message);
        }
    }
}