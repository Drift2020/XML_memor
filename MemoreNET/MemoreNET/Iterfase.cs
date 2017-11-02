using System;
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

#region ADD
        void add_usb(string manufacturerName, string model, int quantity, int price)
        {      
            Console.Write("Enter Size USB: ");
            int sizeUSB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter speed USB: ");
            int speedUSB = Convert.ToInt32(Console.ReadLine());

           

            OBJ.Add("USB",manufacturerName,  model,  quantity,  price, sizeUSB, speedUSB);
        }
        void add_dvd(string manufacturerName, string model, int quantity, int price)
        {
           
            Console.Write("Enter spead load: ");
            int speadload = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter spead save: ");
            int speadSave = Convert.ToInt32(Console.ReadLine());

           
            OBJ.Add("DVD",manufacturerName, model, quantity, price, speadload, speadSave);
        }
        void add_hdd(string manufacturerName, string model, int quantity, int price)
        {
          

            Console.Write("Enter size load: ");
            int sizeP = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter spead save: ");
            int speedHDD = Convert.ToInt32(Console.ReadLine());
            
            OBJ.Add("HDD",manufacturerName, model, quantity, price, sizeP, speedHDD);
        }
        void add_stor(int number)
        {
            Console.Write("Enter Name producer: ");
            string manufacturerName = Console.ReadLine();
            Console.Write("Enter Model: ");
            string model = Console.ReadLine();
            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Price: ");
            int price = Convert.ToInt32(Console.ReadLine());

            if(number==1)
            {
                add_usb(manufacturerName, model, quantity, price);
            }
            else if(number==2)
            {
                add_hdd(manufacturerName, model, quantity, price);
            }
            else if(number==3)
            {
                add_dvd(manufacturerName, model, quantity, price);
            }
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
                    add_stor(number);

                    break;
                case 2://HDD

                    Console.Clear();
                    add_stor(number);

                    break;
                case 3://DVD

                    Console.Clear();
                    add_stor(number);

                    break;
            }
        }
