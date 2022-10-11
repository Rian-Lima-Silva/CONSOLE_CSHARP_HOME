using System;
namespace PraticandoMATRIZES_01
{
    class Study_01
    {
        static void Main(string[] args)
        {
            string[,] nome=new string[3,2];
            
            //*1º LINHA [0,?]*/nome[0,0]="Rian";nome[0,1]="Lima";
            //*2º LINHA [1,?]*/ nome[1,0]="Nome - 1,0";nome[1,1]="Sobrenome - 1,1";
           //*3º LINHA [2,?]*/nome[2,0]="Nome - 2,0";nome[2,1]="Sobrenome - 2,1";
            
            

            for(int L=0;L<3;L++)//LINHAS
            {
                for(int C=0;C<2;C++)//COLUNAS
                {
                    Console.Clear();

                    if(C==0){

                        Console.WriteLine("Digite o seu nome:");
                        nome[L,C]= Console.ReadLine();
                        
                    }
                    else
                    {
                        Console.WriteLine("Digite o seu sobrenome:");
                        nome[L,C]= Console.ReadLine();
                    }                   
                }
                
            }
            Console.Clear();
            
            for(int i=0;i<3;i++)
            {                 
               Console.WriteLine("Nome Completo: {0} {1}\n",nome[i,0],nome[i,1]);                                               
            }
            

        }
    }
}

