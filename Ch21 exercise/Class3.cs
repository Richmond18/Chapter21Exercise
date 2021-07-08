using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch21exercise
{
    public class Cellphone : Computer 
    {
        public Cellphone(int serialNumber, int storage, string ipAddress, string id)
            : base(serialNumber, storage, ipAddress, id)
        {
        }

        public override string AssignID()
        {
            this.ID = "4400";

            return this.ID;
        }











    }
}
