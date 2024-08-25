

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("¿Cuántos trabajadores tienes?");
        int agregar = int.Parse(Console.ReadLine());

      
        string[] prac = new string[agregar];

        for (int i = 0; i < prac.Length; i++)
        {
            Console.WriteLine("Ingrese el nombre del trabajador número " + (i + 1) + ":");
            prac[i] = Console.ReadLine();
        }

    
        Console.WriteLine("Los nombres ingresados son:");
        for (int i = 0; i < prac.Length; i++)
        {
            Console.WriteLine(prac[i]);
        }
    }
}

