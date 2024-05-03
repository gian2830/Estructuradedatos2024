namespace InvertirCadena
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar una cadena de texto al usuario
            Console.Write("Por favor, ingresa una cadena de texto: ");
            string cadena = Console.ReadLine();

            // Invertir la cadena
            string cadenaInvertida = InvertirCadena(cadena);

            // Mostrar la cadena invertida
            Console.WriteLine($"\nLa cadena invertida es: {cadenaInvertida}");
        }

        // Función que invierte una cadena de texto
        static string InvertirCadena(string cadena)
        {
            // Convertir la cadena a un array de caracteres
            char[] caracteres = cadena.ToCharArray();

            // Invertir el array de caracteres
            Array.Reverse(caracteres);

            // Convertir el array de caracteres invertidos de nuevo a una cadena
            return new string(caracteres);
        }
    }
}