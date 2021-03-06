using P1Acrud13.Clases.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace P1Acrud13.Clases.Servicio
{
    public  class ClsImportExport
    {
        private ClsConexion cone;
        public ClsImportExport()
        {
            cone = new();
        }


        public string importar(string archivo)
        {
            string texto = "";
            try
            {
                texto = File.ReadAllText(archivo);
                return $"Procesados: { cone.EjecutarSQLDirecto(texto)}";

            }catch(Exception ex)
            {
                return $"Hubo un error al importar {ex.Message}";
            }

        }

        public string exportar(string instruccion, string archivoDestino)
        {
            string textoSalida = "";
            DataTable respuesta = cone.ConsulaTabaDirecta(instruccion);

            foreach (DataRow dr in respuesta.Rows)
            {
                textoSalida += $"{dr["codigo"]};{dr["nombre"]};{dr["marca"]};{dr["tipo"]};{dr["estante"]};{dr["existencia"]};{dr["ventas"]};{dr["precio"]}\n";
            }
            if ( !string.IsNullOrEmpty(textoSalida) )
            {
                try
                {
                    File.WriteAllText(archivoDestino, textoSalida);
                    return $"Procesado o creado archivo{archivoDestino}";

                }catch (Exception ex)
                {
                    return $"Hay clavo en el archivo{ex.Message}";

                }
            }
            return "No se encontraron registros";
        }
    }
}
