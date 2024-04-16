/* Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
ordem crescente ou decrescente. */

using System;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA, numberB;

            Console.WriteLine("DIGITE VALOR A e B");
            string[] value = Console.ReadLine().Split(' ');

            numberA = int.Parse(value[0]);
            numberB = int.Parse(value[1]);

            if (numberA % numberB == 0 || numberB % numberA == 0)
            {
                Console.WriteLine("SÃO MULTIPLOS");
            }
            else
            {
                Console.WriteLine("NÃO SÃO MULTIPLOS");
            }
        }
    }
}