using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dersten_geçme_kalma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int vize;
            Console.WriteLine("Vize notunuzu giriniz.");
            vize=Convert.ToInt32(Console.ReadLine());

            int final;
            Console.WriteLine("final notunuzu giriniz.");
            final=Convert.ToInt32(Console.ReadLine());

            float sonuc = vize * 0.4f + final * 0.6f;


            if (sonuc >= 80)
                Console.WriteLine("Notunuz:A+");

            else if (60<=sonuc && sonuc<80)
                Console.WriteLine("Notunuz:A");
            
            else if(sonuc>=40 && sonuc<60)
                Console.WriteLine("Notunuz: B+");

            else
                Console.WriteLine("Notunuz:F"+ " "+ "'KALDINIZ'");
            Console.ReadKey();

                   
               
        }
    }
}
