using System;
using System.Collections.Generic;

namespace Praticando_LIST
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string>carros=new List<string>();
            List<string>carros2=new List<string>();
            List<string>Lixo=new List<string>();
            string[] Vetor2=new string[7];

            /*[.Add] - Adiciona a Lista
            [.AddRange] - Passa os valores de um lista(para outra lista)
            [.Clear] - Limpa os elementosde uma lista
            [.Contains] - Bool para descobrir se tal elemento existe dentro da lista
            [.CopyTo] - Copia os valores de uma Lista para um array
            [.IndexOf] - Mostra o index de um determinado valor*/

            //Método de Adição na lista
            carros.Add("Golf");
            carros.Add("HRV");
            carros.Add("Focus");
            carros.Add("Argo");

            Lixo.Add("1º Item");
            Lixo.Add("2º Item");
            Lixo.Add("3º Item");
            Lixo.Add("4º Item");

            /*Esse elemento será adicionado em carros2 junto dos elementos de carros
            a ordem de adição do codigo é a sequencia da impressão*/

            carros2.Add("LISTA DE CARROS 2\n");//Essa mensagem será a primeria

            //Passando os dados de carros para carros2
            carros2.AddRange(carros);//Os elementos da lista 'carros' virá depois
           
            carros2.Add("Mustang - ultimo item.");//E esse será o ultimo item.

            /*Esse item não será passado para 'carros2', pois ele foi adicionado
            depois do comando [AddRange]*/

            carros.Add("Motocicleta - ultimo item de carros.");


            /*A lista 'Lixo' será limpa todos os item anteriores a esse comoando,
            serão apagados*/
            Lixo.Clear();

            Lixo.Add("Limpeza?");//Esse será impresso pois está depois do [Clear]

            //LEMBRETE: usar FOREACH para impressão, mas usar o FOR tradicional para leitura
            foreach(string c in carros){
                Console.WriteLine("Carro: {0}",c);
            }

            /*[Contains] é usado para verificar se uma lista contém determinado elemento*/

           if(carros.Contains("Gol")){
                Console.WriteLine("\nO Item GOL esta na Lista\n");
            }else{
                Console.WriteLine("\nO Item GOL não encontrado\n");
            }

            if(carros.Contains("Golf")){
                Console.WriteLine("\nO Item GOLF esta na Lista\n");
            }else{
                Console.WriteLine("\nO Item GOLF não encontrado\n");
            }

            foreach(string c in carros2){
                Console.WriteLine("Carro: {0}",c);
            }

            /*'Mustang' não será encontado, pois o elemento está incompleto*/

            if(carros2.Contains("Mustang")){
                Console.WriteLine("\nO Item Mustang esta na Lista\n");
            }else{
                Console.WriteLine("\nO Item Mustang não encontrado\n");
            }

            /* 'Mustang - ultimo item.' agora ele será identificado,pois esta completo*/

            if(carros2.Contains("Mustang - ultimo item.")){
                Console.WriteLine("\nO Item Mustang-2 esta na Lista\n");
            }else{
                Console.WriteLine("\nO Item Mustang-2 não encontrado\n");
            }

            foreach(string c in Lixo){
                Console.WriteLine("LIXO: {0}",c);
            }


            /*[CopyTo] esse comando deve copiar para algo e iniciar de um número designado
            pelo dev.

            Para utilizar o 'Variavel'CopyTo(Array[],index), o index==1 referece a 2º posição
            do array, ou seja, pulando a posição 0.*/

            /*Esse comando tambem pode ser visto como:
            Vetor2[index 0,index 1,index 2,index 3,index 4,index 5,index 6][index]

            Copie os valores da lista 'carros2' para o array Vetor2
            (Vetor2,'1')->'1'= index 1
            */
            carros2.CopyTo(Vetor2,0);//0 == 1º do Array

            foreach(string c in Vetor2){
                Console.WriteLine("VETOR2: {0}",c);
            }

            string T="HRV";//Pesquise esse elemento
            int pos=0;
            int Test;
            pos=carros.IndexOf(T);//pos recebe o index do elemento 'T'=1
            Test=carros.IndexOf("Golf");//número do index do elemento 'Golf'=0
            Console.WriteLine("Carro {0} está na posição {1}",T,pos);//T = [index 1]
            Console.WriteLine("\nCarro {0}",Test);//Test = [index 0]


        }
    }
}