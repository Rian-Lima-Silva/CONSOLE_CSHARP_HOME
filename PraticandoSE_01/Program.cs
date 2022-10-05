using System;

namespace PraticandoSE_01 // IF Uma Variavel   
{
    class Praticando01 
    {  
        static void Main(string[] args)
        {
            int nota,n1;
            string resultado="Reprovado";

            Console.WriteLine("Digite o Primeiro Número:");
            n1 = int.Parse(Console.ReadLine());
        
            nota = n1;

            if(nota>=60)
            {
               resultado = "Aprovado";
            }

            Console.WriteLine("Resultado: {0}",resultado);
        }

        static void L()//LimpaTela
        {
            Console.Clear();
        }
 
    }
}