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

                if (typeOne != null)
                    P.SizeUSB = typeOne.Value;
                if (typeTry != null)
                    P.SpeedUSB = typeTry.Value;

                list[number] = P;
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

                if (typeOne != null)
                    P.Speadload = typeOne.Value;
                if (typeTry != null)
                    P.SpeadSave = typeTry.Value;

                list[number] = P;
            }
        }
        #region DELL
        public void DeliteManufacturerName(string manufacturer)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (String.Compare(list[i].ManufacturerName, manufacturer) == 0)
                {
                    list.Remove(list[i]);
                    i = 0;
                }
            }
        }
        public void DeliteAllUSB()
        {

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is USB)
                {
                    list.Remove(list[i]);
                    i = 0;
                }
            }
        }
        public void DeliteAllHDD()
        {

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is HDD)
                {
                    list.Remove(list[i]);
                    i = 0;
                }
            }
        }
        public void DeliteAllDVD()
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is DVD)
                {
                    list.Remove(list[i]);
                    i = 0;
                }
            }
        }
        public void DeliteModel(string model)
        {
           
            for (int i = 0; i < list.Count; i++)
            {
                if (String.Compare(list[i].Model, model) == 0)
                {
                    list.Remove(list[i]);
                    i = 0;
                }
            }
        }
        public void DeliteQuantity(int quantity)
        {         
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Size == quantity)
                {
                    list.Remove(list[i]);
                    i = 0;
                }
            }
        }
        public void DelitePrice(int price)
        {         
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Size == price)
                {
                    list.Remove(list[i]);
                    i = 0;
                }
            }
        }
        public void DeliteSpeadLoad(int speadLoad)
        {         
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is DVD)
                {
                    DVD P = list[i] as DVD;
                    if (P.Speadload == speadLoad)
                    {
                        list.Remove(list[i]);
                        i = 0;
                    }
                }

            }
        }
        public void DeliteSpeadSave(int speadSave)
        {          
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is DVD)
                {
                    DVD P = list[i] as DVD;
                    if (P.SpeadSave == speadSave)
                    {
                        list.Remove(list[i]);
                        i = 0;
                    }
                }

            }
        }
        public void DeliteSizeP(int sizeP)
        {         
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is HDD)
                {
                    HDD P = list[i] as HDD;
                    if (P.SizeP == sizeP)
                    {
                        list.Remove(list[i]);
                        i = 0;
                    }
                }
            }
        }
        public void DeliteSpeedHDD(int SpeedHDD)
        {
           
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is HDD)
                {
                    HDD P = list[i] as HDD;
                    if (P.SpeedHDD == SpeedHDD)
                    {
                        list.Remove(list[i]);
                        i = 0;
                    }
                }

            }
        }
        public void DeliteSizeUSB(int sizeUSB)
        {            
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is USB)
                {
                    USB P = list[i] as USB;
                    if (P.SizeUSB == sizeUSB)
                    {
                        list.Remove(list[i]);
                        i = 0;
                    }
                }
            }
        }
        public void DeliteSpeedUSB(int speedUSB)
        {           
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is USB)
                {
                    USB P = list[i] as USB;
                    if (P.SizeUSB == speedUSB)
                    {
                        list.Remove(list[i]);
                        i = 0;
                    }
                }

            }
        }


        #endregion
        #region SERCH
        public void SerchType(Storage obj)
        {
            foreach (Storage P in list)
            {
                if (obj is USB && P is USB)
                {                   
                     P.Print(new ConsoleLog());                 
                }
                else if (obj is DVD && P is DVD)
                {
                    P.Print(new ConsoleLog());
                }
                else if(obj is HDD && P is HDD)
                {
                    P.Print(new ConsoleLog());
                }
            }           
        }
        public void SerchManufacturerName(Storage obj,string manufacturerName)
        {
            foreach (Storage P in list)
            {
                if (P is USB && obj is USB)
                {
                    if (String.Compare(P.ManufacturerName, manufacturerName) == 0)
                    {
                     
                        P.Print(new ConsoleLog());
                       
                    }
                }
                else if (P is DVD && obj is DVD)
                {
                    if (String.Compare(P.ManufacturerName, manufacturerName) == 0)
                    {

                        P.Print(new ConsoleLog());

                    }
                }
                else if(P is HDD && obj is HDD)
                {
                    if (String.Compare(P.ManufacturerName, manufacturerName) == 0)
                    {

                        P.Print(new ConsoleLog());

                    }
                }
            }
        }
        public void SerchModel(Storage obj, string model)
        {
            foreach (Storage P in list)
            {
                if (P is USB && obj is USB)
                {
                    if (String.Compare(P.Model, model) == 0)
                    {                     
                        P.Print(new ConsoleLog());                        
                    }
                }
                if (P is DVD && obj is DVD)
                {
                    if (String.Compare(P.Model, model) == 0)
                    {                      
                        P.Print(new ConsoleLog());                      
                    }
                }
                if (P is HDD && obj is HDD)
                {
                    if (String.Compare(P.Model, model) == 0)
                    {                      
                        P.Print(new ConsoleLog());                      
                    }
                }
            }
        }
        public void SerchQuantity(Storage obj, int quantity)
        {
            foreach (Storage P in list)
            {
                if (P is USB && obj is USB)
                {
                    if (P.Size == quantity)
                    {                      
                        P.Print(new ConsoleLog());                      
                    }
                }
                else if (P is DVD && obj is DVD)
                {
                    if (P.Size == quantity)
                    {                       
                        P.Print(new ConsoleLog());                      
                    }
                }
                else if(P is HDD && obj is HDD)
                {
                    if (P.Size == quantity)
                    {                       
                        P.Print(new ConsoleLog());                      
                    }
                }
            }
        }
        public void SerchPrice(Storage obj, int price)
        {
            foreach (Storage P in list)
            {
                if (P is USB && obj is USB)
                {
                    if (P.Price == price)
                    {
                        
                        P.Print(new ConsoleLog());
                       
                    }
                }
                else if (P is DVD && obj is DVD)
                {
                    if (P.Price == price)
                    {

                        P.Print(new ConsoleLog());

                    }
                }
                else if (P is HDD && obj is HDD)
                {
                    if (P.Price == price)
                    {

                        P.Print(new ConsoleLog());

                    }
                }
            }
        }
        
        public void SerchSizeUSB(int sizeUSB)
        {
            foreach (Storage P in list)
            {
                if (P is USB)
                {
                    USB Tem = P as USB;
                    if (Tem.SizeUSB == sizeUSB)
                    {
                       
                        P.Print(new ConsoleLog());
                      
                    }
                }
            }
        }
        public void SerchSpeedUSB(int SpeedUSB)
        {
            foreach (Storage P in list)
            {
                if (P is USB)
                {
                    USB Tem = P as USB;
                    if (Tem.SpeedUSB == SpeedUSB)
                    {
                       
                        P.Print(new ConsoleLog());
                       
                    }
                }
            }
        }

        public void SerchSizeP(int SizeP)
        {
            foreach (Storage P in list)
            {
                if (P is HDD)
                {
                    HDD Tem = P as HDD;
                    if (Tem.SizeP == SizeP)
                    {                     
                        P.Print(new ConsoleLog());                      
                    }
                }
            }
        }
        public void SerchSpeedHDD(int speedHDD)
        {
            foreach (Storage P in list)
            {
                if (P is HDD)
                {
                    HDD Tem = P as HDD;
                    if (Tem.SpeedHDD == speedHDD)
                    {
                        P.Print(new ConsoleLog());
                    }
                }
            }
        }

        public void SerchSpeadload(int Speadload)
        {
            foreach (Storage P in list)
            {
                if (P is DVD)
                {
                    DVD Tem = P as DVD;
                    if (Tem.Speadload == Speadload)
                    {
                      
                        P.Print(new ConsoleLog());
                       
                    }
                }
            }
        }
        public void SerchSpeadsave(int Speadsave)
        {
            foreach (Storage P in list)
            {
                if (P is DVD)
                {
                    DVD Tem = P as DVD;
                    if (Tem.SpeadSave == Speadsave)
                    {
                        P.Print(new ConsoleLog());
                    }
                }
            }
        }

        #endregion

        public void Save(ISerialize log)
        {
            log.Save(list);
        }

        public void Load(ISerialize log)
        {
            list = log.Load();
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
