class Program
{
    static void Main()
    {
        double[] precios = new double[5];
        double buscado, nuevo;
        int posicion;

        posicion = -1;

        for (int i = 0; i <= 4; i++)
        {
            Console.Write($"Ingrese el precio del producto {i}: ");
            precios[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.Write("Ingrese el precio exacto a buscar: ");
        buscado = Convert.ToDouble(Console.ReadLine());

        for (int i = 0; i <= 4; i++)
        {
            if (precios[i] == buscado)
            {
                posicion = i;
            }
        }

        if (posicion != -1)
        {
            Console.Write("Ingrese el nuevo precio: ");
            nuevo = Convert.ToDouble(Console.ReadLine());

            precios[posicion] = nuevo;
            Console.WriteLine("Precio actualizado");
        }
        else
        {
            Console.WriteLine("Precio no encontrado");
        }

        Console.WriteLine("\n--- Lista de precios final ---");
        for (int i = 0; i <= 4; i++)
        {
            Console.WriteLine($"Posicion {i}: {precios[i]}");
        }
    }
}
