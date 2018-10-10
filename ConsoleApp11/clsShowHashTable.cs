using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp11
{
    class clsShowHashTable
    {
        Hashtable Table;

        public clsShowHashTable()
        {
            Table = new Hashtable();
        }

        public void AddData()
        {
            Table.Add("C001", "Product 1");
            Table.Add("B123", "Product 3");
            Table.Add("J452", "Product 4");
            Table.Add("z099", "Product 5");
        }
        public void PrintData()
        {
            Console.WriteLine("{0} elements exist, give me the pin of the product:", Table.Count);
            string chain = Console.ReadLine();
            if (Table[chain] == null)
                Console.WriteLine("Element does not exist");
            else
            {
                Console.WriteLine("The element found is:");
                Console.WriteLine(Table[chain]);
            }
            Console.ReadKey();
        }

        public void DiscardElement(string key)
        {
            Table.Remove(key);
        }
    }
}
