using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace Omgtu.CollectionSortExcercise
{
    [TestClass]
    public class TestCompare
    {

        public TestCompare()
        {
        }

        [TestMethod]
        public void TestNameCompareNull()
        {
            Person personLeft = new Person();
            Person personRight = new Person(@"Бунин Иван РН-231");
            Assert.AreEqual(-1, PersonComparer.CompareByName(personLeft, personRight));
        }

        [TestMethod]
        public void TestNameCompare()
        {
            Person personLeft = new Person(@"Мандельштам Осип РН-231");
            Person personRight = new Person(@"Бунин Иван РН-231");
            Assert.AreEqual(1, PersonComparer.CompareByName(personLeft, personRight));
        }

        [TestMethod]
        public void TestGroupNameSurnameCompareDifferentGroup()
        {
            Person personLeft = new Person(@"Бунин Иван РН-231");
            Person personRight = new Person(@"Бунин Иван РН-131");
            Assert.AreEqual(1, PersonComparer.CompareByGroupNameSurname(personLeft, personRight));
        }

        [TestMethod]
        public void TestGroupNameSurnameCompareSameGroup()
        {
            Person personLeft = new Person(@"Мандельштам Осип РН-231");
            Person personRight = new Person(@"Бунин Иван РН-231");
            Assert.AreEqual(1, PersonComparer.CompareByGroupNameSurname(personLeft, personRight));
        }

        [TestMethod]
        public void TestGroupNameSurnameCompareSameGroupName()
        {
            Person personLeft = new Person(@"Некрасов Иван РН-231");
            Person personRight = new Person(@"Бунин Иван РН-231");
            Assert.AreEqual(1, PersonComparer.CompareByGroupNameSurname(personLeft, personRight));
        }

    }
}
