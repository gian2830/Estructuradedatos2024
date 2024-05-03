
namespace NumeroParOImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar un número al usuario
            Console.Write("Por favor, ingresa un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Determinar si el número es par o impar
            if (numero % 2 == 0)
            {
                Console.WriteLine($"El número {numero} es par.");
            }
            else
            {
                Console.WriteLine($"El número {numero} es impar.");
            }
        }
    }
}