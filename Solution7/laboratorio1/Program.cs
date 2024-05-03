namespace SumaNumerosPares
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar el rango de números al usuario
            Console.Write("Ingresa el número inicial del rango: ");
            int inicio = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el número final del rango: ");
            int final = Convert.ToInt32(Console.ReadLine());

            // Calcular la suma de los números pares en el rango especificado
            int sumaPares = CalcularSumaPares(inicio, final);

            // Mostrar el resultado
            Console.WriteLine($"\nLa suma de los números pares entre {inicio} y {final} es: {sumaPares}");
        }

        // Función que calcula la suma de los números pares en un rango
        static int CalcularSumaPares(int inicio, int final)
        {
            int suma = 0;

            // Recorrer el rango y sumar los números pares
            for (int i = inicio; i <= final; i++)
            {
                if (i % 2 == 0)
                {
                    suma += i;
                }
            }

            return suma;
        }
    }
}