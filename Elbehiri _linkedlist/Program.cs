using Elbehiri_linkedlist;
using System.Collections.Generic;

namespace Elbehiri_linkedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList MyList = new MyLinkedList();

            int Num = 0;
            string item;
            bool chk = false;
            do
            {
                Console.WriteLine("*** Main List ***");
                Console.WriteLine("");
                Console.WriteLine("(1) Add item");
                Console.WriteLine("(2) Remove Item");
                Console.WriteLine("(3) Search for Item");
                Console.WriteLine("(4) Print All Nodes");
                Console.WriteLine("(0) EXIT");
                Console.WriteLine("===================");
                Console.Write("Choose from list's number : ");
                try
                {
                    Num = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Write("Try Other Number :");
                    Num = Convert.ToInt32(Console.ReadLine());

                }



                switch (Num)
                {

                    case 1:
                        Console.Write("Add item : ");
                        item = Console.ReadLine();
                        MyList.Add(item);
                        break;

                    case 2:
                        Console.Write("Remove item : ");
                        item = Console.ReadLine();
                        MyList.Remove(item);
                        break;
                    case 3:
                        Console.Write("Serch Item : ");
                        item = Console.ReadLine();
                        chk = MyList.Search(item);
                        if (chk == true)
                        {
                            Console.WriteLine("This name is found ");
                        }
                        else
                        {
                            Console.WriteLine("This name is not found");
                        }
                        break;
                    case 4:
                        MyList.PrintList();

                        break;
                    case 5:

                        break;

                }

            } while (Num != 0);

        }

    }
}