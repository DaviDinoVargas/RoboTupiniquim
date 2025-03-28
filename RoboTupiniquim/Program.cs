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

            Validacoes.CartesianoValidacao();

            int x, y;
            char direcaoInicial;
            while (true)
            {
                Console.WriteLine("______________________________________________________________________");
                Console.WriteLine("       Digite a posição inicial do robô X, Y && (N, L, O, S): ");
                Console.WriteLine("______________________________________________________________________");


                string[] entrada = Console.ReadLine()!.Trim().Split(' ');
                if (entrada.Length == 3 && int.TryParse(entrada[0], out x) && int.TryParse(entrada[1], out y) && "NLOS".Contains(char.ToUpper(entrada[2][0])))
                {
                    direcaoInicial = char.ToUpper(entrada[2][0]);
                    break;
                }
                Console.WriteLine("Entrada inválida! Insira dois números e uma letra (N, L, O, S), separados por espaço.");
            }

            string comandos;
            while (true)
            {
                Console.WriteLine("______________________________________________________________________");
                Console.WriteLine("           Digite os comandos para o robô (D, E, M): ");
                Console.WriteLine("______________________________________________________________________");
                comandos = Console.ReadLine()!.ToUpper();
                if (comandos.All(c => "DEM".Contains(c)))
                    break;

                Console.WriteLine("Entrada inválida.Tente novamente.");
            }
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
          
                for (int i = 0; i < Validacoes.cartesianoY; i++)
                {
                    for (int j = 0; j < Validacoes.cartesianoX; j++)
                    {
                        if (i == y && j == x)
                            Console.Write(" " + simbolo + " ");
                        else
                        
                        Console.Write(" . ");
                        
                }
                    Console.WriteLine();
                }
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine($"\n                Posição Final: {x} {y}");
            Console.WriteLine($"               Posição Direção robô: {rosaDosVentos[indiceDirecao]}");
            Console.WriteLine("______________________________________________________________________");
            Console.ReadLine();

        }
    }
}
