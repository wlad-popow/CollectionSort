using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace Omgtu.CollectionSortExcercise
{
    [TestClass]
    public class TestCompare
    {
        internal List<Person> students;
        internal string sourcePath = @"group.txt";

        public TestCompare()
        {
            students = new List<Person>();
        }

        internal void ReadGroup()
        {
            string FifleFullPath = Path.GetFullPath(sourcePath);

            if (!File.Exists(FifleFullPath))
                throw new FileNotFoundException();

            string line;
            using (StreamReader file = new StreamReader(this.sourcePath))
            {
                while ((line = file.ReadLine()) != null)
                {
                    Person student = new Person(line);
                    this.students.Add(student);
                }
            }
        }

        [TestMethod]
        public void TestPersonCollectionSortByName()
        {
            ReadGroup();

            List<string> expectedList = new List<string>();
            foreach (Person student in students)
                expectedList.Add(student.Name);
            expectedList.Sort();

            students.Sort(PersonComparer.CompareByName);

            for (int i = 0; i < students.Count; i++)
                Assert.AreEqual(expectedList[i], students[i].Name);
        }

        [TestMethod]
        public void TestPersonCollectionSortBySurName()
        {
            ReadGroup();

            List<string> expectedList = new List<string>();
            foreach (Person student in students)
                expectedList.Add(student.Surname);
            expectedList.Sort();

            students.Sort(PersonComparer.CompareBySurname);

            for (int i = 0; i < students.Count; i++)
                Assert.AreEqual(expectedList[i], students[i].Surname);
        }

        [TestMethod]
        public void TestPersonCollectionSortByGroupNameSurname()
        {
            ReadGroup();

            List<string> expectedList = new List<string>();
            foreach (Person student in students)
            {
                string expected = student.Group.Substring(0, 4);
                expected += student.Name.Substring(0, 4);
                expected += student.Surname.Substring(0, 4);

                expectedList.Add(expected);
            }
            expectedList.Sort();

            students.Sort(PersonComparer.CompareByGroupNameSurname);

            for (int i = 0; i < students.Count; i++)
            {
                string actual = students[i].Group.Substring(0, 4);
                actual += students[i].Name.Substring(0, 4);
                actual += students[i].Surname.Substring(0, 4);

                Assert.AreEqual(expectedList[i], actual);
            }
        }
    }
}
