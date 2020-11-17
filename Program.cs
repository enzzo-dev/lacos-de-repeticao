using System;

namespace lacos_de_repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            //For = váriavel , condição , incremento
            // for(var i = 0 ; i<10 ; i++){
            //     Console.WriteLine("Oi!");
            // }

            Console.WriteLine("Digite um número inteiro: ");
            int num1 = int.Parse(Console.ReadLine()); //Variável global
            
            int i = 0; //Variável para While padrão
            while( i < 10)
            {   
                i++;
                int resultado = num1 * i;
                System.Console.WriteLine("-----------------------------------");
                Console.WriteLine($"A multiplicação entre {num1} e {i} é {resultado}");
            }//Fim do while
        }
    }
}
