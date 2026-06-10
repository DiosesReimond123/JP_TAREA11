namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturas = new double[7];
            int diaEncontrado = -1;

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Ingrese temperatura del día {i + 1}: ");
                temperaturas[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 7; i++)
            {
                if (temperaturas[i] > 30 && diaEncontrado == -1)
                {
                    diaEncontrado = i;
                }
            }
            if (diaEncontrado != -1)
            {
                Console.WriteLine($"Primera alerta en día {diaEncontrado + 1}");
            }
            else
            {
                Console.WriteLine("No hubo alerta de temperatura");
            }
        }
    }
}
