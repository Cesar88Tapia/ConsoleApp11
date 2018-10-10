using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            clsShowArrayList Show = new clsShowArrayList();
            Show.CaptureData();
            Show.PrintData();
            //clsShowHashTable ShowH;
            //ShowH = new clsShowHashTable();
            //ShowH.AddData();
            //ShowH.PrintData();
            //ShowH.DiscardElement("C001");
            //ShowH.PrintData();
        }
    }
}
