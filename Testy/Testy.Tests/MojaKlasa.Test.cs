     using NUnit.Framework;
     using Testy;

     [TestFixture]
     public class MojaKlasaTest
     {
         [Test]
         public void TestMetody()
         {
            
             int oczekiwanyWynik = 1;

           
             int wynik = MojaKlasa.MojaMetoda();

             
             Assert.AreEqual(oczekiwanyWynik, wynik);
         }
     }