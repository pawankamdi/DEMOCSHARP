using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMOCSHARP
{
    class Program
    {
        public abstract class bike
        {
            public abstract void brake();
        }
        public class motorbike : bike
        {
            public override void brake()
            {
                Console.WriteLine("This is motobike brake");
            }
        }

        static void Main(string[] args)
        {
            motorbike m = new motorbike();
            m.brake();
            Console.ReadLine();
        }
    }
}
