using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partialclass
{
    class Program
    {
        public partial class record
        {
            private int h;
            private int w;
            public record(int h,int w)
            {
                this.h = h;
                this.w = w;
            }
        }
        public partial class record
        {
            public void printrecord()
            {
                Console.WriteLine("Width :", w);
                Console.WriteLine("Height :", h);
            }
        }
        static void Main(string[] args)
        {
            record my = new record(10,20);
            my.printrecord();
            Console.ReadLine();
        }
    }
}
