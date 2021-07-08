using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch21exercise
{
    abstract public class AbstractEntity 
    {
        public string ID { get; set; }
       // int serialNumber, int storage, string ipAddress,
        public AbstractEntity(string id)
           // : base(serialNumber, storage, ipAddress)
        {
            this.ID = id; 
        }
        public AbstractEntity()
        { }

        public virtual string  AssignID()
        {
           // id = this.ID;
            this.ID = "12332";
            return this.ID;
        }
             
              
                  
   
       

        
    }
}
