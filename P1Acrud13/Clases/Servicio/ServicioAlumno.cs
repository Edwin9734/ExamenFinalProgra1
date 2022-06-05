using P1Acrud13.Clases.CapaDatos;
using P1Acrud13.Clases.edentidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P1Acrud13.Clases.Servicio
{
    public class ServicioAlumno
    {
        ClsConexion cone = new ClsConexion();
        

        public DataTable ConsultaSQL(string instruccion)
        {

            DataTable respuesta = cone.ConsulaTabaDirecta(instruccion);
            return respuesta;            
        }

        
   
        public int CrearAlumno( MdAlumno alu)
        {
            string instruccion = $"insert into Productos (codigo,nombre,estante,Tipo,marca,) values('{alu.codigo}','{alu.nombre}','{alu.estante}','{alu.tipo}','{alu.marca}')";
             return cone.EjecutarSQLDirecto(instruccion);   
        }

        public MdAlumno ObtenerAlumno(string codigo)
        {

            MdAlumno alu = new MdAlumno();

            DataTable resp = cone.ConsulaTabaDirecta($"select * from Productos where codigo ='{codigo}'");
            if (resp.Rows.Count > 0)
            {
                foreach (DataRow item in resp.Rows)
                {
                    
                    alu.codigo = item["codigo"].ToString();
                    alu.nombre = item["nombre"].ToString();
                    alu.estante = item["estante"].ToString();
                    alu.tipo = item["Tipo"].ToString();
                    alu.marca = item["marca"].ToString();
                    alu.existencia = (Int32)item["existencia"];
                    alu.ventas = (Int32)item["ventas"];
                    alu.precio = (Int32)item["precio"];

                }
                return alu;
            }
            else
            {
                return null;
            }
        }

        public int actualizarAlumno(MdAlumno alu)
        {
            string instruccion = $"update Productos set  nombre = '{alu.nombre}', marca = '{alu.marca}', tipo = '{alu.tipo}',estante= '{alu.estante}' , existencia =  '{alu.existencia}', ventas =  '{alu.ventas}',precio =  '{alu.precio}' where codigo ='{alu.codigo}'";
            return cone.EjecutarSQLDirecto(instruccion);
        }

        public int BorrarAlumno(MdAlumno alu)
        {
            string instruccion = $"delete from Productos where   codigo = '{alu.codigo}' ";
            return cone.EjecutarSQLDirecto(instruccion);
        }

    }
}
