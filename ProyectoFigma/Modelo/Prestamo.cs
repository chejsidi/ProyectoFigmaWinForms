using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFigma.Modelo
{
    public class Prestamo
    {
        public int Id { get; set; }
        public int ID_Libro { get; set; }
        public int ID_Usuario { get; set; }
        public string Fecha_Inicio { get; set; }
        public string Fecha_Fin { get; set; }
    }
}
