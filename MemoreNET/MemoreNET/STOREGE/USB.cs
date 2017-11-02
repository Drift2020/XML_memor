using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MemoreNET
{

    [Serializable(), XmlInclude(typeof(USB)), XmlInclude(typeof(DVD)), XmlInclude(typeof(HDD))]
    [DataContract]
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
        [DataMember]
        public int SizeUSB { get; set; }
        [DataMember]
        public int SpeedUSB { get; set; }

        public override void Print(ILog Obj) {
            base.Print(Obj);
            Obj.Print("6.Size USB: " + SizeUSB+ "\n7.Speed USB: "+ SpeedUSB + "\n");
            //Console.WriteLine("6.Size USB: {0}", SizeUSB);
            //Console.WriteLine("7.Speed USB: {0}", SpeedUSB);
        }
       
    }
}
