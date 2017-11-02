using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MemoreNET
{
    [Serializable(), XmlInclude(typeof(USB)), XmlInclude(typeof(DVD)), XmlInclude(typeof(HDD))]
    [DataContract]
    public class DVD : Storage
    {
        [DataMember]
        public int Speadload{get;set;}
        [DataMember]
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

        public override void Print(ILog Obj)
        {
            base.Print(Obj);
            Obj.Print("6.Spead load: " + Speadload + "\n7.Spead save: " + SpeadSave+"\n");
            //Console.WriteLine("6.Spead load: {0}", Speadload);
            //Console.WriteLine("7.Spead save: {0}", SpeadSave);
        }
      
    }
}
