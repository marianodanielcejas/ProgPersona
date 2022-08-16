using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string Nombre;
        private int DNI;
        private DateTime FechaNacimiento;
        public Persona()
        {

        }
        public Persona(string Nombre, int DNI, DateTime FechaNacimiento)
        {
            this.Nombre = Nombre;
            this.DNI = DNI;
            this.FechaNacimiento = FechaNacimiento;
        }

        public string P_NOMBRE
        {
            set { Nombre = value; }
            get { return Nombre; }
        }
        public int P_DNI
        {
            set { DNI = value; }
            get { return DNI; }
        }

        public DateTime P_FechaNacimiento
        {
            set { FechaNacimiento = value; }
            get { return FechaNacimiento; }
        }

        public double DevolucionEdad()
        {
            //DateTime.today (La fecha de hoy)
            // int años = DateTime.Now.Year - FechaNacimiento.Year;
            TimeSpan diferencia = DateTime.Now - FechaNacimiento; //necesario por que si restamos solo el año da 1 año mas pero no toma en cuenta los meses.
            //aqui obtenemos el tiempo con la variable TimeSpan
            //Entonces ahora si vamos a sacar los dias.
            double dias = diferencia.TotalDays;
            double años = Math.Floor(dias / 365);
            return años;
        }
    }
}
