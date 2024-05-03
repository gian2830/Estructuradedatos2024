namespace SumaDigitos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar un número entero al usuario
            Console.Write("Por favor, ingresa un número entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Calcular la suma de los dígitos del número ingresado
            int sumaDigitos = CalcularSumaDigitos(numero);

            // Mostrar la suma de los dígitos
            Console.WriteLine($"\nLa suma de los dígitos de {numero} es: {sumaDigitos}");
        }

        // Función que calcula la suma de los dígitos de un número entero
        static int CalcularSumaDigitos(int numero)
        {
            int suma = 0;

            // Calcular la suma de los dígitos
            while (numero != 0)
            {
                // Obtener el dígito menos significativo
                int digito = numero % 10;

                // Sumar el dígito a la suma total
                suma += digito;

                // Eliminar el dígito menos significativo del número
                numero /= 10;
            }

            return suma;
        }
    }
}