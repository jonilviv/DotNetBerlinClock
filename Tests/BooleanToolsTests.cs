using BerlinClock.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace BerlinClock.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public sealed class BooleanToolsTests
    {
        [TestMethod]
        public void BooleanTools_RedToString__on_false_value_should_returns_O()
        {
            //Arrange
            const bool val = false;


            //Act
            string result = BooleanTools.RedToString(val);


            //Assert
            Assert.AreEqual("O", result);
        }

        [TestMethod]
        public void BooleanTools_RedToString__on_true_value_should_returns_R()
        {
            //Arrange
            const bool val = true;


            //Act
            string result = BooleanTools.RedToString(val);


            //Assert
            Assert.AreEqual("R", result);
        }

        [TestMethod]
        public void BooleanTools_YellowToString__on_false_value_should_returns_O()
        {
            //Arrange
            const bool val = false;


            //Act
            string result = BooleanTools.YellowToString(val);


            //Assert
            Assert.AreEqual("O", result);
        }

        [TestMethod]
        public void BooleanTools_YellowToString__on_true_value_should_returns_R()
        {
            //Arrange
            const bool val = true;


            //Act
            string result = BooleanTools.YellowToString(val);


            //Assert
            Assert.AreEqual("Y", result);
        }
    }
}