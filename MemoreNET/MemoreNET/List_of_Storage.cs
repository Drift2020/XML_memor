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
            Storage temp=null;
            if (name=="HDD")
            {
                 temp = new HDD(name, manufacturerName, model, quantity, price, typeOne, typeTry);
            }
            else if(name=="USB")
            {
                 temp = new USB(name, manufacturerName, model, quantity, price, typeOne, typeTry);
            }
            else if(name=="DVD")
            {
                 temp = new DVD(name, manufacturerName, model, quantity, price, typeOne, typeTry);
            }
            list.Add(temp);
        }
        public void Edit(int number, string manufacturerName, string model, int? quantity, int? price, int? typeOne, int? typeTry)
        {
            if (list[number] is HDD)
            {
                HDD P = list[number] as HDD;

                if(manufacturerName!=null)
                    P.ManufacturerName = manufacturerName;
                if (model != null)
                    P.Model = model;
                if (quantity != null)
                    P.Size = quantity.Value;
                if (price != null)
                    P.Price = price.Value;

                if (typeOne != null)
                    P.SizeP = typeOne.Value;
                if (typeTry != null)
                    P.SpeedHDD = typeTry.Value;

                list[number] = P;
            }
            else if (list[number] is USB)
            {
                USB P = list[number] as USB;

                if (manufacturerName != null)
                    P.ManufacturerName = manufacturerName;
                if (model != null)
                    P.Model = model;
                if (quantity != null)
                    P.Size = quantity.Value;
                if (price != null)
                    P.Price = price.Value;

                P.SizeUSB = typeOne.Value;
                P.SpeedUSB = typeTry.Value;
            }
            else if (list[number] is DVD)
            {
                DVD P = list[number] as DVD;

                if (manufacturerName != null)
                    P.ManufacturerName = manufacturerName;
                if (model != null)
                    P.Model = model;
                if (quantity != null)
                    P.Size = quantity.Value;
                if (price != null)
                    P.Price = price.Value;

            }
        }
        public void Print(ILog log)
        {
            foreach(Storage i in list)
            {
                i.Print(log);
            }
        }
        public Storage PullElement (int number)
        {
            return list[number];
        }
        public int PullSize()
        {
            return list.Count;
        }
    }
}
