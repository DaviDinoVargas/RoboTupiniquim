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

            int cartesianoX, cartesianoY;

            while (true)
            {
                Console.WriteLine("______________________________________________________________________");
                Console.WriteLine("Digite o tamanho do plano cartesiano X e Y (valor área max de 20x20): ");
                Console.WriteLine("______________________________________________________________________");
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
                    Console.WriteLine("______________________________________________________________________");
                    Console.WriteLine("                 Entrada inválida. Tente novamente.");
                    Console.WriteLine("______________________________________________________________________");
                }
            }
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine($"Plano cartesiano de tamanho {cartesianoX} x {cartesianoY} foi aceito.");
            Console.WriteLine("______________________________________________________________________");



            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("       Digite a posição inicial do robô X, Y && (N, L, O, S): ");
            Console.WriteLine("______________________________________________________________________");
            string[] posicaoInicial = Console.ReadLine()!.Split(' ');
            int x = Convert.ToInt32(posicaoInicial[0]);
            int y = Convert.ToInt32(posicaoInicial[1]);
            char direcaoInicial = Char.ToUpper(posicaoInicial[2][0]);

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
                        indiceDirecao = (indiceDirecao -1 + rosaDosVentos.Count) % rosaDosVentos.Count;
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
            switch (rosaDosVentos[indiceDirecao])
            {
                case 'N':
                    simbolo = '↑';
                    break;
                case 'S':
                    simbolo = '↓';
                    break;
                case 'O':
                    simbolo = '<';
                    break;
                case 'L':
                    simbolo = '→';
                    break;
                default:
                    simbolo = '?';
                    break;
            }
          
                for (int i = 0; i < cartesianoY; i++)
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
            
            Console.WriteLine($"\n Posição Final: {x} {y}");
            Console.WriteLine($" Posição Direção robô: {rosaDosVentos[indiceDirecao]}");
            Console.ReadLine();

        }
    }
}
