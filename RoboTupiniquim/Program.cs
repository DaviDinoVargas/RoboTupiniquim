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

            Console.WriteLine("Digite a posição inicial do robô em X e Y: ");
            string[] posicaoInicial = Console.ReadLine()!.Split(' ');
            int x = Convert.ToInt32(posicaoInicial[0]);
            int y = Convert.ToInt32(posicaoInicial[1]);

            Console.WriteLine("Digite a direção inicial do robô (N, L, O, S): ");
            char direcaoInicial = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.ReadLine();

            Console.WriteLine("Digite os comandos para o robô (D, E, M): ");
            string comandos = Console.ReadLine()!.ToUpper();
            foreach (char opcaoMovimento in comandos)
            {
                switch (opcaoMovimento)
                {
                    case 'D':
                    case 'E':
                    case 'M':
                }
            }

        }
    }
}
