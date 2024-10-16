using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace vasita
{
    internal class Vasita
    { 
        public string Model { get; set; }

    public Vasita(string model)
    {
        Model = model;
    }

    // Sanal (virtual) metot
    public virtual void Tasima()
    {
        Console.WriteLine($"{Model} vasıta bir şey taşıyor.");


    }
