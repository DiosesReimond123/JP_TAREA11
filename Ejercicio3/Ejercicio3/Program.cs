class Program
{
    static void Main(string[] args)
    {
        int[] codigos = new int[5];

        for (int i = 0; i < codigos.Length; i++)
        {
            Console.Write($"Codigo {i + 1}: ");
            codigos[i] = int.Parse( Console.ReadLine());
        }
        Console.Write("Codigo a buscar: ");
        int buscado = int.Parse(Console.ReadLine());

        int posicion = -1;

        for(int i = 0; i < codigos.Length;i++)
        {
            if(buscado  == codigos[i])
            {
                posicion = i;
            }
        }
        if (posicion != -1)
        {
            Console.WriteLine($"Codigo encontrado en indice {posicion}");
        }
        else
        {
            Console.WriteLine("Codigo no encontrado");
        }
    }
}
