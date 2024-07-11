using Microsoft.VisualStudio.TestTools.UnitTesting;
using ColorToHexToolApp;
using System.Drawing;

namespace ColorToHexToolApp.Tests
{
    [TestClass]
    public class ColorToHexTests
    {
        [TestMethod]
        public void Test_ColorToHex_Red()
        {
            // Arrange
            var color = Color.FromArgb(255, 0, 0);
            var expected = "#FF0000";

            // Act
            var result = ColorToHexConverter.Convert(color);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_ColorToHex_Green()
        {
            // Arrange
            var color = Color.FromArgb(0, 255, 0);
            var expected = "#00FF00";

            // Act
            var result = ColorToHexConverter.Convert(color);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_ColorToHex_Blue()
        {
            // Arrange
            var color = Color.FromArgb(0, 0, 255);
            var expected = "#0000FF";

            // Act
            var result = ColorToHexConverter.Convert(color);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_ColorToHex_Black()
        {
            // Arrange
            var color = Color.FromArgb(0, 0, 0);
            var expected = "#000000";

            // Act
            var result = ColorToHexConverter.Convert(color);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_ColorToHex_White()
        {
            // Arrange
            var color = Color.FromArgb(255, 255, 255);
            var expected = "#FFFFFF";

            // Act
            var result = ColorToHexConverter.Convert(color);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_ColorToHex_InvalidColor()
        {
            // Arrange
            Color? color = null;

            // Act
            var result = ColorToHexConverter.Convert(color);

            // Assert is handled by ExpectedException
        }
    }
}
