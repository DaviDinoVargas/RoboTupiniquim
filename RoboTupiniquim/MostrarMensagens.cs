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
        public static void SaidaDeDados(Robo robo)
        {
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine($"\n                Posição Final: {robo.X} {robo.Y}");
            Console.WriteLine($"               Posição Direção robô: {robo.Direcao}");
            Console.WriteLine("______________________________________________________________________");
            Console.ReadLine();
        }

    }
}
