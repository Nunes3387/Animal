using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.EmitirSom(); 

            Cachorro cachorro = new Cachorro();
            cachorro.EmitirSom(); 

            Gato gato = new Gato();
            gato.EmitirSom(); 

            Console.ReadKey();

        }
    }
}
