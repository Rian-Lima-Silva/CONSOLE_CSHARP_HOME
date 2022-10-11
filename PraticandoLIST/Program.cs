using System;
using System.Collections.Generic;

namespace PraticandoLIST
{
    class Aula56
    {
        static void Main(string[] args)
        {
            LinkedList<string> T=new LinkedList<string>();
            //Métodos de Adição
            /*AddFirst: Adiciona ao inicio da lista
              AddLast: Adicione ao Fim da lista
              AddAfter: Adiciona depois de um linha determinada
              FindBefore: Adicione antes de uma linha*/

            //Elementos do First serão sempre os primeiros dentro do LinkedList
            T.AddFirst("Carros");/*4º A ser escrito por causa do first*/
            T.AddFirst("Moto");/*3º A ser escrito por causa do first*/
            T.AddFirst("Avião");/*2º A ser escrito por causa do first*/
            T.AddFirst("Barco");/*1º A ser escrito por causa do first*/


            //AddLast: Elementos serão sempre o ultimo
            T.AddLast("Este será o ultimo");/*AddLast: Sempre será no fim*/
            T.AddLast("Este será o Verdadeiro ultimo");/*AddLast: Sempre será no fim*/

            LinkedListNode<string>no;
            no=T.FindLast("Barco");//Encontra o elemento 4
            T.AddAfter(no,"Patinete");//Depois do Elemento 4
            //no=T.FindLast("Moto");//Encontra o Elemento 2
            no=T.FindLast("Moto").Next;//Encontre moto, e pegue o elemento depois
            T.AddBefore(no,"Bicicleta");//Antes do Elemento 2

            //T.Clear(); <- Limpar todos os dados
            //T.Find(); <- Pode encontrar um elemento predeterminado
            if(T.Find("Carros")==null)
            {
                Console.WriteLine("Elemento NÃO ENCONTRADO");
                
            }
            else{
                Console.WriteLine("ELEMENTO ENCONTRADO");
            }

            //T.Remove("Barco"); <- remove determinado elemento

            //T.RemoveFirst(); <- Remove o primeiro elemento da lista
            //T.RemoveLast(); <- Remove o ultimo Elemento da lista
            
            foreach(string n in T){
                Console.WriteLine("Transporte: {0}",n);

            }

        }
    }
}
