using System;

public class Convert_Distancia
{
    public static void Menu()
    {
        bool voltar = false;
        
        while (!voltar)
        {
            Console.Clear();

            Console.WriteLine("########## Conversor de Unidades ##########");
            Console.WriteLine("1 - Converter Distância");
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
    public static void Converter()
	{
        Console.WriteLine("Digite a distância em metros: ");
        double metros = double.Parse(Console.ReadLine());

        double km = metros / 1000;
        double milhas = metros * 0.000621371;

        Console.WriteLine($"Distância em quilômetros: {km:F2}");
        Console.WriteLine($"Distância em milhas: {milhas:F2}");
    }
}
