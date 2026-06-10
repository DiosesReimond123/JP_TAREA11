namespace Ejercicio6
{
    internal class Program
    {
        static void Main()
        {
            double[] precios = new double[5];
            double buscado, nuevo;
            int posicion = -1;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingrese el precio {i + 1}: ");
                precios[i] = double.Parse(Console.ReadLine());
            }
            Console.Write("Ingrese el precio a buscar: ");
            buscado = double.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                if (precios[i] == buscado)
                {
                    posicion = i;
                }
            }
            if (posicion != -1)
            {
                Console.Write("Ingrese el nuevo precio: ");
                nuevo = double.Parse(Console.ReadLine());

                precios[posicion] = nuevo;

                Console.WriteLine("Precio actualizado");
            }
            else
            {
                Console.WriteLine("Precio no encontrado");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Posición {i}: {precios[i]}");
            }
    }   }
}
