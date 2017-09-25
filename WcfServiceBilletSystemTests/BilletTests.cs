using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfServiceBilletSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceBilletSystem.Tests
{
    [TestClass()]
    public class BilletTests
    {
        [TestMethod()]
        public void BilprisTest()
        {
           //Arrange
           Billet bil = new Billet();
            //Act
            int minint = bil.Bilpris();
            //Assert
            Assert.AreEqual(bil.Bilpris(), minint);
        }

        [TestMethod()]
        public void BilprisMedBizzTest()
        {
            //Arrange
            Billet bil = new Billet();
            //Act
            int minint = bil.BilprisMedBizz();
            //Assert
            Assert.AreEqual(bil.BilprisMedBizz(), minint);
        }

        [TestMethod()]
        public void BilprisØresundTest()
        {
            //Arrange
            Billet bil = new Billet();
            //Act
            int minint = bil.BilprisØresund();
            //Assert
            Assert.AreEqual(bil.BilprisØresund(), minint);
        }

        [TestMethod()]
        public void BilprisØresundBizzTest()
        {
            //Arrange
            Billet bil = new Billet();
            //Act
            int minint = bil.BilprisØresundBizz();
            //Assert
            Assert.AreEqual(bil.BilprisØresundBizz(), minint);
        }

        [TestMethod()]
        public void MCBrobizTest()
        {
            //Arrange
            Billet mc = new Billet();
            //Act
            int minint = mc.MCBrobiz();
            //Assert
            Assert.AreEqual(mc.MCBrobiz(), minint);
        }

        [TestMethod()]
        public void MCPrisTest()
        {
            //Arrange
            Billet mc = new Billet();
            //Act
            int minint = mc.MCPris();
            //Assert
            Assert.AreEqual(mc.MCPris(), minint);
        }

        [TestMethod()]
        public void MCprisØresundBizzTest()
        {
            //Arrange
            Billet mc = new Billet();
            //Act
            int minint = mc.MCprisØresundBizz();
            //Assert
            Assert.AreEqual(mc.MCprisØresundBizz(), minint);
        }

        [TestMethod()]
        public void MCØresundTest()
        {
            //Arrange
            Billet mc = new Billet();
            //Act
            int minint = mc.MCØresund();
            //Assert
            Assert.AreEqual(mc.MCØresund(), minint);
        }
    }
}