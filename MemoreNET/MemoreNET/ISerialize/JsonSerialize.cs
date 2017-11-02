using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;

namespace MemoreNET
{
    class JsonSerialize : ISerialize
    {
        public void Save(List<Storage> list)
        {
            FileStream stream = null;
            DataContractJsonSerializer jsonFormatter = null;

            stream = new FileStream("../../Json.json", FileMode.Create);
            jsonFormatter = new DataContractJsonSerializer(typeof(List<Storage>));
            jsonFormatter.WriteObject(stream, list);
            stream.Close();
        }

        public List<Storage> Load()
        {
            FileStream stream = null;
            DataContractJsonSerializer jsonFormatter = null;
            try
            {
                stream = new FileStream("../../Json.json", FileMode.Open);
            jsonFormatter = new DataContractJsonSerializer(typeof(List<Storage>));
            List<Storage> temp = (List<Storage>)jsonFormatter.ReadObject(stream);
            stream.Close();
                Console.Clear();
                return temp;
        } catch (Exception ex) { Console.Clear(); Console.WriteLine(ex); };
            stream.Close();
            return new List<Storage>();
        }
    }
}
