using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace vasita
{
    internal class Motor

    {
        public Motor(string model) : base(model)
        {
        }

        public override void Tasima()
        {
            Console.WriteLine($"{Model} motor hızlı paket taşıyor.");


        }
    }
}
