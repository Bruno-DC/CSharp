using System;

public class Convert_Temperatura	
{
	public static void Menu()
	{
		bool voltar = false;

		while (!voltar)
		{
			Console.Clear();

			Console.WriteLine("########## Conversor de Unidades ##########");
            Console.WriteLine("1 - Converter Temperatura");
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

            Console.WriteLine("Digite a temperatura em Celsius: ");
			double celsius = double.Parse(Console.ReadLine());

			double fahrenheit = celsius * 9 / 5 + 32;
			double Kelvin = celsius + 273.15;

        Console.WriteLine($"Temperatura em fahrenheit: {fahrenheit:F2}");
        //Console.WriteLine("Temperatura em fahrenheit: " + fahrenheit.ToString("N2"));
        Console.WriteLine($"Temperatura em Kelvin: {Kelvin:F2}");		
	}
}
