using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTupiniquim
{
    public class MostrarMensagens
    {
        public static void CartesianoMensagem()
        {
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("Digite o tamanho do plano cartesiano X e Y (valor área max de 20x20): ");
            Console.WriteLine("______________________________________________________________________");
        }

        public static void EntradaInvalida()
        {
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("                 Entrada inválida. Tente novamente.");
            Console.WriteLine("______________________________________________________________________");
        }

        public static void EntradaValidaCartesiano()
        {
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine($"Plano cartesiano de tamanho {Robo.cartesianoX} x {Robo.cartesianoY} foi aceito.");
            Console.WriteLine("______________________________________________________________________");
        }
        public static void PosicaoInicial()
        {
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("       Digite a posição inicial do robô X, Y && (N, L, O, S): ");
            Console.WriteLine("______________________________________________________________________");
        }
        public static void EntradaComandos()
        {
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("           Digite os comandos para o robô (D, E, M): ");
            Console.WriteLine("______________________________________________________________________");
        }
        public static void SaidaDeDados(List<Robo> robos)
        {
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("\n                  POSIÇÕES FINAIS DOS ROBÔS");
            Console.WriteLine("______________________________________________________________________");

            foreach (Robo robo in robos)
            {
                Console.WriteLine($"\n                Robô {robos.IndexOf(robo) + 1}:");
                Console.WriteLine($"                Posição: {robo.X} {robo.Y}");
                Console.WriteLine($"                Direção: {robo.Direcao}");
            }

            Console.WriteLine("______________________________________________________________________");
        }
        public static void PosicaoForaDoGrid()
        {
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("\n                    POSIÇÃO FORA DO GRID!");
            Console.WriteLine("______________________________________________________________________");
        }

        public static void Continuar()
        {
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("                      APERTE <ENTER>.");
            Console.WriteLine("______________________________________________________________________");
            Console.ReadLine();
        }

    }
}
