using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.BusinessLogic
{
    public class Batch
    {
        private List<string> availableStatus = new List<string>() { "Open", "Inspecting", "ReadyToGo", "InTransit", "Delivered" };
        public string Description { get; set; }
        public string Name { get; set; }
        private string Status;
        public void SetStatus(string aStatus)
        {
            if (IsStatusValid(aStatus))
            {
                this.Status = aStatus;
            }
        }
        public string GetStatus()
        {
            return this.Status;
        }
        private bool IsStatusValid(string aStatus)
        {
            return availableStatus.Contains(aStatus);
        }
        private Operator portOperator;
        public void SetOperator(Operator portOperator)
        {
            this.portOperator = portOperator;
        }

        public Operator GetOperator()
        {
            return this.portOperator;
        }
    }
}
