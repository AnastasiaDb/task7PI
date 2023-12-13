using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace task7PI
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void IsPythagoreanTriple_ShouldReturnTrue_ForPythagoreanTriple()
        {
            // Arrange
            int a = 3;
            int b = 4;
            int c = 5;

            // Act
            bool result = Program.IsPythagoreanTriple(a, b, c);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPythagoreanTriple_ShouldReturnFalse_ForNonPythagoreanTriple()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int c = 6;

            // Act
            bool result = Program.IsPythagoreanTriple(a, b, c);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPythagoreanTriple_ShouldHandleZeros()
        {
            // Arrange
            int a = 0;
            int b = 0;
            int c = 0;

            // Act
            bool result = Program.IsPythagoreanTriple(a, b, c);

            // Assert
            Assert.IsTrue(result); // 0^2 + 0^2 = 0^2
        }
    }
}
