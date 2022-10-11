using System;

namespace PraticandoGT_01
{
    class Study
    {
        static void Main(string[] args)
        {
            int tempo=0;
            char escolha=' ';
            string op=" ";

            inicio:

            Console.Clear();

            Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
            Console.WriteLine("Escola o transporte:\n [a] Avião \n [c] Carro \n [o] Ônibus");
            escolha = char.Parse(Console.ReadLine());

            switch(escolha){
                case 'a':
                case 'A':
                    op="Avião";
                    tempo=50;
                    break;
                case 'c':
                case 'C':
                    op="Carro";
                    tempo=480;
                    break;
                case'o':
                case 'O':
                    tempo=660;
                    op="Ônibus";
                    break;
                default:
                    tempo=-1;
                    break;
            }

            if(tempo<0){
                Console.WriteLine("Transporte Indisponivel");
            }
            else{
                Console.WriteLine("Transporte: {0} Tempo Estimado: {1} minutos\n",op,tempo);
            }

            Console.WriteLine("Você deseja fazer um novo calculo: [s/n]");
            escolha =char.Parse(Console.ReadLine());

            if(escolha=='s'|| escolha=='S'){
                goto inicio;
            }else{
                Console.Clear();
                Console.WriteLine("Fim do Programa!");
            }
        }
    }
}
