
using EjercicioHerencia;


Carro carro1 = new Carro();
carro1.Marca = "Tesla";
carro1.Modelo = "Model S";
carro1.Año = 2023;
carro1.NumeroPuertas = 4;
carro1.TipoCombustible = "Eléctrico";

Carro carro2 = new Carro();
carro2.Marca = "Toyota";
carro2.Modelo = "Corolla";
carro2.Año = 2020;
carro2.NumeroPuertas = 4;
carro2.TipoCombustible = "Gasolina";

Moto moto1 = new Moto();
moto1.Marca = "Yamaha";
moto1.Modelo = "MT-07";
moto1.Año = 2022;
moto1.Cilindrada = 689;
moto1.TieneMaletero = false;

Moto moto2 = new Moto();
moto2.Marca = "Honda";
moto2.Modelo = "CB500X";
moto2.Año = 2021;
moto2.Cilindrada = 500;
moto2.TieneMaletero = true;

Console.WriteLine("***** Información de los carros*****");
carro1.MostrarInformacion();
carro2.MostrarInformacion();

Console.WriteLine("***** Información de las motos*****");
moto1.MostrarInformacion();
moto2.MostrarInformacion();