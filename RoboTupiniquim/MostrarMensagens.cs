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
            Console.WriteLine($"Plano cartesiano de tamanho {Validacoes.cartesianoX} x {Validacoes.cartesianoY} foi aceito.");
            Console.WriteLine("______________________________________________________________________");
        }
    }
}
