using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoreNET
{
    class Start
    {
        public static void Main()
        {
            Iterfase cont=new Iterfase();
            int Number = 0;
           // cont.Load();
            cont.PrintMenu();
           
            do
            {
                try
                {

                    Number = Convert.ToInt32(Console.ReadLine());
                switch (Number)
                {
                    case 1://add

                        Console.Clear();
                        cont.add();
                        Console.Clear();
                        cont.PrintMenu();

                        break;
                    case 2://Dell

                            Console.Clear();

                            cont.Delite();
                            Console.Clear();
                            cont.PrintMenu();

                            break;
                    case 3://print

                        Console.Clear();
                        cont.Print();

                        break;
                    case 4://Edit

                            Console.Clear();
                            cont.Print();
                            Console.WriteLine("What is the number to be changed to be changed ?:");
                            Number = Convert.ToInt32(Console.ReadLine());
                            cont.Edit(Number);
                            Console.Clear();
                            cont.PrintMenu();

                            break;
                    case 5://Search
                        //Console.Clear();
                        //cont.Serch();

                        break;
                    case 6:

                        //cont.Save();
                        return;                  

                    default:
                         Console.Clear();
                         cont.PrintMenu();
                        break;
                    }
                }catch (Exception ex) { Console.Clear(); Console.WriteLine(ex); }
        } while (true);

        }
    }
}
