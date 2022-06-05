using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Acrud13.Clases.edentidades
{
    public class MdAlumno
    {

        public int idProducto { get; set; }
        public string? codigo { get; set; }
        public string? nombre { get; set; }
        public string? estante { get; set; }
        public string? tipo { get; set; }
        public string? marca { get; set; }
        public int existencia { get; set; }
        public int ventas { get; set; }
        public int precio { get; set; }






        public override string ToString()
        {
            return $"id: {idProducto} nombre:{nombre} estante{ estante} Tipo{tipo} marca{marca} existencia{existencia} ventas{ventas} precio{precio}";
        }



    }
}
