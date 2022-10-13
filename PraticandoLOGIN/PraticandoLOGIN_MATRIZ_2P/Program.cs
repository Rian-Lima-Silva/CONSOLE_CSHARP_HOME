using System;

namespace PraticandoLOGIN_MATRIZ_2P
{
    public class Program
    {
        static void Main()
        {   char menu;
            string[,] T=new string[2,2];
            string[] Test=new string [2];
                      
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
                    NomeCad(T);
                    
                    goto inicio;                                       
                  

                  
                case '2':
                    Console.WriteLine("nome: {0} \nsenha:{1}",T[0,0],T[0,1]);
                    Console.WriteLine(ReG(T));
                  break;
                default:
                break;

            }
        }

        static string[,] NomeCad(string[,] T)
        {
           string nomeCad,senhaCad,final;


           for(int i=0;i<4;i++)
           {
                for(int c=0;c<2;c++)
                {
                
                    Console.WriteLine("Cadastre NOME:");
                    T[i,c]=nomeCad=Console.ReadLine();
                    
                    c=c+1;

                    Console.WriteLine("Cadastre SENHA:");
                    T[i,c]=senhaCad=Console.ReadLine();

                    Console.WriteLine("Seu cadastro esta completo, deseja volta para o menu? S/N");
                    final=Console.ReadLine();

                    switch(final)
                    {
                        case "S":
                        case "s":
                            
                        return T;  
                        
                        
                        
                        case "N":
                        case "n":
                            
                            break;
                            
                        default:
                        return T;
                                    
                    }
                
                }

           }

           
                

            return T;
                       
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

