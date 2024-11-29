using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UP;
using UP.Models;
using UP.Windows;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMailFalse()
        {
            string mail = "";
            bool actual = false;
            EditDriver e = new EditDriver();
            bool extended = e.IsValidEmail(mail);
            Assert.AreEqual(extended, actual);
        }
        [TestMethod]
        public void TestMailTrue()
        {
            string mail = "qwerty@mail.ru";
            bool actual = true;
            EditDriver e = new EditDriver();
            bool extended = e.IsValidEmail(mail);
            Assert.AreEqual(extended, actual);

        }
        [TestMethod]
        public void TestMailFalse2()
        {
            string mail = "qwertymail.ru";
            bool actual = false;
            EditDriver e = new EditDriver();
            bool extended = e.IsValidEmail(mail);
            Assert.AreEqual(extended, actual);

        }
    }
}
