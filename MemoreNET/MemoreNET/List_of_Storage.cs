using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoreNET
{
    class List_of_Storage
    {
        private List<Storage> list;
        public List_of_Storage()
        {
            list = new List<Storage>();
        }

        public void Add(string name, string manufacturerName, string model, int quantity, int price, int typeOne, int typeTry)
        {
            if(name=="HDD")
            {
                Storage temp = new HDD(name, manufacturerName, model, quantity, price, typeOne, typeTry);
            }
            else if(name=="USB")
            {

            }
            else if(name=="DVD")
            {

            }
        }
    }
}
