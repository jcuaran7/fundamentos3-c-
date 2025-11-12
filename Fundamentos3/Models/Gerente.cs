using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos3.Models
{
    internal class Gerente : Empleado, ICalculable, IReportable, IPromovible
    {
        public string Departamento { get; set; }

        public Gerente(string nombre, int edad, double salario, string departamento)
            : base(nombre, edad, salario)
        {
            Departamento = departamento;
        }

        public void Supervisar()
        {
            Console.WriteLine($"{Nombre} está supervisando el departamento de {Departamento} ");
        }

        public override void Trabajar()
        {
            Console.WriteLine($"{Nombre} está trabajando gestionando el departamento de {Departamento} ");
        }

        public double CalcularSalarioTotal()
        {
            double SalarioBono = Salario * 0.20;
            return Salario + SalarioBono;
        }

        public void GenerarReporte()
        {
            double SalarioBono = Salario * 0.20;
            Console.WriteLine($"Nombre:{Nombre}, Edad:{Edad}, Departamento:{Departamento}, Salario:{Salario}, Salario total: {Salario + SalarioBono}" ) ;
        }

        public void Promover()
        {
            double SalarioPromovido = Salario * 0.15;
            Salario= Salario + SalarioPromovido;
            Console.WriteLine($"{Nombre} Su Salario ha sido promovido a: {Salario}");
        }
    }
}
