using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           Double peso, altura, result;
            int num;
            Console.WriteLine("Bem Vindo!!! ao teste de IMC");
            Console.WriteLine("Indique seu peso");
            peso=double.Parse (Console.ReadLine ());
            Console.WriteLine("indique sua altura");
            altura = double .Parse (Console .ReadLine());
            result = peso /(altura *altura);
            Console.WriteLine("Seu IMC é:");
            Console.WriteLine(result);
            if (result < 18)
            {
                Console.WriteLine("Você está muinto abaixo do peso");
            }
            if ((result >18)&&(result < 25))
            {
                Console.WriteLine("Você está na média");
            } 
            if ((result >25)&&(result < 30))
            {
                Console.WriteLine("Você está acima do peso");
            }
            if ((result > 30)&&(result < 35))
            {
                Console.WriteLine("Você está com obesidade grau I");
            }
            if ((result >35)&&(result < 40))
            {
                Console.WriteLine("Você está com obesidade grau II");
            }
            if (result > 40)
            {
                Console.Write("Você está com obesidade grau III");
            }
            Console.WriteLine("Pressione 1 para refazer o teste");
            Console.WriteLine("Pressione 2 para sair do teste");
            num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                Console.Clear();
                Console.WriteLine("Bem Vindo!!! ao teste de IMC");
                Console.WriteLine("Indique seu peso");
                peso = double.Parse(Console.ReadLine());
                Console.WriteLine("indique sua altura");
                altura = double.Parse(Console.ReadLine());
                result = peso / (altura * altura);
                Console.WriteLine("Seu IMC é:");
                Console.WriteLine(result);
                if (result < 18)
                {
                    Console.WriteLine("Você está muinto abaixo do peso");
                }
                if ((result > 18) && (result < 25))
                {
                    Console.WriteLine("Você está na média");
                }
                if ((result > 25) && (result < 30))
                {
                    Console.WriteLine("Você está acima do peso");
                }
                if ((result > 30) && (result < 35))
                {
                    Console.WriteLine("Você está com obesidade grau I");
                }
                if ((result > 35) && (result < 40))
                {
                    Console.WriteLine("Você está com obesidade grau II");
                }
                if (result > 40)
                {
                    Console.Write("Você está com obesidade grau III");
                }
                Console.WriteLine("PRESSIONE ENTER PARA SAIR");
                Console.ReadLine();
            }
            if (num == 2 )
            {
                Console.Clear();
            }


        }
    }
}
