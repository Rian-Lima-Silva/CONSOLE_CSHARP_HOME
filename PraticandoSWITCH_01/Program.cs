using System;

namespace PraticandoSWITCH_01
{
    class Treinando_01
    {
        static void Main(string[] args)
        {
            int tempo=0;
            char escolha=' ';

            Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
            Console.WriteLine("Escola o transporte:\n [a] Avião \n [c] Carro \n [o] Ônibus");
            escolha = char.Parse(Console.ReadLine());

            switch(escolha){
                case 'a':
                    tempo=50;
                    break;
                case 'c':
                    tempo=480;
                    break;
                case'o':
                    tempo=660;
                    break;
                default:
                    tempo=-1;
                    break;
            }

            if(tempo<0){
                Console.WriteLine("Transporte Indisponivel");
            }
            else{
                Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos",tempo);
            }

        }
    }
}