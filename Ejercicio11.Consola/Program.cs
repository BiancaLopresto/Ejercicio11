namespace Ejercicio11.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Ladomenor, LadoMayor;
            int Perimetro, Superficie;

            Console.Write("Ingrese el Lado menor: ");
            Ladomenor=int.Parse(Console.ReadLine());

            Console.Write("Ingrese el Lado mayor: ");
            LadoMayor=int.Parse(Console.ReadLine());

            Superficie = LadoMayor * Ladomenor;
            Perimetro = 2 * LadoMayor + 2 * Ladomenor;

            Console.WriteLine($"El perimetro es {Perimetro} y la superficie es {Superficie}");
        }
    }
}