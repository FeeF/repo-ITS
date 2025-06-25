namespace TestCalcolatrice
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestSomma()
        {
            Calcolatrice.Calcolatrice calcolatrice = new Calcolatrice.Calcolatrice();
            double risultato = calcolatrice.Somma(2, 3);
            Assert.AreEqual(5, risultato);

        }
    }
}
