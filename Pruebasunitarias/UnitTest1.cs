using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebasunitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumaIncorrecta()
        {
            int result = AplicacionJekins.Program.suma(0,5);
            Assert.AreEqual(result,0);
        }

        [TestMethod]
        public void Sumacorrecta()
        {
            int result = AplicacionJekins.Program.suma(2, 5);
            Assert.AreEqual(result, 7);
        }
    }
}
