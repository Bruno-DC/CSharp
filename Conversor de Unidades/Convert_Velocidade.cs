using System;

public class Convert_Velocidade
{
    public static void Menu()
    {
        bool voltar = false;

        while (!voltar)
        {
            Console.Clear();

            Console.WriteLine("########## Conversor de Unidades ##########");
            Console.WriteLine("1 - Converter Velocidade");
            Console.WriteLine("0 - Menu Principal");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    Converter();
                    break;
                case 0:
                    voltar = true;
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;

            }
            Console.WriteLine();
            Console.WriteLine("Precione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
    private static void Converter()
	{
        Console.WriteLine("Digite a velocidade em Km/h: ");
        double kmh = double.Parse(Console.ReadLine());

        double ms = kmh * 0.277778;
        double mph = kmh * 0.621371;

        Console.WriteLine("Velocidade em m/s: " + ms);
        Console.WriteLine("Velocidade em mph: " + mph);
    }
}
