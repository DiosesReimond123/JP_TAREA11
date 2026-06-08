class Program
{
    static void Main()
    {
        double[] temperaturas = new double[7];
        int diaEncontrado;

        diaEncontrado = -1;

        for (int i = 0; i <= 6; i++)
        {
            Console.Write($"Ingrese temperatura del dia {i + 1}: ");
            temperaturas[i] = Convert.ToDouble(Console.ReadLine());
        }

        for (int i = 0; i <= 6; i++)
        {
            if (temperaturas[i] > 30 && diaEncontrado == -1)
            {
                diaEncontrado = i;
            }
        }

        if (diaEncontrado != -1)
        {
            Console.WriteLine($"Primera alerta en dia {diaEncontrado + 1}");
        }
        else
        {
            Console.WriteLine("No hubo alerta de temperatura");
        }
    }
}