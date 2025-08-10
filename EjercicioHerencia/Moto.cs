

namespace EjercicioHerencia
{
   public class Moto: Vehiculo
    {
         
        public int Cilindrada { get; set; }
        public bool TieneMaletero { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Cilindrada: {Cilindrada} cc");
            Console.WriteLine($"Tiene maletero: {(TieneMaletero ? "Sí" : "No")}");
            Console.WriteLine("-----------------------------");
        }
    }
}
