using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch21exercise
{
    public class Computer: AbstractEntity
    {
        readonly int SerialNumber;
        public int Storage { get; set; }
        public string IpAdress { get; set; }

        //public Computer()
        //    {
        //    }
        
        public Computer(int serialNumber, int storage, string ipAddress, string id)
            : base (id)
        {
            this.SerialNumber =serialNumber;
            this.Storage = storage;
            this.IpAdress = ipAddress;
            
        }

        public void GetDeviceInfo()
        {
            Console.WriteLine($"SerialNumber: { this.SerialNumber} " +
                $"| Storage: {this.Storage} GB | IpAdress: {this.IpAdress} id :{this.ID}");
        }

        public double DownloadPicture()
        {
            this.Storage -= 10;
            return this.Storage;
        
        }

        public double DownloadGame()
        {
            this.Storage -= 30;
            return this.Storage;

        }

        public override string AssignID()
        {
            this.ID = "2568";
            return this.ID;
        }



    }
}

