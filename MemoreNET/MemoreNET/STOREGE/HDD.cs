using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MemoreNET
{
    class HDD:Storage
    {
        public int SizeP { get; set; }
        public int SpeedHDD { get; set; }

        public HDD()
            : this("HDD", "Kavasaki", "K20", 200, 200, 10, 50)
        {

        }

        public HDD(string Name, string ManufacturerName, string Model, int Size, int Price, int SizeP, int SpeedHDD)
            : base(Name, ManufacturerName, Model, Size, Price)
        {
            this.SizeP = SizeP;
            this.SpeedHDD = SpeedHDD;
        }

        public override void Print(ILog Obj)
        {
            base.Print(Obj);
            Obj.Print("6.Size: "+SizeP+ "\n7.Speed HDD: "+SpeedHDD);
            //Console.WriteLine("6.Size: {0}", SizeP);
            //Console.WriteLine("7.Speed HDD: {0}", SpeedHDD);
        }
       
    }
}
