using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1PrograII
{
    public class Matricula : ICalculoNota
    {
        public Alumno Alumno { get; set; }
        public Asignatura Asignatura { get; set; }
        public List<double> NotasParciales { get; set; }

        public double CalcularNotaFinal()
        {
            double suma = 0;
            foreach (var nota in NotasParciales)
            {
               suma += nota;
            }
            return suma;
        }

        public double CalcularNotaFinal(double n1, double n2, double n3)
        {             
            double suma = n1 + n2 + n3;
            return suma;
        }   

        public string ObtenerMensajeNota (double notaFinal)
        {
            if (notaFinal >= 0 && notaFinal <= 59)
            {
                return "Reprobado";
            }
            else if (notaFinal >= 60 && notaFinal <= 79)
            {
                return "Bueno";
            }
            else if (notaFinal >= 80 && notaFinal <= 89)
            {
                return "Muy Bueno";
            }
            else if (notaFinal >= 90 && notaFinal <= 100)
            {
                return "Sobresaliente";
            }

            return "Nota fuera de rango";
        }

        public void ValidarNotas(double n1, double n2, double n3)
        {
            if (n1+n2 >30 || n3>40)
            {
                throw new ArgumentOutOfRangeException("Fuera de rango en notas parciales");
            }
        }




    }
}
