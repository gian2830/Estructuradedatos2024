namespace AreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar el radio del círculo al usuario
            Console.Write("Por favor, ingresa el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            // Calcular el área del círculo
            double area = CalcularAreaCirculo(radio);

            // Mostrar el área del círculo
            Console.WriteLine($"\nEl área del círculo con radio {radio} es: {area}");
        }

        // Función que calcula el área de un círculo dado su radio
        static double CalcularAreaCirculo(double radio)
        {
            // Usar la fórmula para calcular el área del círculo
            return Math.PI * radio * radio;
        }
    }
}