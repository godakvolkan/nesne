using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vasita
{
    internal class Program
    {

        static void Main(string[] args)
           
        {
            Vasita araba = new Araba("Toyota Corolla");
            Vasita motor = new Motor("Yamaha YZF");
            Vasita kamyon = new Kamyon("BMC");

            // Polimorfizm kullanımı
            Vasita[] vasitalar = { araba, motor, kamyon };

            foreach (Vasita vasita in vasitalar)
            {
                vasita.Tasima();
            }





        }
