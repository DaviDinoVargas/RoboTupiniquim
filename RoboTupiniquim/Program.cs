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

                List<Robo> robos = new List<Robo>();
                do
                {
                    int x, y;
                    char direcaoInicial;
                    Validacoes.ValidarEntradaPosicao(out x, out y, out direcaoInicial);

                    Robo robo = new Robo(x, y, direcaoInicial);

                    Validacoes.ValidarComandos(robo);
                    robos.Add(robo);
                } while (AdicionarNovoRobo());
                {
                    foreach (Robo robo in robos)
                    {
                        robo.ExecutarComandos();
                    }
                }

                Robo.DesenharPlano(robos);
                MostrarMensagens.SaidaDeDados(robos);
                Console.ReadLine();
                if (!DesejaContinuar()) break;
            }
        }
        private static bool AdicionarNovoRobo()
        {
            Console.Write("Deseja adicionar outro robô? (s/N): ");
            return Console.ReadLine()!.ToUpper() == "S";
        }
        public static bool DesejaContinuar()
        {
            Console.Write("\nDeseja continuar? (s/N): ");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();
            return opcaoContinuar == "S";
        }
        
    }
}