namespace TablaMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar un número al usuario
            Console.Write("Por favor, ingresa un número para generar su tabla de multiplicar: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Generar la tabla de multiplicar del número ingresado
            Console.WriteLine($"\nTabla de multiplicar del número {numero}:");
            GenerarTablaMultiplicar(numero);
        }

        // Función que genera y muestra la tabla de multiplicar de un número
        static void GenerarTablaMultiplicar(int numero)
        {
            // Recorrer los números del 1 al 10 para generar la tabla de multiplicar
            for (int i = 1; i <= 10; i++)
            {
                // Calcular el producto y mostrar el resultado
                int producto = numero * i;
                Console.WriteLine($"{numero} x {i} = {producto}");
            }
        }
    }
}