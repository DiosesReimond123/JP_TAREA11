class Program
{
    static void Main(string[] args)
    {
        int[] stock = new int[4];

        for(int i = 0; i < stock.Length; i++)
        {
            Console.Write($"Stock del producto {i}: ");
            stock[i] = int.Parse( Console.ReadLine());
        }
        Console.Write("Indice a modificar: ");
        int indice = int.Parse(Console.ReadLine());

        if(indice >= 0 && indice < stock.Length)
        {
            Console.Write("Nuevo stock: ");
            int nuevo = int.Parse(Console.ReadLine());

            stock[indice] = nuevo;
        }
        else
        {
            Console.WriteLine("Indice no valido");
        }
        Console.WriteLine("\nStock actualizado:");

        for(int i = 0;i < stock.Length;i++)
        {
            Console.WriteLine($"Indice {i}: {stock[i]}");
        }
    }
}