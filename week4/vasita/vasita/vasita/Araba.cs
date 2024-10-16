using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace vasita
{
    internal class Araba
    {

        public Araba(string model) : base(model)
        {
        }

        public override void Tasima()
        {
            Console.WriteLine($"{Model} araba yolcu taşıyor.");


        }
    }
}

