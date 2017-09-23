using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.BusinessLogic
{
    public class Batch
    {
        public string Description { get; set; }
        public string Name { get; set; }
        private string Status;
        public void setStatus(string aStatus)
        {
            if (aStatus != "Closed")
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
