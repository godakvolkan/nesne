using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inheritance;

namespace inheritance
{
    internal class Hayvan
    {

        public string Name { get; set; }
        public Hayvan(string name)
        {
            Name = name;
        }

        public virtual void Voice()
        {
            Console.WriteLine($"{Name} bir ses çıkardı");
        }


    }
}
