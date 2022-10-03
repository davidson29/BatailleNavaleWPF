using BatailleNavale;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Case cases = new Case(1,0);
            Case case1 = new Case(1,1);
            Case[] vecteur = { cases,case1};
            Destroyer destroyer = new Destroyer(vecteur);
            Assert.AreEqual(destroyer.Taille, 2);
        }
    }
}