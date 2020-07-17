using System;

namespace poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            Pessoa objPessoa    = new Pessoa();
            objPessoa.nome      = "NAME";

            Console.WriteLine(objPessoa.nome);
            Console.ReadKey();
        }
        class Alunos
        {
            private void student()
            {
                Console.WriteLine("Alunos:\r\n");
                Console.ReadKey();

                Pessoa objAluno     = new Pessoa();
                objAluno.nome       = "Artur";

                Console.WriteLine(objAluno.nome);
                Console.ReadKey();
            }
        }
        class Professor
        {
            private void teacher()
            {
                Console.WriteLine("Professores:\r\n");
                Console.ReadKey();

                Pessoa objProfessor = new Pessoa();
                objProfessor.nome   = "Mr. Samuels";

                Console.WriteLine(objProfessor.nome);
                Console.ReadKey();
            }
        }
    }
    
}
