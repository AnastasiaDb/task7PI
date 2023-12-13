using 

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsPythagoreanTriple_ShouldReturnTrue_ForPythagoreanTriple()
        {
            var Program = new Program();

            int a = 3;
            int b = 4;
            int c = 5;

            bool result = Program.IsPythagoreanTriple(a, b, c);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPythagoreanTriple_ShouldReturnFalse_ForNonPythagoreanTriple()
        {
            var Program = new Program();
            int a = 2;
            int b = 3;
            int c = 6;

            bool result = Program.IsPythagoreanTriple(a, b, c);


            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPythagoreanTriple_ShouldHandleZeros()
        {
            var Program = new Program();

            int a = 0;
            int b = 0;
            int c = 0;

            bool result = Program.IsPythagoreanTriple(a, b, c);


            Assert.IsTrue(result); // 0^2 + 0^2 = 0^2
        }
    }
}