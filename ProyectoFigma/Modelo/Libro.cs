using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFigma.Modelo
{
    public class Libro
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Escritor { get; set; }
        public int Ano_Edicion { get; set; }
        public string Sinopsis { get; set; }
        public int Disponible { get; set; }
    }
}
