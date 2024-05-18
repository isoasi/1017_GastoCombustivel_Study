using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double tempo, velocidadeMedia, total;

        // Ler o tempo/horas gasto na viagem e a velocidade média (em km/h)
        tempo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        velocidadeMedia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        // Calcular a distância percorrida / Gasto por km do carro = quantidade de litros necessária
        total = (tempo * velocidadeMedia) / 12;


        Console.WriteLine(total.ToString("F3", CultureInfo.InvariantCulture));

        Console.Read();

    }

}