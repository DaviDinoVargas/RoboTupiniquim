using System;

namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Validacoes.ValidarCartesiano();

                int x, y;
                char direcaoInicial;
                Validacoes.ValidarEntradaPosicao(out x, out y, out direcaoInicial);

                Robo robo = new Robo(x, y, direcaoInicial);

                Validacoes.ValidarComandos(robo);
                robo.ExecutarComandos();
                robo.ExibirPosicaoFinal();
                robo.DesejarPlano();

                if (!DesejaContinuar()) break;
            }
        }
        public static bool DesejaContinuar()
        {
            Console.Write("\nDeseja continuar? (s/N): ");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();
            return opcaoContinuar == "S";
        }
    }
}