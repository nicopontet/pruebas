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
            batch.setStatus(testStatus);
            Assert.AreEqual(testStatus, batch.getStatus());
        }

        [TestMethod]
        public void TestCreateBatchWithWrongStatus()
        {
            string testStatus = "Closed";
            batch.setStatus(testStatus);
            Assert.AreNotEqual(testStatus, batch.getStatus());
        }

        [TestMethod]
        public void TestCreateBatchCorrectStatus()
        {
            string testStatusOpen = "Open";
            string testStatusInspecting = "Inspecting";
            string testStatusReadyToGo = "ReadyToGo";
            string testStatusInTransit = "InTransit";
            string testStatusDelivered = "Delivered";
            Batch batchOpen = new Batch();
            batchOpen.setStatus(testStatusOpen);
            Batch batchReadyToGo = new Batch();
            batchReadyToGo.setStatus(testStatusReadyToGo);
            Batch batchInspecting = new Batch();
            batchInspecting.setStatus(testStatusInspecting);
            Batch batchInTransit = new Batch();
            batchInTransit.setStatus(testStatusInTransit);
            Batch batchDelivered = new Batch();
            batchDelivered.setStatus(testStatusDelivered);
            Assert.AreEqual(testStatusOpen, batchOpen.getStatus());
            Assert.AreEqual(testStatusInspecting, batchInspecting.getStatus());
            Assert.AreEqual(testStatusReadyToGo, batchReadyToGo.getStatus());
            Assert.AreEqual(testStatusInTransit, batchInTransit.getStatus());
            Assert.AreEqual(testStatusDelivered, batchDelivered.getStatus());
        }

        [TestMethod]
        public void TestCreateBatchIncoorrectStatus()
        {
            string testStatus = "WrongStatus";
            Batch batchOpen = new Batch();
            batch.setStatus(testStatus);
            Assert.AreNotEqual(testStatus, batchOpen.getStatus());
        }

    }
}
