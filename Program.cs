using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar número um
            Console.WriteLine("Olá, vamos começar! ");
            Console.WriteLine("Informe o primeiro número: ");

            decimal primeiroNumero;

            primeiroNumero = decimal.Parse(Console.ReadLine());

            // Solicita número dois

            Console.WriteLine("Informe o segundo número: ");

            decimal segundoNumero;

            segundoNumero = decimal.Parse(Console.ReadLine());

            // Solicitar operação desejada (+, -, /, *)

            Console.WriteLine("Muito bom! O próximo passo será escolher a operação desejada. ");
            Console.WriteLine("Você pode escolher entre adição, subtração, divisão ou multiplicação. ");
            Console.WriteLine("Agora, informe a operação desejada ");

            string operacaoEscolhida;

            operacaoEscolhida = Console.ReadLine();

            // Calcular os resultados com base na operação escolhida pelo usuário

            decimal resultado = 0;

            if (operacaoEscolhida == "adição")
                resultado = primeiroNumero + segundoNumero;
            else if (operacaoEscolhida == "subtração")
                resultado = primeiroNumero - segundoNumero;
            else if (operacaoEscolhida == "multiplicação")
                resultado = primeiroNumero * segundoNumero;
            else if (operacaoEscolhida == "divisão")
            {
                if (segundoNumero == 0)
                    Console.WriteLine("Não é possivel dividir um número por zero. ");
                else
                    resultado = primeiroNumero / segundoNumero;
            }


            // Mostrar o resultado e a operação desejada

            Console.WriteLine("Você escolheu a operação: " + operacaoEscolhida);
            Console.WriteLine("O resultado da operação é: " + resultado);






        }
    }
}
