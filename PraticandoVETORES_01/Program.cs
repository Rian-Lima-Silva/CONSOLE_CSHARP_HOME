using System;

namespace PraticandoVETORES_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1º FORMA DE DECLARAÇÃO
            int[] n=new int[5]; //<- vetor inicia em 0 ate 4
            
            //declarando os valores dos vetores
            n[0]=0;
            n[1]=1;
            n[2]=2;
            n[3]=3;
            n[4]=4;

            //2º FORMA DE DECLARAÇÃO
            string[] num=new string[3]{"A","B","C"};//<- Outra forma de DECLARAR OS VALORES DOS VETORES! usando {}

            //3º FORMA DE DECLARAÇÃO
            double[] dec={0.5,1.5,12.45};//<- neste formato o número de elementos colocados dentro do array{} será o limete do vetor

            Console.WriteLine("1º Forma de Declaração de Vetores: {0}",n[2]);
            //Console.WriteLine(n[2]);
            Console.WriteLine("2º Forma de Declaração de Vetores: {0}",num[2]);
           // Console.WriteLine(num[1]);
            Console.WriteLine("3º Forma de Declaração de Vetores: {0}",dec[2]);
           // Console.WriteLine(dec[1]);

            

           /* for(int i=0;i<n.Length;i++)
            {

                Console.WriteLine("1º Posição: {0},2º Posição: {1},3º Posição: {2},4º Posição {3},5º Posição: {4},6º Posição: {5}",
                n[0],n[1],n[2],n[3],n[4]);

            }*/
            



        }
    }
}
