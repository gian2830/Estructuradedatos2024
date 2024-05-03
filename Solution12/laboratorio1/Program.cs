namespace VerificarPalindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar una palabra al usuario
            Console.Write("Por favor, ingresa una palabra: ");
            string palabra = Console.ReadLine();

            // Verificar si la palabra es un palíndromo
            bool esPalindromo = EsPalindromo(palabra);

            // Mostrar el resultado
            if (esPalindromo)
            {
                Console.WriteLine($"\nLa palabra '{palabra}' es un palíndromo.");
            }
            else
            {
                Console.WriteLine($"\nLa palabra '{palabra}' no es un palíndromo.");
            }
        }

        // Función que verifica si una palabra es un palíndromo
        static bool EsPalindromo(string palabra)
        {
            // Convertir la palabra a minúsculas para hacer una comparación insensible a mayúsculas
            string palabraNormalizada = palabra.ToLower();

            // Inicializar dos índices para recorrer la palabra desde ambos extremos
            int inicio = 0;
            int fin = palabraNormalizada.Length - 1;

            // Comparar los caracteres desde ambos extremos hasta el centro de la palabra
            while (inicio < fin)
            {
                // Si los caracteres no coinciden, la palabra no es un palíndromo
                if (palabraNormalizada[inicio] != palabraNormalizada[fin])
                {
                    return false;
                }

                // Avanzar hacia el centro
                inicio++;
                fin--;
            }

            // Si se llegó al centro sin encontrar diferencias, la palabra es un palíndromo
            return true;
        }
    }
}