using System.ComponentModel;

namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, char> rosaDosVentos = new Dictionary<int, char>
            {
                {0, 'N'},
                {1, 'L'},
                {2, 'S'},
                {3, 'O'}
            };
            Console.WriteLine("Digite o tamanho do plano cartesiano em X e Y: ");
            string[] planoCartesiano = Console.ReadLine()!.Split(' ');
            int cartesianoX = Convert.ToInt32(planoCartesiano[0]);
            int cartesianoY = Convert.ToInt32(planoCartesiano[1]);

            Console.WriteLine("Digite a posição inicial do robô em X e Y: ");
            string[] posicaoInicial = Console.ReadLine()!.Split(' ');
            int x = Convert.ToInt32(posicaoInicial[0]);
            int y = Convert.ToInt32(posicaoInicial[1]);

            Console.WriteLine("Digite a direção inicial do robô (N, L, O, S): ");
            char direcaoInicial = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.ReadLine();

            Console.WriteLine("Digite os comandos para o robô (D, E, M): ");
            string comandos = Console.ReadLine()!.ToUpper();

            int indiceDirecao = 0;

            foreach (var kvp in rosaDosVentos)
            {
                if (kvp.Value == direcaoInicial)
                {
                    indiceDirecao = kvp.Key;
                    break;
                }
            }

            foreach (char opcaoMovimento in comandos)
            {
                switch (opcaoMovimento)
                {
                    case 'D':
                        indiceDirecao = (indiceDirecao + 1) % rosaDosVentos.Count;
                        break;
                    case 'E':
                        indiceDirecao = (indiceDirecao + 4) % rosaDosVentos.Count;
                        break;
                    case 'M':
                        switch (indiceDirecao)
                        {
                            case 0: y++; break;
                            case 1: x++; break;
                            case 2: y--; break;
                            case 3: x--; break;
                        }
                        break;
                }
            }
            char simbolo;
            switch (direcaoInicial)
            {
                case 'N':
                    simbolo = '↑';
                    break;
                case 'S':
                    simbolo = '↓';
                    break;
                case 'O':
                    simbolo = '←';
                    break;
                case 'L':
                    simbolo = '→';
                    break;
                default:
                    simbolo = '?';
                    break;
            }
            for(int i = 0; i < cartesianoY; i++)
            {
                for (int j = 0; j < cartesianoX; j++)
                {
                    if (i == y && j == x)
                        Console.Write(simbolo + " ");
                    else
                        Console.Write(". ");
                }
                Console.WriteLine();
                

            }
            Console.ReadLine();
            Console.WriteLine($"Posição Final: {x} {y}");
            Console.WriteLine($"Posição Final: {rosaDosVentos[indiceDirecao]}");
            Console.ReadLine();

        }
    }
}
