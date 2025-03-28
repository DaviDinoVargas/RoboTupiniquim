using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTupiniquim
{
    public class Validacoes
    {
        public static int cartesianoX, cartesianoY;
        public static void CartesianoValidacao()
        {
            while (true)
            {
                MostrarMensagens.CartesianoMensagem();
                string[] planoCartesiano = Console.ReadLine()!.Split(' ');

                if (planoCartesiano.Length == 2 &&
                    int.TryParse(planoCartesiano[0], out cartesianoX) &&
                    int.TryParse(planoCartesiano[1], out cartesianoY) &&
                    cartesianoX >= 1 && cartesianoX <= 20 &&
                    cartesianoY >= 1 && cartesianoY <= 20)
                {
                    break;
                }
                else
                {
                    MostrarMensagens.EntradaInvalida();
                }
            }
            MostrarMensagens.EntradaValidaCartesiano();
        }
    }
}
