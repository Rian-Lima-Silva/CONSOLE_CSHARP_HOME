using System;

namespace PraticandoSE_03
{
    class Exemplo03
    {
        static void Main(string[] args)
        {
            int n1,n2,n3,n4;
            int nota=0;
            int media=0;
            string resultado;


            Console.WriteLine("1º SEMESTRE");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2º SEMESTRE");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("3º SEMESTRE");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("4º SEMESTRE");
            n4 = int.Parse(Console.ReadLine());

            nota =n1+n2+n3+n4;
            media=nota/4;

            if(media>=60)
            {
              resultado = "APROVADO!";   
            }
            else if (media>=40)
            {
              resultado = "RECUPERAÇÃO";
            }
            else
            {
                resultado = "REPROVADO";
            }

            Console.Clear();

            Console.Write("\n1º Bimestre:{0}\n\n2º Bimestre:{1}\n\n3º Bimestre:{2}\n\n4º Bimestre:{3}\n\nMédia: {4}\n\nResultado: {5}\n"
            ,n1,n2,n3,n4,media,resultado);

        }
    }
}
