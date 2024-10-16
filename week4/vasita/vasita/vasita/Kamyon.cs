using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace vasita
{
    internal class Kamyon : Vasita

    {
        public Kamyon(string model) : base(model)
        {
        }

        public override void Tasima()
        {
            Console.WriteLine($"{Model} kamyon yük taşıyor.");
        }

    }

