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
    [KnownType(typeof(USB))]
    [KnownType(typeof(DVD))]
    [KnownType(typeof(HDD))]
    abstract public class Storage
    {
      
        public Storage()
        {
            Name = null;
            ManufacturerName = null;
            Model = null;
            Size = 0;
            Price = 0;
        }
        public Storage(string Name, string ManufacturerName, string Model, int Size, int Price)
        {
          
            this.Name = Name;
            this.ManufacturerName = ManufacturerName;
            this.Model = Model;
            this.Size = Size;
            this.Price = Price;
        }
        [DataMember]
        public string Name
        {
            set;
            get;
        }
        [DataMember]
        public string ManufacturerName
        {
            set;
            get;
        }
        [DataMember]
        public string Model
        {
            set;
            get;
        }
        [DataMember]
        public int Size
        {
            set;
            get;
        }
        [DataMember]
        public int Price
        {
            set;
            get;
        }

        public virtual void Print(ILog Obj)
        {
            Obj.Print("1.Name: "+ Name + "\n2.Manufacturer name: "+ManufacturerName + "\n3.Model: "+ Model + "\n4.Quantity: "+ Size + "\n5.Price: "+Price);
           

        }
        
    }

   
}

