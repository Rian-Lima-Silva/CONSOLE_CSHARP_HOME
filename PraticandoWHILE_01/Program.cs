using System;

namespace PraticandoWHILE_01
{
    /*FOR: usado quando souber o número de repitições | WHILE: Quando não souber o número de repetições*/

    class Program
    {
        static void Main(string[] args)
        {
            int[] num=new int[10];
            int i=9;
            

           while(i>0)
            {
                Console.WriteLine("Número de Repetições: {0}",i);
                num[i]=0;
                Console.WriteLine("Teste | {0}",num[i]);
                
                i--;
            }               
                        
        }
    }
}