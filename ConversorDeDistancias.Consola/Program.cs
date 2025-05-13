using ConversorDeDistancia.Entidades;
namespace ConversorDeDistancias.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kilometros = 0;
            double milla = 0;
            Kilómetros km = new Kilómetros();
            Millas mi = new Millas();

            Console.Write("Ingrese kilometros:");
            kilometros = double.Parse(Console.ReadLine()!.Replace(".", ","));
            Console.Write("Ingrese millas:");
            milla = double.Parse(Console.ReadLine()!.Replace(".", ","));

            km.Velocidad = kilometros;
            mi.Velocidad = milla;

            double kmEnMillas = km.ConvertirAMillas(km.Velocidad);
            double millasEnKm = mi.ConvertirAKilometros(mi.Velocidad);

            Console.WriteLine($"--- Conversiones ---");
            Console.WriteLine($"{km.Velocidad:F2} km = {kmEnMillas:F2} millas");
            Console.WriteLine($"{mi.Velocidad:F2} millas = {millasEnKm:F2} km");

            var suma = km + mi;
            var resta = km - mi;

            Console.WriteLine($"--- Operaciones ---");
            Console.WriteLine($"Suma: {suma.Velocidad:F2} km");
            Console.WriteLine($"Resta: {resta.Velocidad:F2} km");

            Kilómetros km1 = new Kilómetros(33);
            Kilómetros km2 = new Kilómetros(33);

            Console.WriteLine("--- Comparación ---");
            if (km1 == km2)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son diferentes");
            }

            Console.ReadLine();
        }
    }
}
