using System;

namespace Aula25_PassagemPorRef
{
    class Aula_25
    {
        static void Main(string[] args)
        {   
            /*[OBJETIVO]
                Praticando o [ref] nos metodos, mesmo sendo um método void,
                o valor de numero foi alterado e retornado.

            */

            //PASSAGEM POR VALOR
            
            int num=2;// num foi incializado com 2
            Aumento(num);// depois passou para o metodo [Aumento();]
            Console.WriteLine("Aumento: {0}\n",num);// Porém, seu valor continuou sendo 2

            /*Isso ocorreu, pois o metodo void não retorna valor,
             mesmo que a variavel [num] esteja sendo passada para o metodo,
             ela não será retorna.

             Nessa passagem o valor de num é duplicado na memoria,
             apenas o valor declarado em [Main] será usado na impressão.
            */

            //PASSAGEM POR REFERÊNCIA
            
            int numero=2;// numero foi inicializada com 2
            AumentoRef(ref numero);// depois passou para o método [AumentoRef();]
            Console.WriteLine("AumentoRef: {0}\n",numero);//Seu valor foi dobrado como deveria

            /*Nesse caso, houve uso de [ref], a passagem por referência usa
            endereço de memoria da variavel como argumento, assim ela altera o valor da variavel
            passada.              
            */
            

        }

        static void Aumento(int valor)//PASSAGEM POR VALOR
        {
            valor*=2;
        }

        static void AumentoRef(ref int valor)//PASSAGEM POR REFERÊNCIA
        {
            valor*=2;
        }

        
    }
}