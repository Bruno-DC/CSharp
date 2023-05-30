using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        int opcao;

        Console.WriteLine("########## Conversor de Unidades ##########");
        Console.WriteLine("1 - Converter Temperatura");
        Console.WriteLine("2 - Converter Velocidade");
        Console.WriteLine("3 - Converter Distância");
        Console.WriteLine("0 - Sair do Sistema");

        opcao = Convert.ToInt32(Console.ReadLine());
        
        switch (opcao)
        {
            case 1:
                Console.WriteLine("Temperatura");
                //Convert_Temperatura();
                break;
            case 2:
                Console.WriteLine("Velocidade");
                //Convert_Velocidade();
                break;
            case 3:
                Console.WriteLine("Distância");
                //Convert_Distancia();
                break;
            case 0:
                Environment.Exit(0); 
                break;

            default:
                Console.WriteLine("Opção Inválida");
                break;
        }
    }
}