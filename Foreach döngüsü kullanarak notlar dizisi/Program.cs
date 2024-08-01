using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_döngüsü_kullanarak_notlar_dizisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] notlar = { 100, 50, 85, 90, 25, 45, 37, 75, 87 };

            foreach(int not in notlar)
            {
                if (not >= 50) 
                {
                    Console.WriteLine(not + "Notun İyi ");
                }
                else
                {
                    Console.WriteLine(not + "Notun Kötü");
                }
                
            }
            Console.ReadLine();
        }
    }
}
