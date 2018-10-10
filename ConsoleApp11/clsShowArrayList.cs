using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class clsShowArrayList
    {
        ArrayList List;

        public clsShowArrayList()
        {
            List = new ArrayList();
        }
        public void CaptureData()
        {
            string chain;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Give the data {0}: ", i + 1);
                chain = Console.ReadLine();
                List.Add(chain);
            }
        }
        public void PrintData()
        {
            foreach (var item in List)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
