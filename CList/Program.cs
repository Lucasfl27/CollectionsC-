using System;
using System.Collections.Generic;

namespace CList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista Animais");

            List<string> lista = new List<string>();


            lista.Add("Leão");
            lista.Add("Tartaruga");
            lista.Add("Cachorro");
            lista.Add("Gato");

            lista.Insert(1, "Tigre");

            lista.Remove("Gato");

            lista.RemoveAt(1);

            foreach (string nome in lista)
            {
                Console.WriteLine($"aqui estão os animais: {nome}");
            }

        }
    }
}
