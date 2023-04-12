using Laboratorio2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2.DAO
{
    public class ClsNotas
    {
        public void Guardar(Notum notas)
        {
            using (NotaEstudianteContext context = new NotaEstudianteContext())
            {
                context.Add(notas);
                context.SaveChanges();
            }
        }
        public void CalcularResultado(Notum notas)
        {

            var Periodo1 = (notas.Lab1 * Convert.ToDecimal(0.4)) + (notas.Parcial1 * Convert.ToDecimal(0.6));
            var Periodo2 = (notas.Lab2 * Convert.ToDecimal(0.4)) + (notas.Parcial2 * Convert.ToDecimal(0.6));
            var Periodo3 = (notas.Lab3 * Convert.ToDecimal(0.4)) + (notas.Parcial3 * Convert.ToDecimal(0.6));

            notas.Resultado = (Periodo1 + Periodo2 + Periodo3) / 3;

        }
        public List<Notum> Listar()
        {
            using (NotaEstudianteContext context = new NotaEstudianteContext())
            {
                return context.Nota.ToList();
            }

        }

    }

}
