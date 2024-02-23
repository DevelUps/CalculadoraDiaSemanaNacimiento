using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDiaSemanaNacimiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que le pida al usuario la fecha de su nacimiento, y nosotros le diremos qué día de la semana era.

            //Campos o variables
            string cadenaFechaNacimiento;
            DateTime dateTimeFechaNacimiento;

            //se solicita la fecha de nacimiento
            Console.Write("Dime la fecha de nacimiento (dia,mes, año..: ");
            cadenaFechaNacimiento = Console.ReadLine();
            // se convierte la cadena en un objeto DateTime
dateTimeFechaNacimiento = DateTime.Parse(cadenaFechaNacimiento);

            Console.WriteLine($"Nacieste un {dateTimeFechaNacimiento.ToString("dddd")}");
           



        }
    }
}
