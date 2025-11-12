using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos3.Models
{
    internal class Desarrollador : Empleado, ICalculable, IReportable
    {
        public string LenguajeFavorito { get; set; }

        public Desarrollador(string nombre, int edad, double salario, string lenguajeFavorito)
            : base(nombre, edad, salario)
        {
            LenguajeFavorito = lenguajeFavorito;
        }

        public void Programar()
        {
            Console.WriteLine($"{Nombre} está Programando en el lenguaje {LenguajeFavorito}");
        }

        public override void Trabajar()
        {
            Console.WriteLine($"{Nombre} está trabajando escribiendo código");
        }

        public double CalcularSalarioTotal()
        {
            double SalarioBono = Salario * 0.10;
            return Salario + SalarioBono;
        }

        public void GenerarReporte()
        {
            double SalarioBono = Salario * 0.10;
            Console.WriteLine($"Nombre:{Nombre}, Edad:{Edad}, Lenguaje Favorito:{LenguajeFavorito}, Salario:{Salario}, Salario total: {Salario + SalarioBono}");
        }
    }
}
