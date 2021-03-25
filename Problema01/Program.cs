using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema12
{
    class problema02
    {
        private string[] nombresEmpleados;
        private float[] salariosEmpleados;

        public void Cargar()
        {
            nombresEmpleados = new string[5];
            salariosEmpleados = new float[5];
            for (int f = 0; f < nombresEmpleados.Length; f++)
            {
                Console.Write("Ingrese el nombre del empleado:");
                nombresEmpleados[f] = Console.ReadLine();
                Console.Write("Ingrese el sueldo:");
                string linea;
                linea = Console.ReadLine();
                salariosEmpleados[f] = float.Parse(linea);
            }
        }

        public void MayorSueldo()
        {
            float mayor;
            int pos;
            mayor = salariosEmpleados[0];
            pos = 0;
            for (int f = 1; f < nombresEmpleados.Length; f++)
            {
                if (salariosEmpleados[f] > mayor)
                {
                    mayor = salariosEmpleados[f];
                    pos = f;
                }
            }
            Console.WriteLine("El empleado con salario mayor es " + nombresEmpleados[pos]);
            Console.WriteLine("Tiene un salario:" + mayor);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            problema02 pv = new problema02();
            pv.Cargar();
            pv.MayorSueldo();
        }
    }
}