namespace CalculoAreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar la base del triángulo al usuario
            Console.Write("Por favor, ingresa la base del triángulo: ");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());

            // Solicitar la altura del triángulo al usuario
            Console.Write("Por favor, ingresa la altura del triángulo: ");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            // Calcular el área del triángulo
            double area = (baseTriangulo * alturaTriangulo) / 2;

            // Mostrar el resultado
            Console.WriteLine($"\nEl área del triángulo con base {baseTriangulo} y altura {alturaTriangulo} es: {area}");
        }
    }
}