namespace ContarVocales
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar una cadena de texto al usuario
            Console.Write("Por favor, ingresa una cadena de texto: ");
            string cadena = Console.ReadLine();

            // Contar las vocales en la cadena
            int cantidadVocales = ContarVocales(cadena);

            // Mostrar el resultado
            Console.WriteLine($"\nLa cadena ingresada tiene {cantidadVocales} vocales.");
        }

        // Función que cuenta el número de vocales en una cadena de texto
        static int ContarVocales(string cadena)
        {
            // Definir un conjunto de vocales
            char[] vocales = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int cuenta = 0;

            // Recorrer la cadena y contar las vocales
            foreach (char c in cadena)
            {
                // Verificar si el carácter es una vocal
                if (Array.Exists(vocales, vocal => vocal == c))
                {
                    cuenta++;
                }
            }

            return cuenta;
        }
    }
}