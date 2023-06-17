using System;

class Program
{
    static void Main()
    {
        // Se declaran las matrices 
        // matriz 1
        int[,] MPrimera = new int[2, 2];
        // matriz 2
        int[,] MSegunda = new int[2, 2];
        // Se declara la variable que se encargará de generar los valores aleatorios
        Random rnd = new Random();
        // Calulo e impresión de las matrices
        Console.WriteLine("Matriz1:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                MPrimera[i, j] = rnd.Next(10);
                Console.Write("{0} ", MPrimera[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nMatriz2:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                MSegunda[i, j] = rnd.Next(10);
                Console.Write("{0} ", MSegunda[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nSuma de Matrices:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write("{0} ", MPrimera[i, j] + MSegunda[i, j]);
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
