using RoboTupiniquim;

namespace RoboTupiniquim
{
    public class Robo
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public char Direcao { get; private set; }
        public string Comandos { get; set; }
        public static int cartesianoX;
        public static int cartesianoY;

        private static readonly Dictionary<int, char> rosaDosVentos = new()
        {
            {0, 'N'},
            {1, 'L'},
            {2, 'S'},
            {3, 'O'}
        };

        private int indiceDirecao;

        public Robo(int x, int y, char direcao)
        {
            this.X = x;
            this.Y = y;
            Direcao = char.ToUpper(direcao);
            indiceDirecao = ObterIndiceDirecao(Direcao);
        }

        private int ObterIndiceDirecao(char direcao)
        {
            foreach (var kvp in rosaDosVentos)
            {
                if (kvp.Value == direcao)
                    return kvp.Key;
            }
            return Direcao;
        }

        public void ExecutarComandos()
        {
            foreach (char comando in Comandos)
            {
                switch (comando)
                {
                    case 'D':
                        indiceDirecao = (indiceDirecao + 1) % rosaDosVentos.Count;
                        break;
                    case 'E':
                        indiceDirecao = (indiceDirecao - 1 + rosaDosVentos.Count) % rosaDosVentos.Count;
                        break;
                    case 'M':
                        Mover();
                        break;
                }
                Direcao = rosaDosVentos[indiceDirecao];
            }
        }
        private void Mover()
        {
            switch (indiceDirecao)
            {
                case 0: if(Y < Robo.cartesianoY -1) Y++; break;
                case 1: if (X < Robo.cartesianoX - 1) X++; break;
                case 2: if (Y > 0) Y--; break;
                case 3: if (X > 0) X--; break;
            }
        }
        public void ExibirPosicaoFinal()
        {
            Console.WriteLine($"Posição Final: {X} {Y}, Direção: {Direcao}");
        }
        public char ObterSimbolo()
        {
            char simbolo;
            switch (rosaDosVentos[indiceDirecao])
            {
                case 'N':
                    simbolo = '^';
                    break;
                case 'S':
                    simbolo = 'v';
                    break;
                case 'O':
                    simbolo = '<';
                    break;
                case 'L':
                    simbolo = '>';
                    break;
                default:
                    simbolo = '?';
                    break;
            }
            return simbolo;
        }
        public static void DesenharPlano(List<Robo> robos)
        {
            Console.Clear();
            for (int i = Robo.cartesianoY -1; i >= 0; i--)
            {
                for (int j = 0; j < Robo.cartesianoX; j++)
                {
                    var roboNoLocal = robos.FirstOrDefault(r => r.X == j && r.Y == i);
                    Console.Write(roboNoLocal != null ? $" {roboNoLocal.ObterSimbolo()} " : " . ");
                }
                Console.WriteLine();
            }
        }
    }
    }
            /*Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("- ↑. ↓. →. ←. -");
            Console.ReadKey();*/