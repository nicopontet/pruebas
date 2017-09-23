using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prueba.BusinessLogic;

namespace Prueba.BusinessLogic.Test
{
    [TestClass]
    public class CreateBatchTest
    {
        Batch batch;

        [TestInitialize]
        public void setup()
        {
            batch = new Batch();
        }

        [TestMethod]
        public void TestCreateBatch()
        {
        }

        [TestMethod]
        public void TestCreateBatchWithName()
        {
            string testName = "Batch-1";
            batch.Name = testName;
            Assert.AreEqual(testName, batch.Name);
        }

        [TestMethod]
        public void TestCreateBatchWithDescription()
        {
            string testDescription = "First batch with cars";
            batch.Description = testDescription;
            Assert.AreEqual(testDescription, batch.Description);
        }

        [TestMethod]
        public void TestCreateBatchWithStatus()
        {
            string testStatus = "Open";
            batch.Status = testStatus;
            Assert.AreEqual(testStatus, batch.Status);
        }

    }
}
