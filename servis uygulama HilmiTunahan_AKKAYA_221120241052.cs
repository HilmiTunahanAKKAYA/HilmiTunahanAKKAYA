using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ogr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("ogremnci adları");
                Console.WriteLine("Veli");
                Console.WriteLine("Muharrem");
                int gelcek = 0;
                Console.WriteLine("kaç ogrenci gelicek");
                gelcek = Convert.ToInt32(Console.ReadLine());




                if (gelcek <= 2)
                {
                    Console.WriteLine("servis 27.11.24 te saat 11.00 da kalkıcak");
                    break;
                }
                else if (gelcek > 2)
                {
                    Console.WriteLine("serviste 2 kisilik yerimiz var");
                }
                
            }
        }
    }
}
