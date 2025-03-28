using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTupiniquim
{
    public class Validacoes
    {

        public static void ValidarCartesiano()
        {
            while (true)
            {
                MostrarMensagens.CartesianoMensagem();
                string[] planoCartesiano = Console.ReadLine()!.Split(' ');

                if (planoCartesiano.Length == 2 &&
                    int.TryParse(planoCartesiano[0], out Robo.cartesianoX) &&
                    int.TryParse(planoCartesiano[1], out Robo.cartesianoY) &&
                    Robo.cartesianoX >= 1 && Robo.cartesianoX <= 20 &&
                    Robo.cartesianoY >= 1 && Robo.cartesianoY <= 20)
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
        public static void ValidarEntradaPosicao(out int x, out int y, out char direcaoInicial)
        {
            while (true)
            {
                MostrarMensagens.PosicaoInicial();
                string[] entrada = Console.ReadLine()!.Trim().Split(' ');
                if (entrada.Length == 3 && int.TryParse(entrada[0], out x) && int.TryParse(entrada[1], out y) && "NLOS".Contains(char.ToUpper(entrada[2][0])))
                {
                    direcaoInicial = char.ToUpper(entrada[2][0]);
                    break;
                }
                MostrarMensagens.EntradaInvalida();
            }
        }

        public static void ValidarComandos(Robo robo)
        {
            while (true)
            {
                MostrarMensagens.EntradaComandos();
                string comandos = Console.ReadLine()!.ToUpper();
                if (comandos.All(c => "DEM".Contains(c)))
                {   
                    robo.Comandos = comandos;
                    break;
                }
                MostrarMensagens.EntradaInvalida();
            }
        }
    }
}
