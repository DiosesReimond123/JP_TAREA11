class Program
{
    static void Main()
    {
        int[] asistencia = new int[5];
        bool existeCero;
        int indiceModificar, nuevoValor;

        existeCero = false;

        for (int i = 0; i <= 4; i++)
        {
            Console.Write($"Ingrese la asistencia de la sesion {i}: ");
            asistencia[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\n--- Asistencias registradas ---");
        for (int i = 0; i <= 4; i++)
        {
            Console.WriteLine($"Sesion {i}: {asistencia[i]}");
        }

        for (int i = 0; i <= 4; i++)
        {
            if (asistencia[i] == 0)
            {
                existeCero = true;
            }
        }

        if (existeCero)
        {
            Console.WriteLine("Alerta: existe una sesion con 0 asistentes");
        }
        else
        {
            Console.WriteLine("No hay sesion con 0 asistentes");
        }

        Console.WriteLine();
        Console.Write("Ingrese el indice de la sesion a modificar: ");
        indiceModificar = Convert.ToInt32(Console.ReadLine());

        if (indiceModificar >= 0 && indiceModificar < 5)
        {
            Console.Write("Ingrese la nueva cantidad de asistentes: ");
            nuevoValor = Convert.ToInt32(Console.ReadLine());
            asistencia[indiceModificar] = nuevoValor;
        }
        else
        {
            Console.WriteLine("Indice no valido");
        }

        Console.WriteLine("\n--- Asistencias actualizadas ---");
        for (int i = 0; i <= 4; i++)
        {
            Console.WriteLine($"Sesion {i}: {asistencia[i]}");
        }
    }
}