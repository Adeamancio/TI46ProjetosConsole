using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI46ProjetosConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nome;

            decimal Nota1, Nota2, Nota3, Nota4, Resultado;

            {
                Console.WriteLine("Digite seu nome :", "\n");
                Nome = Console.ReadLine();
                Console.WriteLine("Seja bem vindo, ", Nome, "\n");
            }

            {
                Console.WriteLine("Digite as notas do aluno ", Nome, "\n");
                Nota1 = decimal.Parse(Console.ReadLine());
                Nota2 = decimal.Parse(Console.ReadLine());
                Nota3 = decimal.Parse(Console.ReadLine());
                Nota4 = decimal.Parse(Console.ReadLine());
                    
            }

            {
                Resultado = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

                Console.WriteLine("O aluno teve média final: "+Resultado+"\n");
            }


            Console.ReadKey();


            
                 



        }
    }
}
