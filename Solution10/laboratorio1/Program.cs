namespace SerieFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generar los primeros 10 números de la serie Fibonacci
            Console.WriteLine("Los primeros 10 números de la serie Fibonacci son:");
            GenerarFibonacci(10);
        }

        // Función que genera y muestra los primeros 'n' números de la serie Fibonacci
        static void GenerarFibonacci(int n)
        {
            // Inicializar los primeros dos números de la serie Fibonacci
            int a = 0;
            int b = 1;

            // Mostrar los primeros dos números
            Console.WriteLine(a);
            Console.WriteLine(b);

            // Generar los siguientes números de la serie
            for (int i = 2; i < n; i++)
            {
                // Calcular el siguiente número de la serie
                int siguiente = a + b;

                // Mostrar el siguiente número
                Console.WriteLine(siguiente);

                // Actualizar los valores para la siguiente iteración
                a = b;
                b = siguiente;
            }
        }
    }
}