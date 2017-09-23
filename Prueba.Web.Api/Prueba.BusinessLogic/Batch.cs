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
        public void setStatus(string aStatus)
        {
            if (availableStatus.Contains(aStatus))
            {
                this.Status = aStatus;
            }
        }
        public string getStatus()
        {
            return this.Status;
        }
    }
}
