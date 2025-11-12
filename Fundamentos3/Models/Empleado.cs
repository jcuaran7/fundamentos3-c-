using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos3.Models
{
    internal class Empleado
    {
        public string Nombre {  get; set; }
        public int Edad { get; set; }
        public double Salario { get; set; }

        public Empleado( string Nombre, int Edad, double Salario) { 
            this.Nombre = Nombre;
            this.Edad = Edad;  
            this.Salario = Salario;
        }

        public virtual void Trabajar()
        {
            Console.WriteLine($"{Nombre} está trabajando");
        }
    }
}
