using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prueba.BusinessLogic;

namespace Prueba.BusinessLogic.Test
{
    [TestClass]
    public class CreateBatchTest
    {
        [TestMethod]
        public void TestCreateBatch()
        {
            Batch batch = new Batch();
        }

        [TestMethod]
        public void TestCreateBatchWithName()
        {
            Batch batch = new Batch() { Name = "Batch-1"};
        }
    }
}
