using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MemoreNET
{
    public class USB : Storage
    {
        public USB()
            : this("USB", "Samsung", "K19", 200, 200, 10, 50)
        {

        }

        public USB(string Name, string ManufacturerName, string Model, int Size, int Price, int SizeUSB, int SpeedUSB):base(Name, ManufacturerName, Model, Size, Price)
        {
            this.SizeUSB = SizeUSB;
            this.SpeedUSB = SpeedUSB;
        }
        public int SizeUSB { get; set; }
        public int SpeedUSB { get; set; }

        public override void Print(ILog Obj) {
            base.Print(Obj);
            Obj.Print("6.Size USB: " + SizeUSB+ "\n7.Speed USB: "+ SpeedUSB);
            //Console.WriteLine("6.Size USB: {0}", SizeUSB);
            //Console.WriteLine("7.Speed USB: {0}", SpeedUSB);
        }
       
    }
}
