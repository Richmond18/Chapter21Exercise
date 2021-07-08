using System;

namespace Ch21exercise
{
    class Program
    {
        static void Main(string[] args)

        {
            

            Computer Computer1 = new Computer(5500, 800, "192.18.135.2", "");
            

            Computer1.DownloadPicture();
            Computer1.DownloadGame();
            //Computer1.GetDeviceInfo();
            Computer1.AssignID();
            Computer1.GetDeviceInfo();


            Laptop Laptop1 = new Laptop(3300, 300, "192.18.13.2","");
            Laptop1.DownloadPicture();
            Laptop1.DownloadGame();
            Laptop1.AssignID();
            Laptop1.GetDeviceInfo();

            Cellphone cellphone1 = new Cellphone(4400, 100, "194.18.13.2", "");
            cellphone1.DownloadPicture();
            cellphone1.DownloadGame();
            cellphone1.AssignID();
            cellphone1.GetDeviceInfo();



        }
    }
}
