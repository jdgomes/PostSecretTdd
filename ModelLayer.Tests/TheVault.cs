using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelLayer;

namespace ModelLayer.Tests
{
    [TestClass]
    public class TheVault
    {
        [TestMethod]
        public void Exists()
        {
            Assert.IsNotNull(new Vault());
        }

        //Given a vault it contains a secrets
        //Given a new vault it has a secret indicate there are no secrets

    }
}
