namespace OrdenarListaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario la cantidad de números que desea ingresar
            Console.Write("¿Cuántos números deseas ingresar?: ");
            int cantidadNumeros = Convert.ToInt32(Console.ReadLine());

            // Crear una lista para almacenar los números ingresados
            List<int> numeros = new List<int>();

            // Solicitar los números al usuario
            Console.WriteLine("Por favor, ingresa los números:");
            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.Write($"Número {i + 1}: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                numeros.Add(numero);
            }

            // Ordenar la lista de números de menor a mayor
            numeros.Sort();

            // Mostrar la lista ordenada
            Console.WriteLine("\nLista ordenada de menor a mayor:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}