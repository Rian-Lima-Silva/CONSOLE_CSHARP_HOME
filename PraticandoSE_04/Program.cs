using System;

namespace PraticandoSE_04
{
    class Exemplo_SE_Aninhado
    {
        static void Main (string[] args)
        {
            int n1,n2,n3,n4;
            int media;
            string resultado;

            Console.Write("1º Bimestre: ");
            n1 = int.Parse(Console.ReadLine());
            
            Console.Write("2º Bimestre: ");
            n2 = int.Parse(Console.ReadLine());
            
            Console.Write("3º Bimestre: ");
            n3 = int.Parse(Console.ReadLine());
            
            Console.Write("4º Bimestre: ");
            n4 = int.Parse(Console.ReadLine());
            
            media = n1+n2+n3+n4;
            media =media/4;

            Console.Clear();

            if(media>=60)
            {
                if(media>=90)
                {
                    if(media>=95)
                    {
                        resultado ="BOLSA DE ENSINO SUPERIOR!!!";
                    }
                    else
                    {
                        resultado = "APROVADO COM LOUVOR!!";
                    }
                }
                else
                {
                    if(media>=80)
                    {
                        resultado = "APROVADO COM MERITO!";
                    }
                    else
                    {
                        resultado = "APROVADO.";
                    }
                }
            }
            else
            {
                if(media>=50)
                {
                    resultado = "REPROVADO POR FALTA DE EMPENHO!";
                    
                }
                else
                {
                  
                  if(media>40)
                    {
                        resultado ="REPROVADO PELA MAL COMPORTAMENTO!!";
                    }
                    else
                    {
                        
                        resultado = "REPROVADO, É NECESSARIO CHAMAR OS PAIS!!!";
                    }
                }
            }

            Console.WriteLine("\n1º Bimestre: {0}\n\n2º Bimestre: {1}\n\n3º Bimestre: {2}\n\n4º Bimestre: {3}\n\nMédia:{4}\n\nResultado Final: {5}\n",
            n1,n2,n3,n4,media,resultado);

 


        }
    }
}
