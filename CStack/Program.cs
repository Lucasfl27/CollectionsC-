using System;
using System.Collections;
using System.Collections.Generic;

namespace CStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilha de Livros!");

            Stack<string> stack = new Stack<string>();

            stack.Push("Livro Azul");
            stack.Push("Livro Verde");
            stack.Push("Livro Amarelo");

            Console.WriteLine($"Primeiro livro do topo: {stack.Peek()}");

            stack.Pop();

            Console.WriteLine($"Quantidade de Livros é : {stack.Count}");

            foreach ()
        }
    }
}
