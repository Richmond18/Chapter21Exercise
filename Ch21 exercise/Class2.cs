using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch21exercise
{
    public class Laptop: Computer
    {
        public Laptop(int serialNumber, int storage, string ipAddress, string id)
            : base (serialNumber, storage, ipAddress, id)
        { 
        }

        public override string AssignID()
        {
            this.ID = "3558";
            
            return (this.ID);
        }















    }
}
