using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI46ProjetosConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programaMedia();

            //exercicio1DeclaracaoVariaveis();

            //Exercicio2ConstanteseOperacoes();

            //Exercicio3OperacoesAritmeticas();

            //Exercicio4PrioridaddosOperadores();

            //Exercicio5CalculodeDesconto();

            //Exercicio6ConversaodeTemperaturas();

              ExerciciosIFsimples();


        }

        private static void ExerciciosIFsimples()
        {
            Console.WriteLine("Digite um número: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int numero));
            {
                if (numero > 0)

                {
                    Console.WriteLine("O numero é positivo. ");
                }
                else
                {
                    Console.WriteLine("O numero não é positivo");

                }
                Console.ReadKey();




            }







        }

        private static void Exercicio6ConversaodeTemperaturas()
        {
            Console.Write("Digite a temperatura em Celsius: ");
            if (double.TryParse(Console.ReadLine(), out double celsius));
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{celsius} graus Celsius equivalem a {fahrenheit} graus Fahrenheit.");

            }
                Console.ReadKey();


        }

        private static void Exercicio5CalculodeDesconto()
        {

            //Exercício 5: Cálculo de Desconto
            //Crie uma variável para o preço de um produto 
            //e aplique um desconto de 10 %.Mostre o valor final.

            double precoOriginal = 100;

            double desconto = precoOriginal * 0.1;

            double precoFinal = precoOriginal - desconto;

            Console.WriteLine("O preço original do produto é: R$" + precoOriginal);
            Console.WriteLine("O desconto é de: R$" + desconto);
            Console.WriteLine("O preço final do produto é: R$" + precoFinal);

            Console.ReadKey();


        }

        private static void Exercicio4PrioridaddosOperadores()
        {
            //Exercício 4: Prioridade dos Operadores
            //Calcule uma expressão:2 + 3×42 / (1−5)2 + 3×42 / (1−5 )

            double resultado = 2 + 3 * Math.Pow(4, 2) / Math.Pow((1 - 5), 2);

            Console.WriteLine("O resultado da expresão é : " + resultado);
             
            Console.ReadLine();





        }

        private static void Exercicio3OperacoesAritmeticas()
        {
            //Exercício 3: Operações Aritméticas
            //Calcular a média aritmética 
            //de três números inteiros

            Console.WriteLine("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            double media = (double)(numero1 + numero2 + numero3) / 3;

            Console.WriteLine("A média dos números é: " + media);

            Console.ReadLine();







        }

        private static void Exercicio2ConstanteseOperacoes()
        {
            //Exercício 2: Constantes e Operações
            //Crie uma constante para o valor de Pi(3.14159) 
            //e use-a para calcular a área de um círculo com raio

            const double PI = 3.14159;
            Console.WriteLine("Digite o raio da circulo: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            double area = PI * raio * raio;

            Console.WriteLine("A area do circulo é: " + area);
            
            Console.ReadLine();





        }

        private static void exercicio1DeclaracaoVariaveis()
        {
            //Exercício 1: Declaração de Variáveis
            //Declarar três variáveis de tipos diferentes
            //(inteiro, real e caractere) e atributos
           
                int Idade = 31;
                double Altura = 1.79;
                char Inicial = 'F';

                Console.WriteLine("idade: " + Idade);
                Console.WriteLine("Altura: " + Altura);
                Console.WriteLine("inicial: " + Inicial);

                Console.ReadKey();
        
        }

        private static void programaMedia()
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

                Console.WriteLine("O aluno teve média final: " + Resultado + "\n");
            }


            Console.ReadKey();
        }
    }
}
