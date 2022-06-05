using P1Acrud13.Clases.edentidades;
using P1Acrud13.Clases.Servicio;
using System.Data;

namespace WFP1AC14
{
    public partial class Form1 : Form
    {
        ServicioAlumno srvAlumno = new();
        MdAlumno oAlumno = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void DesplegarGrid()
        {
          var respuesta = srvAlumno.ConsultaSQL("select * from Productos");
            dataGridViewAlumnos.DataSource = respuesta;  
        }

        private void buttonObtenerDatos_Click(object sender, EventArgs e)
        {
            DesplegarGrid();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void MapaDatosFormulario(MdAlumno _alumno)
        {
            textBoxCarnet.Text = _alumno.codigo;
            textBoxNombre.Text = _alumno.nombre;
            textBoxCorreo.Text = _alumno.marca;
            comboBoxClase.Text = _alumno.tipo;
            textBoxEstante.Text = _alumno.estante;
            textBoxParcial1.Text = _alumno.existencia.ToString();
            textBoxParcial2.Text = _alumno.ventas.ToString();
            textBoxParcial3.Text = _alumno.precio.ToString();

        }


        private void LimpiarDatos()
        {
            oAlumno = new();
            MapaDatosFormulario(oAlumno);
        }
        private void buscarAlumno(string codigo)
        {
            oAlumno = null;
            oAlumno = srvAlumno.ObtenerAlumno(codigo);
            if (oAlumno == null)
            {
                MessageBox.Show("no existe ese producto");
                LimpiarDatos();
            }
            else
            {
                MapaDatosFormulario(oAlumno);
            }
        }
        
        private void consulta()
        {
            string codigo = textBoxCarnet.Text;
            buscarAlumno(codigo);
        }
        private void buttonConsulta_Click(object sender, EventArgs e)
        {
           consulta();
        }

        private MdAlumno DatosFormulario()
        {
            MdAlumno _alumno = new();
            _alumno.codigo = textBoxCarnet.Text.Trim();
            _alumno.nombre = textBoxNombre.Text.Trim();
            _alumno.marca = textBoxCorreo.Text.Trim();
            _alumno.tipo  = comboBoxClase.Text;
            _alumno.estante= textBoxEstante.Text;
            _alumno.existencia = Convert.ToInt32(textBoxParcial1.Text.Trim());
            _alumno.ventas = Convert.ToInt32(textBoxParcial2.Text.Trim());
            _alumno.precio = Convert.ToInt32(textBoxParcial3.Text.Trim());
            return _alumno;

        }     
        private void actualizacion()
        {
            string nombre = "";
            oAlumno = DatosFormulario();
            int respuesta = srvAlumno.actualizarAlumno(oAlumno);
            if (respuesta > 0)
            {
                MessageBox.Show("Producto acualizado");
                nombre = oAlumno.nombre;
                LimpiarDatos();
                DesplegarGrid();
                
            }
            else
            {
                MessageBox.Show("Perdon hay un problema con la Grabacion");
            }
            textBoxNombre.Text = nombre;
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            actualizacion();
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Exportacion()
        {
            string archivo = @"C:\Users\Usuario\Documents\Exportaciones\salida.csv";
            ClsImportExport im = new();
            MessageBox.Show(im.exportar("select * from Productos ", archivo));
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            Exportacion();
        }

        private void BorrarAlumno()
        {
            string codigo = textBoxCarnet.Text;
            oAlumno = srvAlumno.ObtenerAlumno(codigo);
            if (oAlumno == null)
            {
               

                MessageBox.Show("El producto no existe");
            }
            else
            {
                MessageBox.Show("Producto eliminado");
                srvAlumno.BorrarAlumno(oAlumno);
                LimpiarDatos();
                DesplegarGrid();    
            }
        }

        private void buttonBorrarAlumno_Click(object sender, EventArgs e)
        {
            BorrarAlumno();
        }
    }
} 