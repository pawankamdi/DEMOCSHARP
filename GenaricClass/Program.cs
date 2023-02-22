using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaricClass
{
    class Program
    {
        //class datastore<T>
        //{
        //    public string data {get;set;}
        //}

      class keystore<tkey,tstore>
        {
            public string key { get; set; }
        public int store { get; set; }
        }


        static void Main(string[] args)
        {
            //datastore<string> dt = new datastore<string>();
            //dt.data = "Hello pawan";
            //Console.WriteLine(dt.data);

            keystore<string, int> ks = new keystore<string, int>();
            ks.key = "pawan";
            ks.store = 100;
            Console.WriteLine(ks.key + " " + ks.store);
            Console.ReadLine();
        
        }
    }
}
