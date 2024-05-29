using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Alumno
    {
      
        public int Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set;}
        public Danza Danza { get; set; }
        public Categoria Categoria { get; set; }
        public int Dni { get; set;}
        public string Imagen { get; set;}
        public int añoRendido { get; set; }
        public long Numero_Telefono { get; set; }






    }
}
