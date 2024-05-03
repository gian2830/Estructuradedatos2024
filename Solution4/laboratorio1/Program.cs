namespace CalculoFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar un número al usuario
            Console.Write("Por favor, ingresa un número para calcular su factorial: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Calcular el factorial utilizando la función
            long factorial = CalcularFactorial(numero);

            // Mostrar el resultado
            Console.WriteLine($"\nEl factorial de {numero} es: {factorial}");
        }

        // Función que calcula el factorial de un número
        static long CalcularFactorial(int n)
        {
            // El factorial de 0 es 1
            if (n == 0)
            {
                return 1;
            }

            // Calcular el factorial de n recursivamente
            long resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}