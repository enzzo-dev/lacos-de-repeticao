using System;

namespace lacos_de_repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int num1 = int.Parse(Console.ReadLine()); //Variável global
            
            int i = 0; //Variável para While padrão
            while( i < 10)
            {   
                 i++;
                 int resultado = num1 * i;
                 System.Console.WriteLine("------------------------------");
                 Console.WriteLine(resultado);
            }//Fim do while
        }
    }
}
