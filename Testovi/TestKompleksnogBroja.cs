using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.Oom;

namespace Testovi
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class TestKompleksnogBroja
    {

        [TestMethod]
        public void PozivKonstruktoraKompleksnogBrojaKaoRealniDioPredstavljaPrviargument()
        {
            KompleksniBroj kb = new KompleksniBroj(4,7);
            Assert.AreEqual(4,kb.RealniDio);

        }
        [TestMethod]
        public void PozivKonstruktoraKompleksnogBrojaKaoImaginarniDioPredstavljaDrugiargument()
        {
            KompleksniBroj kb = new KompleksniBroj(4, 7);
            Assert.AreEqual(7, kb.ImaginarniDio);
        }
        [TestMethod]
        public void ZbrojDvaKomleksnaBrojaDajeBrojSrealnimDjelomJednakZbrojuRealnihDjelova()
        {
            KompleksniBroj kb = new KompleksniBroj(4, 7);
            KompleksniBroj kb2 = new KompleksniBroj(7, 9);
            Assert.AreEqual(11, (kb+kb2).RealniDio);

        }
        [TestMethod]
        public void ZbrojDvaKomleksnaBrojaDajeBrojSImaginarnimDjelomJednakZbrojuImaginarnihDjelova()
        {
            KompleksniBroj kb = new KompleksniBroj(4, 7);
            KompleksniBroj kb2 = new KompleksniBroj(7, 9);
            Assert.AreEqual(16, (kb + kb2).ImaginarniDio);

        }
        [TestMethod]
        public void oduzimanjeDvaKomleksnaBrojaDajeBrojSrealnimDjelomJednakoduzimanjeuRealnihDjelova()
        {
            KompleksniBroj kb = new KompleksniBroj(4, 7);
            KompleksniBroj kb2 = new KompleksniBroj(7, 9);
            Assert.AreEqual(-3, (kb - kb2).RealniDio);

        }
        [TestMethod]
        public void oduzimanjeDvaKomleksnaBrojaDajeBrojSImaginarnimDjelomJednakOduzimanjeuImaginarnihDjelova()
        {
            KompleksniBroj kb = new KompleksniBroj(4, 7);
            KompleksniBroj kb2 = new KompleksniBroj(7, 9);
            Assert.AreEqual(-2, (kb - kb2).ImaginarniDio);

        }
    }
}
