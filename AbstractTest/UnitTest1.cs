using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractLab;

namespace AbstractTest
{
    [TestClass]
    public class UnitTest1
    {
        SchoolAbstractFactory factory;

        [TestMethod]
        public void CreateEducationNackademinTest()
        {
            factory = new NackademinFactory();
            var edu = factory.CreateEducation().NumberOfStudents;
            var comparison = 40;
            Assert.AreEqual(comparison, edu);
        }

        [TestMethod]
        public void CreateEducationJensenTest()
        {
            factory = new JensenFactory();
            IEducation edu = factory.CreateEducation();
            Assert.AreEqual(50, edu.NumberOfStudents);
        }
    }
}
