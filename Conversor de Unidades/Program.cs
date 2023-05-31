using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        bool sair = false;

        while (!sair)
        {
            Console.Clear();

            Console.WriteLine("########## Conversor de Unidades ##########");
            Console.WriteLine("1 - Converter Temperatura");
            Console.WriteLine("2 - Converter Velocidade");
            Console.WriteLine("3 - Converter Distância");
            Console.WriteLine("0 - Sair do Sistema");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Convert_Temperatura.Menu();
                    break;
                case 2:
                    Convert_Velocidade.Menu();
                    break;
                case 3:
                    Convert_Distancia.Menu();
                    break;
                case 0:
                    sair = true;                   
                    break;

                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }
    }    
}