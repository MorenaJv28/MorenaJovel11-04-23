using Laboratorio2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2.DAO
{
    public class CrudNotas
    {
        NotaEstudianteContext db = new NotaEstudianteContext();

        public void AgregarNota(Notum ParametroNota)
        {
           Notum Nota = new Notum();

            Nota.NombreEstudiante = ParametroNota.NombreEstudiante;
            Nota.Materia = ParametroNota.Materia;
            Nota.Lab1 = ParametroNota.Lab1;
            Nota.Parcial1 = ParametroNota.Parcial1;
            Nota.Lab2 = ParametroNota.Lab2;
            Nota.Parcial2 = ParametroNota.Parcial2;
            Nota.Lab3 = ParametroNota.Lab3;
            Nota.Parcial3 = ParametroNota.Parcial3;
            Nota.Resultado = ParametroNota.Resultado;
            db.Add(Nota);
            db.SaveChanges();
        }

        public List<Notum> ListarNotum()
        {
            return db.Nota.ToList();
        }
        
        public String Promedio(Notum Pro)
        {
            var Periodo1 = (Pro.Lab1 * Convert.ToDecimal(0.4)) + (Pro.Parcial1 * Convert.ToDecimal(0.6));
            var Periodo2 = (Pro.Lab2 * Convert.ToDecimal(0.4)) + (Pro.Parcial2 * Convert.ToDecimal(0.6));
            var Periodo3 = (Pro.Lab3 * Convert.ToDecimal(0.4)) + (Pro.Parcial3 * Convert.ToDecimal(0.6));

            Pro.Resultado = decimal.Round(Convert.ToDecimal((Periodo1 + Periodo2 + Periodo3) / 3), 2);

            return $"\nSu resultado es: {Pro.Resultado}";

        }

    }
}
