using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fundamentos3.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;



namespace Program.cs
{
    class Program
    {
        public static void Main(string[] args)
        {
            Gerente gerente = new Gerente("Juan", 40, 80000, "Nariño");
            gerente.Trabajar();
            gerente.Supervisar();
            gerente.CalcularSalarioTotal();
            gerente.GenerarReporte();   
            gerente.Promover();

            Desarrollador desarrollador = new Desarrollador("Maria",25,60000,"C#");
            desarrollador.Trabajar();
            desarrollador.Programar();
            desarrollador.CalcularSalarioTotal();
            desarrollador.GenerarReporte();

            Desarrollador desarrollador2 = new Desarrollador("Carlos",28,65000,"Python");
            desarrollador2.Trabajar();
            desarrollador2.Programar();
            desarrollador2.CalcularSalarioTotal();
            desarrollador2.GenerarReporte();

            Vendedor vendedor = new Vendedor("Ana",30,50000,15);
            vendedor.Trabajar();
            vendedor.Vender();
            vendedor.CalcularSalarioTotal();
            vendedor.GenerarReporte();

            List<Empleado> empleados = new List<Empleado>();


            empleados.Add(gerente);
            empleados.Add(desarrollador);
            empleados.Add(desarrollador2);
            empleados.Add(vendedor);

            //foreach (Empleado emp in empleados)
            //{
            //    emp.Trabajar();
            //}


            Console.WriteLine("\n=== CALCULANDO SALARIOS ===");
            foreach (Empleado emp in empleados)  // ← Elimina el if externo
            {
                if (emp is ICalculable calculable)  // ← Este sí está bien
                {
                    double total = calculable.CalcularSalarioTotal();
                    Console.WriteLine($"{emp.Nombre}: ${total}");
                }
            }

            Console.WriteLine("\n=== GENERANDO REPORTES ===");
            foreach (Empleado emp in empleados)  // ← Elimina el if externo
            {
                if (emp is IReportable reportable)
                {
                    reportable.GenerarReporte();
                    Console.WriteLine();
                }
            }

            Console.WriteLine("\n=== PROMOVIENDO EMPLEADOS ===");
            foreach (Empleado emp in empleados)  // ← Elimina el if externo
            {
                if (emp is IPromovible promovible)
                {
                    promovible.Promover();
                }
            }



        }


    }
}