using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountNS.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        [TestMethod()]
        public void DebitTest()
        {
            //AAA

            //Arrange
            BankAccount ba = new BankAccount("Camilla Ryskjær", 10);

            //Act
            ba.Debit(5);

            //Assert
            Assert.AreEqual(5,ba.Balance);
           
        }
    }
}