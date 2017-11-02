using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MemoreNET
{
    class BinarySerialize: ISerialize
    {
        public void Save(List<Storage> list)
        {
            BinaryFormatter formatter = null;
            FileStream stream = null;


            stream = new FileStream("../../Binary.txt", FileMode.Create);
            formatter = new BinaryFormatter();
            formatter.Serialize(stream, list);
            stream.Close();
        }

        public List<Storage> Load()
        {
            BinaryFormatter formatter = null;
            FileStream stream = null;
            try {
            stream = new FileStream("../../Binary.txt", FileMode.Open);
           
                formatter = new BinaryFormatter();
                List<Storage> temp = (List<Storage>)formatter.Deserialize(stream);
                stream.Close();
                Console.Clear();
                return temp;
            }
            catch(Exception ex) { Console.Clear(); Console.WriteLine(ex); };
            stream.Close();
            return new List<Storage>();
        }
    }
}
