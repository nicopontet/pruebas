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
            batch.SetStatus(testStatus);
            Assert.AreEqual(testStatus, batch.GetStatus());
        }

        [TestMethod]
        public void TestCreateBatchWithWrongStatus()
        {
            string testStatus = "Closed";
            batch.SetStatus(testStatus);
            Assert.AreNotEqual(testStatus, batch.GetStatus());
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
            batchOpen.SetStatus(testStatusOpen);
            Batch batchReadyToGo = new Batch();
            batchReadyToGo.SetStatus(testStatusReadyToGo);
            Batch batchInspecting = new Batch();
            batchInspecting.SetStatus(testStatusInspecting);
            Batch batchInTransit = new Batch();
            batchInTransit.SetStatus(testStatusInTransit);
            Batch batchDelivered = new Batch();
            batchDelivered.SetStatus(testStatusDelivered);
            Assert.AreEqual(testStatusOpen, batchOpen.GetStatus());
            Assert.AreEqual(testStatusInspecting, batchInspecting.GetStatus());
            Assert.AreEqual(testStatusReadyToGo, batchReadyToGo.GetStatus());
            Assert.AreEqual(testStatusInTransit, batchInTransit.GetStatus());
            Assert.AreEqual(testStatusDelivered, batchDelivered.GetStatus());
        }

        [TestMethod]
        public void TestCreateBatchIncoorrectStatus()
        {
            string testStatus = "WrongStatus";
            Batch batchOpen = new Batch();
            batch.SetStatus(testStatus);
            Assert.AreNotEqual(testStatus, batchOpen.GetStatus());
        }

        [TestMethod]
        public void TestCreateBatchWithOperator()
        {
            Operator portOperator = new Operator();
            Batch batchOpen = new Batch();
            batch.SetOperator(portOperator);
            Assert.AreNotEqual(portOperator, batchOpen.GetOperator());
        }

    }
}
