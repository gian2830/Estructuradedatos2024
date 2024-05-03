namespace VerificacionNumeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar un número al usuario
            Console.Write("Por favor, ingresa un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Verificar si el número es primo
            bool esPrimo = EsPrimo(numero);

            // Mostrar el resultado
            if (esPrimo)
            {
                Console.WriteLine($"El número {numero} es primo.");
            }
            else
            {
                Console.WriteLine($"El número {numero} no es primo.");
            }
        }

        // Función que verifica si un número es primo
        static bool EsPrimo(int numero)
        {
            // Un número menor o igual a 1 no es primo
            if (numero <= 1)
            {
                return false;
            }

            // Comprobar si el número es divisible por algún número entre 2 y la raíz cuadrada de él
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            // Si no se encontró ningún divisor, el número es primo
            return true;
        }
    }
}