#endregion


        void Print_Select_prints()
        {
            Console.WriteLine("1.Print console.");
            Console.WriteLine("2.Print File.");
            Console.WriteLine("3.Print XML.");
            Console.Write("Please enter valu:");
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
            Print_Select_prints();
            int i = 0;
            i=Int32.Parse(Console.ReadLine());
            switch (i) {
                case 1:
                    Console.Clear();
                    OBJ.Print(new ConsoleLog());

                    break;
                case 2:
                    OBJ.Print(new FileLog());
                    break;
                case 3:

                    break;
            }
            Console.WriteLine("\n7.Menu");
        }
        #region EDIT
        void EditStart()
        {
            Console.WriteLine("What  pararam you edits?");
            Console.WriteLine("1.ManufacturerName");
            Console.WriteLine("2.Model");
            Console.WriteLine("3.Quantity");
            Console.WriteLine("4.Price");
        }
        void EditUSB(int poz)
        {

            int number = 0;
            string temp = null;
            
            string manufacturerName = null;
            string model = null;
            int? quantity = null;
            int? price = null;
            int? sizeUSB = null;
            int? speedUSB = null;
            do
            {
                try
                {

                    EditStart();
                    Console.WriteLine("5.SizeUSB");
                    Console.WriteLine("6.SpeedUSB");
                    Console.WriteLine("7.EXIT");
                    number = Convert.ToInt32(Console.ReadLine());
                    switch (number)
                    {
                        case 1:
                            Console.Write("Please enter value: ");
                            manufacturerName = Console.ReadLine();
                           
                            break;
                        case 2:
                            Console.Write("Please enter value: ");
                            model = Console.ReadLine();
                           
                            break;
                        case 3:
                            Console.Write("Please enter value: ");
                            quantity = Convert.ToInt32(Console.ReadLine());
                         
                            break;
                        case 4:
                            Console.Write("Please enter value: ");
                            price = Convert.ToInt32(Console.ReadLine());
                          
                            break;
                        case 5:
                            Console.Write("Please enter value: ");
                            sizeUSB = Convert.ToInt32(Console.ReadLine());
                           
                            break;
                        case 6:
                            Console.Write("Please enter value: ");
                            speedUSB = Convert.ToInt32(Console.ReadLine());
                          
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
                                        OBJ.Edit(number,manufacturerName,model,quantity,price, sizeUSB, speedUSB);
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
        void EditHDD(int poz)
        {

            int? number = null;            
            string manufacturerName=null;
            string model=null;
            int? quantity = null;
            int? price = null;
            int? sizeP = null;
            int? speedHDD = null;

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
                            manufacturerName = Console.ReadLine();
                           
                            break;
                        case 2:
                            Console.Write("Please enter value: ");
                            model = Console.ReadLine();
                           
                            break;
                        case 3:
                            Console.Write("Please enter value: ");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            
                            break;
                        case 4:
                            Console.Write("Please enter value: ");
                            price = Convert.ToInt32(Console.ReadLine());
                           
                            break;
                        case 5:
                            Console.Write("Please enter value: ");
                            sizeP = Convert.ToInt32(Console.ReadLine());
                            
                            break;
                        case 6:
                            Console.Write("Please enter value: ");
                            speedHDD = Convert.ToInt32(Console.ReadLine());
                           
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
                                        OBJ.Edit(poz, manufacturerName, model, quantity, price, sizeP, speedHDD);
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
        void EditDVD(int poz)
        {
           
            string temp = null;

            int? number = null;
            string manufacturerName = null;
            string model = null;
            int? quantity = null;
            int? price = null;
            int? speadload=0;
            int? speadSave=0;

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
                            manufacturerName = Console.ReadLine();
                           
                            break;
                        case 2:
                            Console.Write("Please enter value: ");
                            model = Console.ReadLine();
                          
                            break;
                        case 3:
                            Console.Write("Please enter value: ");
                            quantity = Convert.ToInt32(Console.ReadLine());
                           
                            break;
                        case 4:
                            Console.Write("Please enter value: ");
                            price = Convert.ToInt32(Console.ReadLine());
                           
                            break;
                        case 5:
                            Console.Write("Please enter value: ");
                            speadload = Convert.ToInt32(Console.ReadLine());
                          
                            break;
                        case 6:
                            Console.Write("Please enter value: ");
                            speadSave = Convert.ToInt32(Console.ReadLine());
                          
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
                                        OBJ.Edit(poz, manufacturerName, model, quantity, price, speadload, speadSave);
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

            if (number >= 1 && number < OBJ.PullSize() + 1)
            {
                number--;
                if (OBJ.PullElement(number) is USB)
                {
                    EditUSB(number);
                }
                else if (OBJ.PullElement(number) is HDD)
                {
                    EditHDD(number);
                }
                else if (OBJ.PullElement(number) is DVD)
                {
                    EditDVD(number);
                }
            }
            else
            {
                throw new Exception("\nERROR, this value incoreect.\n");
            }
            
        }
        #endregion
        #region DELL
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

            OBJ.DeliteManufacturerName(Temp);
        }
        void DeliteUSB()
        {
            OBJ.DeliteAllUSB();
        }
        void DeliteHDD()
        {
            OBJ.DeliteAllHDD();
        }
        void DeliteDVD()
        {
            OBJ.DeliteAllDVD();
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
            OBJ.DeliteModel(Temp);
        }
        void DeliteQuantity()
        {
            Console.Clear();
            Console.Write("Please, enter quantity to delite: ");
            int Temp = Convert.ToInt32(Console.ReadLine());
            OBJ.DeliteQuantity(Temp);
        }
        void DelitePrice()
        {
            Console.Clear();
            Console.Write("Please, enter price to delite: ");
            int Temp = Convert.ToInt32(Console.ReadLine());
            OBJ.DelitePrice(Temp);
        }

        void DeliteSpeadLoad()
        {
            Console.Clear();
            Console.Write("Please, enter spead load to delite: ");
            int Temp = Convert.ToInt32(Console.ReadLine());
            OBJ.DeliteSpeadLoad(Temp);
        }
        void DeliteSpeadSave()
        {
            Console.Clear();
            Console.Write("Please, enter spead save to delite: ");
            int Temp = Convert.ToInt32(Console.ReadLine());
            OBJ.DeliteSpeadSave(Temp);
        }

        void DeliteSizeP()
        {
            Console.Clear();
            Console.Write("Please, enter size to delite: ");
            int Temp = Convert.ToInt32(Console.ReadLine());
            OBJ.DeliteSizeP(Temp);
        }
        void DeliteSpeedHDD()
        {
            Console.Clear();
            Console.Write("Please, enter speed HDD to delite: ");
            int Temp = Convert.ToInt32(Console.ReadLine());
            OBJ.DeliteSpeedHDD(Temp);
        }

        void DeliteSizeUSB()
        {
            Console.Clear();
            Console.Write("Please, enter size USB to delite: ");
            int Temp = Convert.ToInt32(Console.ReadLine());
            OBJ.DeliteSizeUSB(Temp);
        }
        void DeliteSpeedUSB()
        {
            Console.Clear();
            Console.Write("Please, enter speed USB to delite: ");
            int Temp = Convert.ToInt32(Console.ReadLine());
            OBJ.DeliteSpeedUSB(Temp);
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
        #endregion
        #region SERCH
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
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            string temp = null;
            int i = 1;
            switch (number)
            {
                case 1:


                    OBJ.SerchType(new USB());
                    break;

                case 2:
                    Console.Write("Please enter value: ");
                    temp = Console.ReadLine();
                    OBJ.SerchManufacturerName(new USB(), temp);
                    break;

                case 3:
                    Console.Write("Please enter value: ");
                    temp = Console.ReadLine();
                    OBJ.SerchModel(new USB(), temp);
                    break;

                case 4:
                    Console.Write("Please enter value: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    OBJ.SerchQuantity(new USB(), number);
                    break;

                case 5:
                    Console.Write("Please enter value: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    OBJ.SerchPrice(new USB(), number);

                    break;

                case 6:
                    Console.Write("Please enter value: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    OBJ.SerchSizeUSB(number);
                    break;

                case 7:
                    Console.Write("Please enter value: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    OBJ.SerchSpeedUSB(number);
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


                    OBJ.SerchType(new HDD());
                    break;

                case 2:
                    Console.Write("Please enter value: ");
                    temp = Console.ReadLine();
                    OBJ.SerchManufacturerName(new HDD(), temp);
                    break;

                case 3:
                    Console.Write("Please enter value: ");
                    temp = Console.ReadLine();
                    OBJ.SerchModel(new HDD(), temp);
                    break;

                case 4:
                    Console.Write("Please enter value: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    OBJ.SerchQuantity(new HDD(), number);
                    break;

                case 5:
                    Console.Write("Please enter value: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    OBJ.SerchPrice(new HDD(), number);
                    break;

                case 6:
                    Console.Write("Please enter value: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    OBJ.SerchSizeP(number);
                    break;

                case 7:
                    Console.Write("Please enter value: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    OBJ.SerchSpeedHDD(number);
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

                    OBJ.SerchType(new DVD());
                    break;

                case 2:
                    Console.Write("Please enter value: ");
                    temp = Console.ReadLine();
                    OBJ.SerchManufacturerName(new DVD(),temp);
                    break;

                case 3:
                    Console.Write("Please enter value: ");
                    temp = Console.ReadLine();
                    OBJ.SerchModel(new DVD(), temp);
                    break;

                case 4:
                    Console.Write("Please enter value: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    OBJ
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
        #endregion
        //public void Save()
        //{
        //    FileStream file = new FileStream("1.txt", FileMode.Create, FileAccess.Write);
        //    BinaryWriter writer = new BinaryWriter(file);
        //    writer.Write(OBJ.Count+1);
        //    foreach (Storage P in OBJ)
        //    {
        //        P.Save(writer);
        //    }
        //    writer.Close();
        //    file.Close();
        //}
        //public void Load()
        //{
        //    FileStream file = new FileStream("1.txt", FileMode.Open, FileAccess.Read);
        //    BinaryReader reader = new BinaryReader(file);
        //    try
        //    {

        //        int size = reader.ReadInt32();
        //        Storage p;
        //        for (int i = 0; i < size - 1 && size > 0; i++)
        //        {
        //            string LOAD = reader.ReadString();
        //            if (String.Compare(LOAD, "USB") == 0)
        //            {
        //                p = new USB();
        //                p.Load(reader, LOAD);
        //                OBJ.Add(p);
        //            }
        //            else if (String.Compare(LOAD, "DVD") == 0)
        //            {
        //                p = new DVD();
        //                p.Load(reader, LOAD);
        //                OBJ.Add(p);
        //            }
        //            else if (String.Compare(LOAD, "HDD") == 0)
        //            {
        //                p = new HDD();
        //                p.Load(reader, LOAD);
        //                OBJ.Add(p);
        //            }
        //        }
        //    }
        //    catch
        //    {

        //    };


        //    reader.Close();
        //    file.Close();
        //}
    }
}
