using Microsoft.VisualStudio.TestPlatform.TestHost;
using task7PI;
using Task7PI;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsPythagoreanTriple_ShouldReturnTrue_ForPythagoreanTriple()
        {
            Pythagorean p = new Pythagorean();

            int a = 3;
            int b = 4;
            int c = 5;

            bool result = p.IsPythagoreanTriple(a, b, c);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPythagoreanTriple_ShouldReturnFalse_ForNonPythagoreanTriple()
        {
            Pythagorean p = new Pythagorean();
            int a = 2;
            int b = 3;
            int c = 6;

            bool result = p.IsPythagoreanTriple(a, b, c);


            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPythagoreanTriple_ShouldHandleZeros()
        {
            Pythagorean p = new Pythagorean();

            int a = 0;
            int b = 0;
            int c = 0;

            bool result = p.IsPythagoreanTriple(a, b, c);

            Assert.IsTrue(result); // 0^2 + 0^2 = 0^2
        }
    }
}