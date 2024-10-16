using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Kedi : Hayvan
    {
        
        
            // Kedi yapıcısında name parametresini sağlayın
            public Kedi(string name) : base(name)
            {
            }

            public void Meow()
            {
                Console.WriteLine($"{Name} miyavlıyor.");
            }



        
    }
}
