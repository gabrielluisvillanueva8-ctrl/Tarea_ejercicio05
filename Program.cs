using System;
class Program
{
    static int ContarIguales(int[] notas, int valor)
    {
        int contador = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] == valor)
            {
                contador++;
            }
        }
        return contador;
    }
    static int ContarAprobados(int[] notas)
    {
        int contador = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] >= 13)
            {
                contador++;
            }
        }
        return contador;
    }
    static int ContarDesaprobados(int[] notas)
    {
        int contador = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] < 13)
            {
                contador++;
            }
        }
        return contador;
    }
    static void Main()
    {
        int N;
        do
        {
            Console.Write("Ingrese la cantidad de alumnos (máximo 10): ");
            N = int.Parse(Console.ReadLine());
        }
        while (N <= 0 || N > 10);
        int[] notas = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Nota " + (i + 1) + ": ");
            notas[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nCantidad de personas que obtuvieron 00: " + ContarIguales(notas, 0));
        Console.WriteLine("Cantidad de personas que obtuvieron 20: " + ContarIguales(notas, 20));
        Console.WriteLine("Cantidad de personas aprobadas: " + ContarAprobados(notas));
        Console.WriteLine("Cantidad de personas desaprobadas: " + ContarDesaprobados(notas));
        Console.ReadKey();
    }
}