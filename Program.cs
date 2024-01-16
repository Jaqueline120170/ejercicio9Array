using System;
using System.Collections;

class Program
{
    static void Main()
    {
        
        int[] numerosArray = { 1, 2, 3, 4, 5, 6, 7, 8 };

        ArrayList provinciasAndalucia = new ArrayList { "Almería", "Cádiz", "Córdoba", "Granada", "Huelva", "Jaén", "Málaga", "Sevilla" };

      
        provinciasAndalucia.Sort();
        provinciasAndalucia.Insert(0, numerosArray[0]);

        for (int i = 1; i < numerosArray.Length; i++)
        {
            provinciasAndalucia.Insert(i * 2 - 1, numerosArray[i]);
        }

        Console.WriteLine("Provincias Andalucía con números intercalados:");
        foreach (var item in provinciasAndalucia)
        {
            Console.WriteLine(item);
        }
    }
}

