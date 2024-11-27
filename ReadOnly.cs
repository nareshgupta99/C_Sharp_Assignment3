using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class ReadOnly
    {
        readonly int a;
        ReadOnly(int a)
        {
            this.a = a;
            Console.ReadLine();
        }
        
        static void Main(String[] args)
        {
            ReadOnly r = new ReadOnly(20);

        }
    }
}
