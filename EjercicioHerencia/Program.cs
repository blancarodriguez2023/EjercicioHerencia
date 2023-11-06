using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{

    public class Animal
    {


        public string nombre { get; set; }
        public string familia { get; set; }
        public string tamano { get; set; }

        public string color { get; set; }

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public string Color
        {
            set
            {
                color = value;
            }
            get
            {
                return color;
            }
        }
        public string Tamano
        {
            set
            {
                tamano = value;
            }
            get
            {
                return tamano;
            }
        }

        public string Familia
        {
            protected set
            {
                familia = value;
            }
            get
            {
                return familia;
            }


        }
    }


    public class Vertebrado : Animal
    {
        public string tipo { get; set; }
        public string tienePatas { get; set; }
        public string esDomestico { get; set; }
        public string esHerbivoro { get; set; }
        public string esCarnivoro { get; set; }

        public void Imprimir()
        {
            Console.WriteLine("Vertebrado");
            Console.WriteLine("Nombre:" + Nombre);
            Console.WriteLine("Color:" + Color);
            Console.WriteLine("Tamano:" + Tamano);
            Console.WriteLine("Familia:" + Familia);
            Console.WriteLine("tienePatas:" + tienePatas);
            Console.WriteLine("esDomestico:" + esDomestico);
            Console.WriteLine("esHerbivoro:" + esHerbivoro);
            Console.WriteLine("esCarnivoro:" + esCarnivoro);
            Console.WriteLine("============================");

        }

    }

    public class Invertebrado : Animal
    {
        public string tipo { get; set; }
        public string tienePatas { get; set; }
        public string numeroPatas { get; set; }
        public string tieneConcha { get; set; }

        public void Imprimir()
        {
            Console.WriteLine("============================");
            Console.WriteLine("Invertebrado");
            Console.WriteLine("tipo:" + tipo);
            Console.WriteLine("Nombre:" + Nombre);
            Console.WriteLine("Tamano:" + Tamano);
            Console.WriteLine("Familia:" + Familia);
            Console.WriteLine("Color:" + Color);
            Console.WriteLine("tienePatas:" + tienePatas);
            Console.WriteLine("numeroPatas:" + numeroPatas);
            Console.WriteLine("tieneConcha:" + tieneConcha);

        }

    }

    class Prueba
    {
        static void Main(string[] args)
        {


            Vertebrado gato = new Vertebrado();
            gato.Nombre = "Gato";
            gato.Color = "gris";
            gato.familia = "raza ruso";
            gato.tamano = "pequeno";
            gato.tipo = "mamifero";
            gato.tienePatas = "Si";
            gato.esDomestico = "Si";
            gato.esCarnivoro = "Si";
            gato.esHerbivoro = "No";
            gato.Imprimir();

            Vertebrado Perro = new Vertebrado();
            Perro.Nombre = "Perro";
            Perro.Color = "Pueden variar";
            Perro.familia = "Chihuahua";
            Perro.tamano = "pequeno";
            Perro.tipo = "mamifero";
            Perro.tienePatas = "Si";
            Perro.esDomestico = "Si";
            Perro.esCarnivoro = "Si";
            Perro.esHerbivoro = "No";
            Perro.Imprimir();



            Invertebrado Hormiga = new Invertebrado();
            Hormiga.Nombre = "Hormiga";
            Hormiga.Color = "Rojizo";
            Hormiga.familia = "Hormiga bala"
            Hormiga.tamano = "diminuto";
            Hormiga.tipo = "artropodos";
            Hormiga.tienePatas = "Si";
            Hormiga.numeroPatas = "6";
            Hormiga.tieneConcha = "No";
            Hormiga.Imprimir();

          

            Invertebrado Zancudo = new Invertebrado();
            Zancudo.Nombre = "Zancudo";
            Zancudo.tamano = "diminuto";
            Zancudo.tipo = "artropodos";
            Zancudo.tienePatas = "Si";
            Zancudo.numeroPatas = "Si";
            Zancudo.tieneConcha = "No";
            Zancudo.Imprimir();


        }
    }
}

