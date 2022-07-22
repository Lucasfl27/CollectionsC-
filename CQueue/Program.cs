using System;
using System.Collections;
using System.Collections.Generic;

namespace CQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fila");

            Queue<Pessoa> pessoas = new Queue<Pessoa>();

            pessoas.Enqueue(new Pessoa("Aline", "Embu", 22));
            pessoas.Enqueue(new Pessoa("Amanda", "Taboão", 23));
            pessoas.Enqueue(new Pessoa("Jessica", "Santo André", 24));
            pessoas.Enqueue(new Pessoa("Joyce", "São Bernado", 25));
            pessoas.Enqueue(new Pessoa("Bruna", "Diadema", 26));

            Console.WriteLine($"Object primeiro da fila é: {pessoas.Dequeue()}");

            pessoas.Peek();

            Console.WriteLine($"O número de pessoas na fila é: {pessoas.Count}");

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa.ToString());
            }


        }

        public class Pessoa
        {
            public string Nome { get; set; }

            public string Cidade { get; set; }

            public int Idade { get; set; }

        }
        public Pessoa(string nome, string cidade, int idade)
        {
            Nome = nome;
            Cidade = cidade;
            Idade = idade;

        }
    }
    public override string ToString()
    {
        return $"Nome: {Nome} | Cidade: {Cidade} | Idade: {Idade}";
    }

}
