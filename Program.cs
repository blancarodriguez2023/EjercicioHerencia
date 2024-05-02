using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Area area = new Area();
            area.num1 = 4;
            area.Calcular();

            longitud longitud = new longitud();
            longitud.num1 = 5;
            longitud.Calcular();

            Volumen volumen = new Volumen();
            volumen.num1 = 4;
            volumen.num2 = 7;
            volumen.Calcular();


            Console.ReadKey();
        }
    }

    public class Operaciones
    {

        public double num1 { get; set; }
        public double num2 { get; set; }

    }

    public class Area : Operaciones 
    {
        
        public double respuesta;

        public void Calcular()
        {

            respuesta = num1 * num1;
            Console.WriteLine(respuesta);     

        }

    }

    public class longitud : Operaciones
    {

        public double respuesta;

        public void Calcular()
        {
            respuesta = 2 * Math.PI * num1;
            Console.WriteLine(respuesta);
                                 // Radio Circunferencia
        }

    }
    public class Volumen : Operaciones
    {

        public double respuesta;

        public void Calcular()
        {
            respuesta = Math.PI * Math.Pow(num1,2) * num2;
            Console.WriteLine(respuesta);

                                // Radio Cilindro  Altura Cilindro

        }

    }


}
