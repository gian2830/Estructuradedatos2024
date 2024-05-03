namespace CuadradosNumerosNaturales
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista para almacenar los cuadrados de los primeros 10 números naturales
            List<int> cuadrados = new List<int>();

            // Calcular los cuadrados de los primeros 10 números naturales
            for (int i = 1; i <= 10; i++)
            {
                int cuadrado = i * i;
                cuadrados.Add(cuadrado);
            }

            // Mostrar los cuadrados de los primeros 10 números naturales
            Console.WriteLine("Cuadrados de los primeros 10 números naturales:");
            foreach (int cuadrado in cuadrados)
            {
                Console.WriteLine(cuadrado);
            }
        }
    }
}