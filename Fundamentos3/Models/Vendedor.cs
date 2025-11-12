using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos3.Models
{
    internal class Vendedor : Empleado, ICalculable, IReportable
    { 
        public double Comision { get; set; }

        public Vendedor(string nombre, int edad, double salario, double comision)
            : base(nombre, edad, salario)
        {
            Comision = comision;
        }

        public void Vender()
        {
            Console.WriteLine($"{Nombre} está Vendiendo producto con {Comision}% de Comision");
        }

        public override void Trabajar()
        {
            Console.WriteLine($"{Nombre} está trabajando vendiendo productos ");
        }

        public double CalcularSalarioTotal()
        {
            double SalarioComision= Salario * (Comision / 100);
            return Salario + SalarioComision;
        }

        public void GenerarReporte()
        {
            Console.WriteLine($"Nombre:{Nombre}, Edad:{Edad}, Salario:{Salario}, Comision: {Comision}, Salario total: {CalcularSalarioTotal()}");

        }

    }
}
