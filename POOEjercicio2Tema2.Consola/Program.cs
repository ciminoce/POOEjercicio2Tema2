using POOEjercicio2Tema2.Entidades;

namespace POOEjercicio2Tema2.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, car license plates");
            var patenteVieja = "SDP 590";
            Console.WriteLine(ValidadorPatente.Validar(patenteVieja));
            var patenteNueva = "AA 999 AA";
            Console.WriteLine(ValidadorPatente.Validar(patenteNueva));
            var patenteVieja2 = "SD1 590";
            Console.WriteLine(ValidadorPatente.Validar(patenteVieja2));
            var patenteNueva2 = "AA 999 9A";
            Console.WriteLine(ValidadorPatente.Validar(patenteNueva2));

        }
    }
}