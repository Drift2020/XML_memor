using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MemoreNET
{
    class DVD : Storage
    {
        public int Speadload{get;set;}
        public int SpeadSave{get;set;}

        public DVD()
            : this("DVD", "Sony", "K18", 200,200,10,50)
        {

        }

        public DVD(string Name, string ManufacturerName, string Model, int Size, int Price, int Speadload, int SpeadSave)
            : base(Name, ManufacturerName, Model, Size, Price)
        {
            this.Speadload = Speadload;
            this.SpeadSave = SpeadSave;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("6.Spead load: {0}", Speadload);
            Console.WriteLine("7.Spead save: {0}", SpeadSave);
        }
      
    }
}
