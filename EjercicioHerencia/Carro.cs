
namespace EjercicioHerencia
{
    public class Carro : Vehiculo
    {
        public int NumeroPuertas { get; set; }
        public string TipoCombustible { get; set; }

        public override void MostrarInformacion()

        {
            base.MostrarInformacion();
            Console.WriteLine($"Número de puertas: {NumeroPuertas}");
            Console.WriteLine($"Tipo de combustible: {TipoCombustible}");
            Console.WriteLine("-----------------------------");
        }
    }

}

