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
            Person personNull = new Person();
            Person personNotNull = new Person(@"Бунин Иван РН-231");
            Assert.AreEqual(-1, PersonComparer.CompareByName(personNull, personNotNull));
        }

        [TestMethod]
        public void TestNameCompare()
        {
            Person personNull = new Person(@"Мандельштам Осип РН-231");
            Person personNotNull = new Person(@"Бунин Иван РН-231");
            Assert.AreEqual(1, PersonComparer.CompareByName(personNull, personNotNull));
        }

    }
}
