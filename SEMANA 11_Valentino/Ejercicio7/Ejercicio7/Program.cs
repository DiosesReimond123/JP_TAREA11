namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] asistencia = new int[5];
            bool existeCero = false;
            int indiceModificar, nuevoValor;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingrese asistencia de la sesión {i}: ");
                asistencia[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Asistencias registradas:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Índice {i}: {asistencia[i]}");
            }
            for (int i = 0; i < 5; i++)
            {
                if (asistencia[i] == 0)
                {
                    existeCero = true;
                }
            }
            if (existeCero)
            {
                Console.WriteLine("Alerta: existe una sesión con 0 asistentes");
            }
            else
            {
                Console.WriteLine("No hay sesión con 0 asistentes");
            }
            Console.Write("\nIngrese el índice a modificar: ");
            indiceModificar = int.Parse(Console.ReadLine());

            if (indiceModificar >= 0 && indiceModificar < 5)
            {
                Console.Write("Ingrese el nuevo valor: ");
                nuevoValor = int.Parse(Console.ReadLine());

                asistencia[indiceModificar] = nuevoValor;
            }
            else
            {
                Console.WriteLine("Índice no válido");
            }

            Console.WriteLine("\nAsistencias actualizadas:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Índice {i}: {asistencia[i]}");
            }
        }
            
    }
}
