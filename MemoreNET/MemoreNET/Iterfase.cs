﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MemoreNET
{
    class Iterfase
    {

        List_of_Storage OBJ;
        public Iterfase()
        {
            OBJ = new List_of_Storage();
        }

        public void selection()
        {
            Console.Clear();
            Console.WriteLine("1.USB\n2.HDD\n3.DVD\n");
        }

        void add_usb()
        {

            Console.Write("Enter Name producer: ");
            string ManufacturerName = Console.ReadLine();
            Console.Write("Enter Model: ");
            string Model = Console.ReadLine();
            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Price");
            int Price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Size USB: ");
            int SizeUSB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter speed USB: ");
            int SpeedUSB = Convert.ToInt32(Console.ReadLine());

            Storage p = new USB("USB", ManufacturerName, Model, quantity, Price, SizeUSB, SpeedUSB);

            OBJ.list.Add(p);
        }
        void add_dvd()
        {
            Console.Write("Enter Name producer: ");
            string ManufacturerName = Console.ReadLine();
            Console.Write("Enter Model: ");
            string Model = Console.ReadLine();
            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Price: ");
            int Price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter spead load: ");
            int Speadload = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter spead save: ");
            int SpeadSave = Convert.ToInt32(Console.ReadLine());

            Storage p = new DVD("DVD", ManufacturerName, Model, quantity, Price, Speadload, SpeadSave);
            OBJ.Add(p);
        }
        void add_hdd()
        {
            Console.Write("Enter Name producer: ");
            string ManufacturerName = Console.ReadLine();
            Console.Write("Enter Model: ");
            string Model = Console.ReadLine();
            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Price: ");
            int Price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter size load: ");
            int SizeP = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter spead save: ");
            int SpeedHDD = Convert.ToInt32(Console.ReadLine());

            Storage p = new HDD("HDD", ManufacturerName, Model, quantity, Price, SizeP, SpeedHDD);
            OBJ.Add(p);
        }
        public void add()
        {
            int number = 0;
            selection();
            number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1://USB

                    Console.Clear();
                    add_usb();

                    break;
                case 2://HDD

                    Console.Clear();
                    add_hdd();

                    break;
                case 3://DVD

                    Console.Clear();
                    add_dvd();

                    break;
            }
        }

        public void PrintMenu()
        {
            Console.WriteLine("1.Add object.");
            Console.WriteLine("2.Delete object.");
            Console.WriteLine("3.Print object.");
            Console.WriteLine("4.Change object.");
            Console.WriteLine("5.Search criteria.");
            Console.WriteLine("6.Exit.");
        }
        public void Print()
        {
            int i = 1;
            foreach (Storage P in OBJ)
            {
                Console.WriteLine(i++);
                P.Print();
                Console.WriteLine();
            }
            Console.WriteLine("7.Menu");
        }

        void EditStart()
        {
            Console.WriteLine("What  pararam you edits?");
            Console.WriteLine("1.ManufacturerName");
            Console.WriteLine("2.Model");
            Console.WriteLine("3.Quantity");
            Console.WriteLine("4.Price");
        }
        void EditUSB(USB P,int poz)
        {
            
            int number = 0;
            string temp = null;
            do
            {
                try { 
                  
                EditStart();
                Console.WriteLine("5.SizeUSB");
                Console.WriteLine("6.SpeedUSB");
                Console.WriteLine("7.EXIT");
                number = Convert.ToInt32(Console.ReadLine());
                switch(number)
                {                                        
                        case 1:
                            Console.Write("Please enter value: ");
                            temp = Console.ReadLine();
                            P.ManufacturerName = temp;
                        break;
                    case 2:
                            Console.Write("Please enter value: ");
                            temp = Console.ReadLine();
                            P.Model = temp;
                        break;
                    case 3:
                            Console.Write("Please enter value: ");
                            number = Convert.ToInt32(Console.ReadLine());
                            P.Size = number;
                        break;
                    case 4:
                            Console.Write("Please enter value: ");
                            number = Convert.ToInt32(Console.ReadLine());
                            P.Size = number;
                        break;
                    case 5:
                            Console.Write("Please enter value: ");
                            number = Convert.ToInt32(Console.ReadLine());
                            P.SizeUSB = number;
                        break;
                    case 6:
                            Console.Write("Please enter value: ");
                            number = Convert.ToInt32(Console.ReadLine());
                            P.SpeedUSB = number;
                            break;
                    case 7:
                            do { 
                            Console.WriteLine("Save edits?\nY/N");
                            temp = Console.ReadLine();
                            switch (temp)
                            {
                                case "Y":
                                case "y":
                                        OBJ[poz] = P;
                                        return;
                                    case "N":
                                case "n":

                                        return;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("This value incorect.");
                                    break;
                            }
                            } while (true);
                            
                }
                    Console.Clear();
                }
                catch (Exception ex) { Console.Clear(); Console.WriteLine(ex); }
               
            } while (true);
        }
        void EditHDD(HDD P, int poz)
        {

            int number = 0;
            string temp = null;
            do
            {
                try
                {

                    EditStart();
                    Console.WriteLine("5.SizeP");
                    Console.WriteLine("6.SpeedHDD");
                    Console.WriteLine("7.EXIT");
                    number = Convert.ToInt32(Console.ReadLine());
                    switch (number)
                    {
                       
                        case 1:
                            Console.Write("Please enter value: ");
                            temp = Console.ReadLine();
                            P.ManufacturerName = temp;
                            break;
                        case 2:
                            Console.Write("Please enter value: ");
                            temp = Console.ReadLine();
                            P.Model = temp;
                            break;
                        case 3:
                            Console.Write("Please enter value: ");
                            number = Convert.ToInt32(Console.ReadLine());
                            P.Size = number;
                            break;
                        case 4:
                            Console.Write("Please enter value: ");
                            number = Convert.ToInt32(Console.ReadLine());
                            P.Size = number;
                            break;
                        case 5:
                            Console.Write("Please enter value: ");
                            number = Convert.ToInt32(Console.ReadLine());
                            P.SizeP = number;
                            break;
                        case 6:
                            Console.Write("Please enter value: ");
                            number = Convert.ToInt32(Console.ReadLine());
                            P.SpeedHDD = number;
                            break;
                        case 7:
                            do
                            {
                                Console.WriteLine("Save edits?\nY/N");
                                temp = Console.ReadLine();
                                switch (temp)
                                {
                                    case "Y":
                                    case "y":
                                        OBJ[poz] = P;
                                        return;
                                    case "N":
                                    case "n":

                                        return;
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("This value incorect.");
                                        break;
                                }
                            } while (true);
                            

                    }
                    Console.Clear();
                }
                catch (Exception ex) { Console.Clear(); Console.WriteLine(ex); }
            } while (true);
        }
        void EditDVD(DVD P, int poz)
        {

            int number = 0;
            string temp = null;
            do
            {
                try
                {

                    EditStart();
                    Console.WriteLine("5.Speadload");
                    Console.WriteLine("6.SpeadSave");
                    Console.WriteLine("7.EXIT");
                    number = Convert.ToInt32(Console.ReadLine());
                    switch (number)
                    {
                        
                        case 1:
                            Console.Write("Please enter value: ");
                            temp = Console.ReadLine();
                            P.ManufacturerName = temp;
                            break;
                        case 2:
                            Console.Write("Please enter value: ");
                            temp = Console.ReadLine();
                            P.Model = temp;
                            break;
                        case 3:
                            Console.Write("Please enter value: ");
                            number = Convert.ToInt32(Console.ReadLine());
                            P.Size = number;
                            break;
                        case 4:
                            Console.Write("Please enter value: ");
                            number = Convert.ToInt32(Console.ReadLine());
                            P.Size = number;
                            break;
                        case 5:
                            Console.Write("Please enter value: ");
                            number = Convert.ToInt32(Console.ReadLine());
                            P.Speadload = number;
                            break;
                        case 6:
                            Console.Write("Please enter value: ");
                            number = Convert.ToInt32(Console.ReadLine());
                            P.SpeadSave = number;
                            break;
                        case 7:
                            do
                            {
                                Console.WriteLine("Save edits?\nY/N");
                                temp = Console.ReadLine();
                                switch (temp)
                                {
                                    case "Y":
                                    case "y":
                                        OBJ[poz] = P;
                                        return;
                                    case "N":
                                    case "n":

                                        return;
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("This value incorect.");
                                        break;
                                }
                            } while (true);
                           

                    }
                    Console.Clear();
                }
                catch (Exception ex) { Console.Clear(); Console.WriteLine(ex); }
            } while (true);
        }
        public void Edit(int number)
        {
            if (number >= 1&&number< OBJ.Count+1)
            {
                number--;
                if(OBJ[number] is USB)
                {
                    USB P = OBJ[number] as USB;
                    Console.Clear();
                    EditUSB(P, number);
                   
                }
                else if(OBJ[number] is HDD)
                {
                    HDD P = OBJ[number] as HDD;
                    Console.Clear();
                    EditHDD(P, number);
                }
                else if (OBJ[number] is DVD)
                {
                    DVD P = OBJ[number] as DVD;
                    Console.Clear();
                    EditDVD(P, number);
                }
            }
            else
            {
                Console.WriteLine("ERROR value");
            }
        }

        void SelectCriterDelite()
        {
            Console.WriteLine("1.Type");
            Console.WriteLine("2.Manufacturer name");
            Console.WriteLine("3.Model");
            Console.WriteLine("4.Quantity");
            Console.WriteLine("5.Price");

            Console.WriteLine("6.Spead load");
            Console.WriteLine("7.Spead save");

            Console.WriteLine("8.Size USB");
            Console.WriteLine("9.Speed USB");

            Console.WriteLine("10.Size");
            Console.WriteLine("11.Speed HDD");

            Console.WriteLine("12.Exit");
        }
        void DeliteManufacturerName()
        {
            Console.Clear();
            Console.Write("Please, enter manufacturer name to delite: ");
            string Temp = Console.ReadLine();
            for (int i = 0; i < OBJ.Count; i++)
            {
                if (String.Compare(OBJ[i].ManufacturerName, Temp) == 0)
                {
                    OBJ.Remove(OBJ[i]);
                    i = 0;
                }
            }
        }
        void DeliteUSB()
        {

            for (int i = 0; i < OBJ.Count; i++)
            {
                if (OBJ[i] is USB)
                {
                    OBJ.Remove(OBJ[i]);
                    i = 0;
                }
            }
        }
        void DeliteHDD()
        {

            for (int i = 0; i < OBJ.Count; i++)
            {
                if (OBJ[i] is HDD)
                {
                    OBJ.Remove(OBJ[i]);
                    i = 0;
                }
            }
        }
        void DeliteDVD()
        {
            for (int i = 0; i < OBJ.Count; i++)
            {
                if (OBJ[i] is DVD)
                {
                    OBJ.Remove(OBJ[i]);
                    i = 0;
                }
            }
        }
        void DeliteType()
        {
            selection();
            int number = 0;
            SelectCriterDelite();
            number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    DeliteUSB();
                    break;
                case 2:
                    DeliteHDD();
                    break;
                case 3:
                    DeliteDVD();
                    break;
            }

        }
        void DeliteModel()
        {
            Console.Clear();
            Console.Write("Please, enter model to delite: ");
            string Temp = Console.ReadLine();
            for (int i = 0; i < OBJ.Count; i++)
            {
                if (String.Compare(OBJ[i].Model, Temp) == 0)
                {
                    OBJ.Remove(OBJ[i]);
                    i = 0;
                }
            }
        }
        void DeliteQuantity()
        {
            Console.Clear();
            Console.Write("Please, enter quantity to delite: ");
            int Temp = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < OBJ.Count; i++)
            {
                if (OBJ[i].Size== Temp)
                {
                    OBJ.Remove(OBJ[i]);
                    i = 0;
                }
            }
        }
        void DelitePrice()
        {
            Console.Clear();
            Console.Write("Please, enter price to delite: ");
            int Temp = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < OBJ.Count; i++)
            {
                if (OBJ[i].Size == Temp)
                {
                    OBJ.Remove(OBJ[i]);
                    i = 0;
                }
            }
        }

        void DeliteSpeadLoad()
        {
            Console.Clear();
            Console.Write("Please, enter spead load to delite: ");
            int Temp = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < OBJ.Count; i++)
            {
                if(OBJ[i] is DVD)
                {
                    DVD P  = OBJ[i] as DVD ;
                    if (P.Speadload == Temp)
                    {
                        OBJ.Remove(OBJ[i]);
                        i = 0;
                    }
                }
                
            }
        }
        void DeliteSpeadSave()
        {
            Console.Clear();
            Console.Write("Please, enter spead save to delite: ");
            int Temp = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < OBJ.Count; i++)
            {
                if (OBJ[i] is DVD)
                {
                    DVD P = OBJ[i] as DVD;
                    if (P.SpeadSave == Temp)
                    {
                        OBJ.Remove(OBJ[i]);
                        i = 0;
                    }
                }

            }
        }

        void DeliteSizeP()
        {
            Console.Clear();
            Console.Write("Please, enter size to delite: ");
            int Temp = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < OBJ.Count; i++)
            {
                if (OBJ[i] is HDD)
                {
                    HDD P = OBJ[i] as HDD;
                    if (P.SizeP == Temp)
                    {
                        OBJ.Remove(OBJ[i]);
                        i = 0;
                    }
                }

            }
        }
        void DeliteSpeedHDD()
        {
            Console.Clear();
            Console.Write("Please, enter speed HDD to delite: ");
            int Temp = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < OBJ.Count; i++)
            {
                if (OBJ[i] is HDD)
                {
                    HDD P = OBJ[i] as HDD;
                    if (P.SizeP == Temp)
                    {
                        OBJ.Remove(OBJ[i]);
                        i = 0;
                    }
                }

            }
        }

        void DeliteSizeUSB()
        {
            Console.Clear();
            Console.Write("Please, enter size USB to delite: ");
            int Temp = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < OBJ.Count; i++)
            {
                if (OBJ[i] is USB)
                {
                    USB P = OBJ[i] as USB;
                    if (P.SizeUSB == Temp)
                    {
                        OBJ.Remove(OBJ[i]);
                        i = 0;
                    }
                }

            }
        }
        void DeliteSpeedUSB()
        {
            Console.Clear();
            Console.Write("Please, enter speed USB to delite: ");
            int Temp = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < OBJ.Count; i++)
            {
                if (OBJ[i] is USB)
                {
                    USB P = OBJ[i] as USB;
                    if (P.SizeUSB == Temp)
                    {
                        OBJ.Remove(OBJ[i]);
                        i = 0;
                    }
                }

            }
        }

        public void Delite()
        {
            int number = 0;
            SelectCriterDelite();
            number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.Clear();
                    DeliteType();
                    
                    break;
                case 2:
                    Console.Clear();
                    DeliteManufacturerName();
                    
                    break;
                case 3:
                    Console.Clear();
                    DeliteModel();
                  
                    break;
                case 4:
                    Console.Clear();
                    DeliteQuantity();
                   
                    break;
                case 5:
                    Console.Clear();
                    DelitePrice();
                   
                    break;
                case 6:
                    Console.Clear();
                    DeliteSpeadLoad();
                  
                    break;
                case 7:
                    Console.Clear();
                    DeliteSpeadSave();
                   
                    break;
                case 8:
                    Console.Clear();
                    DeliteSizeUSB();
                  
                    break;
                case 9:
                    Console.Clear();
                    DeliteSpeedUSB();
                   
                    break;
                case 10:
                    Console.Clear();
                    DeliteSizeP();
                   
                    break;
                case 11:
                    Console.Clear();
                    DeliteSpeedHDD();
                   
                    break;
                case 12:
                 
                    

                    return;
            }
        }

        void SerchStart()
        {
            Console.WriteLine("What  pararam you serch?");
            Console.WriteLine("1.Type");
            Console.WriteLine("2.ManufacturerName");
            Console.WriteLine("3.Model");
            Console.WriteLine("4.Quantity");
            Console.WriteLine("5.Price");
        }      
        void SerchUSB()
        {
           SerchStart();
            Console.WriteLine("6.SizeUSB");
            Console.WriteLine("7.SpeedUSB");
 
            Console.WriteLine("8.Exit");
            Console.Write("Please enter value: ");
            int number=Convert.ToInt32(Console.ReadLine());
            Console.Clear();
          
            string temp = null;
            int i = 1;
            switch (number)
            {
                case 1:
                  
                  
                    foreach (Storage P in OBJ)
                    {
                        if(P is USB)
                        {                      
                            
                                Console.WriteLine(i++);
                                P.Print();
                                Console.WriteLine();
                           
                        }
                    }
                    break;

                case 2:
                    Console.Write("Please enter value: ");
                    temp = Console.ReadLine();
                    foreach (Storage P in OBJ)
                    {
                        if (P is USB)
                        {
                            if (String.Compare(P.ManufacturerName, temp) == 0)
                            {
                                Console.WriteLine(i++);
                                P.Print();
                                Console.WriteLine();
                            }
                        }
                    }
                    break;

                case 3:
                    Console.Write("Please enter value: ");
                    temp = Console.ReadLine();
                    foreach (Storage P in OBJ)
                    {
                        if (P is USB)
                        {
                            if (String.Compare(P.Model, temp) == 0)
                            {
                                Console.WriteLine(i++);
                                P.Print();
                                Console.WriteLine();
                            }
                        }
                    }
                    break;

                case 4:
                    Console.Write("Please enter value: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    foreach (Storage P in OBJ)
                    {
                        if (P is USB)
                        {
                            if (P.Size==number)
                            {
                                Console.WriteLine(i++);
                                P.Print();
                                Console.WriteLine();
                            }
                        }
                    }
                    break;

                case 5:
                    Console.Write("Please enter value: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    foreach (Storage P in OBJ)
                    {
                        if (P is USB)
                        {
                            if (P.Price == number)
                            {
                                Console.WriteLine(i++);
                                P.Print();
                                Console.WriteLine();
                            }
                        }
                    }
                    break;

                case 6:
                    Console.Write("Please enter value: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    foreach (Storage P in OBJ)
                    {
                        if (P is USB)
                        {
                            USB Tem = P as USB;
                            if (Tem.SizeUSB == number)
                            {
                                Console.WriteLine(i++);
                                P.Print();
                                Console.WriteLine();
                            }
                        }
                    }
                    break;

                case 7:
                    Console.Write("Please enter value: ");
                    number = Convert.ToInt32(Console.ReadLine());                 
                    foreach (Storage P in OBJ)
                    {
                        if (P is USB)
                        {
                            USB Tem = P as USB;
                            if (Tem.SpeedUSB == number)
                            {
                                Console.WriteLine(i++);
                                P.Print();
                                Console.WriteLine();
                            }
                        }
                    }
                    break;

              

                case 8:
                    return;

            }
        }
        void SerchHDD()
        {
            SerchStart();
            Console.WriteLine("6.SizeP");
            Console.WriteLine("7.SpeedHDD");

            Console.WriteLine("8.Exit");
            Console.Write("Please enter value: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            string temp = null;
            int i = 1;
            switch (number)
            {
                case 1:
                  

                    foreach (Storage P in OBJ)
                    {
                        if (P is HDD)
                        {
                          
                                Console.WriteLine(i++);
                                P.Print();
                                Console.WriteLine();
                            
                        }
                    }
                    break;

                case 2:
                    Console.Write("Please enter value: ");
                    temp = Console.ReadLine();
                    foreach (Storage P in OBJ)
                    {
                        if (P is HDD)
                        {
                            if (String.Compare(P.ManufacturerName, temp) == 0)
                            {
                                Console.WriteLine(i++);
                                P.Print();
                                Console.WriteLine();
                            }
                        }
                    }
                    break;

                case 3:
                    Console.Write("Please enter value: ");
                    temp = Console.ReadLine();
                    foreach (Storage P in OBJ)
                    {
                        if (P is HDD)
                        {
                            if (String.Compare(P.Model, temp) == 0)
                            {
                                Console.WriteLine(i++);
                                P.Print();
                                Console.WriteLine();
                            }
                        }
                    }
                    break;

                case 4:
                    Console.Write("Please enter value: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    foreach (Storage P in OBJ)
                    {
                        if (P is HDD)
                        {
                            if (P.Size == number)
                            {
                                Console.WriteLine(i++);
                                P.Print();
                                Console.WriteLine();
                            }
                        }
                    }
                    break;

                case 5:
                    Console.Write("Please enter value: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    foreach (Storage P in OBJ)
                    {
                        if (P is HDD)
                        {
                            if (P.Price == number)
                            {
                                Console.WriteLine(i++);
                                P.Print();
                                Console.WriteLine();
                            }
                        }
                    }
                    break;

                case 6:
                    Console.Write("Please enter value: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    foreach (Storage P in OBJ)
                    {
                        if (P is HDD)
                        {
                            HDD Tem = P as HDD;
                            if (Tem.SizeP == number)
                            {
                                Console.WriteLine(i++);
                                P.Print();
                                Console.WriteLine();
                            }
                        }
                    }
                    break;

                case 7:
                    Console.Write("Please enter value: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    foreach (Storage P in OBJ)
                    {
                        if (P is HDD)
                        {
                            HDD Tem = P as HDD;
                            if (Tem.SpeedHDD == number)
                            {
                                Console.WriteLine(i++);
                                P.Print();
                                Console.WriteLine();
                            }
                        }
                    }
                    break;



                case 8:
                    return;

            }
        }
        void SerchDVD()
        {
            SerchStart();
            Console.WriteLine("6.SizeP");
            Console.WriteLine("7.SpeedHDD");

            Console.WriteLine("8.Exit");
            Console.Write("Please enter value: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            string temp = null;
            int i = 1;
            switch (number)
            {
                case 1:
                  

                    foreach (Storage P in OBJ)
                    {
                        if (P is DVD)
                        {
                          
                                Console.WriteLine(i++);
                                P.Print();
                                Console.WriteLine();
                           
                        }
                    }
                    break;

                case 2:
                    Console.Write("Please enter value: ");
                    temp = Console.ReadLine();
                    foreach (Storage P in OBJ)
                    {
                        if (P is DVD)
                        {
                            if (String.Compare(P.ManufacturerName, temp) == 0)
                            {
                                Console.WriteLine(i++);
                                P.Print();
                                Console.WriteLine();
                            }
                        }
                    }
                    break;

                case 3:
                    Console.Write("Please enter value: ");
                    temp = Console.ReadLine();
                    foreach (Storage P in OBJ)
                    {
                        if (P is DVD)
                        {
                            if (String.Compare(P.Model, temp) == 0)
                            {
                                Console.WriteLine(i++);
                                P.Print();
                                Console.WriteLine();
                            }
                        }
                    }
                    break;

                case 4:
                    Console.Write("Please enter value: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    foreach (Storage P in OBJ)
                    {
                        if (P is DVD)
                        {
                            if (P.Size == number)
                            {
                                Console.WriteLine(i++);
                                P.Print();
                                Console.WriteLine();
                            }
                        }
                    }
                    break;

                case 5:
                    Console.Write("Please enter value: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    foreach (Storage P in OBJ)
                    {
                        if (P is DVD)
                        {
                            if (P.Price == number)
                            {
                                Console.WriteLine(i++);
                                P.Print();
                                Console.WriteLine();
                            }
                        }
                    }
                    break;

                case 6:
                    Console.Write("Please enter value: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    foreach (Storage P in OBJ)
                    {
                        if (P is DVD)
                        {
                            DVD Tem = P as DVD;
                            if (Tem.Speadload == number)
                            {
                                Console.WriteLine(i++);
                                P.Print();
                                Console.WriteLine();
                            }
                        }
                    }
                    break;

                case 7:
                    Console.Write("Please enter value: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    foreach (Storage P in OBJ)
                    {
                        if (P is DVD)
                        {
                            DVD Tem = P as DVD;
                            if (Tem.SpeadSave == number)
                            {
                                Console.WriteLine(i++);
                                P.Print();
                                Console.WriteLine();
                            }
                        }
                    }
                    break;



                case 8:
                    return;

            }
        }
        public void Serch()
        {
            selection();
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.Clear();
                    SerchUSB();
                    break;
                case 2:
                    Console.Clear();
                    SerchHDD();
                    break;
                case 3:
                    Console.Clear();
                    SerchDVD();
                    break;
            }
            Console.WriteLine("7.Menu");
        }

        public void Save()
        {
            FileStream file = new FileStream("1.txt", FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(file);
            writer.Write(OBJ.Count+1);
            foreach (Storage P in OBJ)
            {
                P.Save(writer);
            }
            writer.Close();
            file.Close();
        }
        public void Load()
        {
            FileStream file = new FileStream("1.txt", FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(file);
            try
            {

                int size = reader.ReadInt32();
                Storage p;
                for (int i = 0; i < size - 1 && size > 0; i++)
                {
                    string LOAD = reader.ReadString();
                    if (String.Compare(LOAD, "USB") == 0)
                    {
                        p = new USB();
                        p.Load(reader, LOAD);
                        OBJ.Add(p);
                    }
                    else if (String.Compare(LOAD, "DVD") == 0)
                    {
                        p = new DVD();
                        p.Load(reader, LOAD);
                        OBJ.Add(p);
                    }
                    else if (String.Compare(LOAD, "HDD") == 0)
                    {
                        p = new HDD();
                        p.Load(reader, LOAD);
                        OBJ.Add(p);
                    }
                }
            }
            catch
            {

            };


            reader.Close();
            file.Close();
        }
    }
}
