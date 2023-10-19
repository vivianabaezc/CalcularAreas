using System;

namespace CalculadoraAreas
{
    public abstract class FiguraGeometrica
    {
        public abstract double CalcularArea();
    }

    public class Circulo : FiguraGeometrica
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * radio * radio;
        }
    }

    public class Rectangulo : FiguraGeometrica
    {
        private double baseRectangulo;
        private double altura;

        public Rectangulo(double baseRectangulo, double altura)
        {
            this.baseRectangulo = baseRectangulo;
            this.altura = altura;
        }

        public override double CalcularArea()
        {
            return baseRectangulo * altura;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Calculadora de Área de Figuras Geométricas");
                Console.WriteLine("1. Círculo");
                Console.WriteLine("2. Rectángulo");
                // Console.WriteLine("3. Salir");
                Console.Write("Elija una opción (1/2): ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        CalcularAreaCirculo();
                        break;
                    case "2":
                        CalcularAreaRectangulo();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, elija 1 o 2 ");
                        break;
                }
            }
        }

        static void CalcularAreaCirculo()
        {
            Console.Write("Ingrese el radio del círculo: ");
            if (double.TryParse(Console.ReadLine(), out double radio))
            {
                if (radio < 0)
                {
                    Console.WriteLine("El radio no puede ser negativo.");
                }
                else
                {
                    Circulo circulo = new Circulo(radio);
                    Console.WriteLine($"El área del círculo es: {circulo.CalcularArea()} \n");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Ingrese un número válido para el radio.");
            }
        }

        static void CalcularAreaRectangulo()
        {
            Console.Write("Ingrese la base del rectángulo: ");
            if (double.TryParse(Console.ReadLine(), out double baseRectangulo))
            {
                Console.Write("Ingrese la altura del rectángulo: ");
                if (double.TryParse(Console.ReadLine(), out double altura))
                {
                    if (baseRectangulo < 0 || altura < 0)
                    {
                        Console.WriteLine("Tanto la base como la altura deben ser números no negativos.");
                    }
                    else
                    {
                        Rectangulo rectangulo = new Rectangulo(baseRectangulo, altura);
                        Console.WriteLine($"El área del rectángulo es: {rectangulo.CalcularArea()} \n");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Ingrese un número válido para la altura.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Ingrese un número válido para la base.");
            }
        }
    }
}

