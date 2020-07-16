using System;

namespace poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\r\n");
            Console.ReadKey();

            Pessoa objPessoa = new Pessoa();
            objPessoa.nome = "Artur";

            Console.WriteLine(objPessoa.nome);
            Console.ReadKey();
        }
    }
}
