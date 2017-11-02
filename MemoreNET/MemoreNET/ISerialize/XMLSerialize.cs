using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace MemoreNET
{
    class XMLSerialize : ISerialize
    {
        public void Save(List<Storage> list)
        {
            FileStream stream = null;
            XmlSerializer serializer = null;

            stream = new FileStream("../../list.xml", FileMode.Create);
            serializer = new XmlSerializer(typeof(List<Storage>));
            serializer.Serialize(stream, list);
            stream.Close();
        }

        public List<Storage> Load()
        {
            FileStream stream = null;
            XmlSerializer serializer = null;
            try
            {
                stream = new FileStream("../../list.xml", FileMode.Open);
                serializer = new XmlSerializer(typeof(List<Storage>));
                List<Storage> temp = (List<Storage>)serializer.Deserialize(stream);
                stream.Close();
                Console.Clear();
                return temp;
            }
            catch (Exception ex) { Console.Clear(); Console.WriteLine(ex); };
            stream.Close();
            return new List<Storage>();
        }
    }
}
