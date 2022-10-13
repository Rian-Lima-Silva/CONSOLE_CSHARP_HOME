using System;

namespace PraticandoLOGIN_01
{
    public class Program
    {
        static void Main()
        {   char menu;
            string[,] T=new string[1,2];
                        
            inicio:
            Console.Clear();
            Console.WriteLine("TELA DE LOGIN\n");
            Console.WriteLine("1 - Cadastro");
            Console.WriteLine("2 - Login");
            
            Console.WriteLine("Escolha uma das opções acima?");
            menu=char.Parse(Console.ReadLine());

            switch(menu)
            {
                case '1':
                    T[0,0]=NomeCad();
                    T[0,1]=SenhaCad();
                    goto inicio;                                       
                  

                  
                case '2':
                    Console.WriteLine("nome: {0} \nsenha:{1}",T[0,0],T[0,1]);
                    Console.WriteLine(ReG(T));
                  break;
                default:
                break;

            }
        }

        static string NomeCad()
        {
           string nomeCad;
            Console.WriteLine("Cadastre NOME:");
            nomeCad=Console.ReadLine();
            

            return nomeCad;            
        }
        static string SenhaCad()
        {
           
            string senhaCad;
            Console.WriteLine("Cadastre SENHA:");
            senhaCad=Console.ReadLine();

            
            return senhaCad;
            
        }

        static string ReG(string[,] T)
        {
            string nome,senha; 
            Console.WriteLine("NOME:");
            nome=Console.ReadLine();
            Console.WriteLine("SENHA:");
            senha=Console.ReadLine();

            if(nome==T[0,0] && senha==T[0,1])
            {
                return "Conectado";
            }
            else
            {
                return "Falha";
            }

        }        
    }
}
