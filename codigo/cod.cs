using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Seleccione la fórmula que desea calcular:");
            Console.WriteLine("1. Fuerza (F = m * a)");
            Console.WriteLine("2. Trabajo (W = F * d)");
            Console.WriteLine("3. Energia cinetica (E = 0.5 * m * v^2)");
            Console.WriteLine("4. Terminar el programa");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CalcularFuerza();
                    break;
                case 2:
                    CalcularTrabajo();
                    break;
                case 3:
                    CalcularEnergiaCinetica();
                    break;
                case 4:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
    }

    static void CalcularFuerza()
    {
        Console.WriteLine("Ingrese la masa (kg):");
        float masa = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la aceleración (m/s^2):");
        float aceleracion = float.Parse(Console.ReadLine());

        float fuerza = masa * aceleracion;
        Console.WriteLine("La fuerza es: " + fuerza + " N");
    }

    static void CalcularTrabajo()
    {
        Console.WriteLine("Ingrese la fuerza (N):");
        float fuerza = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la distancia (m):");
        float distancia = float.Parse(Console.ReadLine());

        float trabajo = fuerza * distancia;
        Console.WriteLine("El trabajo es: " + trabajo + " J");
    }

    static void CalcularEnergiaCinetica()
    {
        Console.WriteLine("Ingrese la masa (kg):");
        float masa = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la velocidad (m/s):");
        float velocidad = float.Parse(Console.ReadLine());

        float energiaCinetica = 0.5f * masa * velocidad * velocidad;
        Console.WriteLine("La energía cinética es: " + energiaCinetica + " J");
    }
}
    