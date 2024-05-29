using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using datos;
using dominio;


namespace WindowsFormsApp1

{
    public partial class frmAlumnos : Form

    {
        private List<Alumno> listAlumno;

        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            cboDanza.Items.Add("Jazz");
            cboDanza.Items.Add("Arabe");
            cboDanza.Items.Add("Reggaeton");
            cboDanza.Items.Add("Urbano");
            cboDanza.Items.Add("Clasico");

            cboCategoria.Items.Add("Infantil");
            cboCategoria.Items.Add("Iniciacion");
            cboCategoria.Items.Add("Juvenil");
            cboCategoria.Items.Add("Mayores");
        }
        private void cargar() 
        {
            try
            {
                AlumnoNegocio negocio = new AlumnoNegocio();
                listAlumno = negocio.listar();
                dgvAlumno.DataSource = listAlumno;
                ocultarColumnas(); 
                cargarImagen(listAlumno[0].Imagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ocultarColumnas()
        {
            dgvAlumno.Columns["Imagen"].Visible = false;
            dgvAlumno.Columns["Id"].Visible = false;

        }


        private void DgvAlumno_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvAlumno.CurrentRow != null)
            {
                Alumno seleccionado = (Alumno)dgvAlumno.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagen);
            }

        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxAlumnos.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxAlumnos.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
            }
        }

        private void agregarAlumno_Click(object sender, EventArgs e)
        {
            frmAgregarAlumno alta = new frmAgregarAlumno();
            alta.ShowDialog();
            cargar();
        }

        private void modificarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarTexto())
                    return;

                Alumno seleccionado;
                seleccionado = (Alumno)dgvAlumno.CurrentRow.DataBoundItem;
                frmAgregarAlumno modificar = new frmAgregarAlumno(seleccionado);
                modificar.ShowDialog();
                cargar();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Algo salio mal,volvamos a intentarlo");
            }
        }
        private bool validarTexto()
           
        {


            if (dgvAlumno.CurrentRow == null)
            {
                MessageBox.Show("Debes seleccionar un alumno");
                return true;
            }
          
            return false;
        }




        private void txtFiltro_TextChanged(object sender, EventArgs e)
       {
            List<Alumno> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listAlumno.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Danza.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Apellido.ToUpper().Contains(filtro.ToUpper())|| x.añoRendido.ToString().Contains(filtro) || x.Id.ToString().Contains(filtro) || x.Numero_Telefono.ToString().Contains(filtro));

            }
            else
            {
                listaFiltrada = listAlumno;
            }

            dgvAlumno.DataSource = null;
            dgvAlumno.DataSource = listaFiltrada;
            ocultarColumnas();
        }



        private void eliminarAlumno_Click(object sender, EventArgs e)
        {
                        AlumnoNegocio articulo = new AlumnoNegocio();
            Alumno seleccionado;

            try
            {
                if (validarTexto())
                    return;

                
                DialogResult resultado = MessageBox.Show("¿Queres eliminar este Alumno?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
               
                if(resultado == DialogResult.OK)
                {
                    seleccionado = (Alumno)dgvAlumno.CurrentRow.DataBoundItem;
                    articulo.eliminar(seleccionado.Id);
                        MessageBox.Show("Se Eliminó correctamente");
                    cargar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }
        private bool validarBusqueda()
        {
            if (cboDanza.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione una danza para la busqueda");
                return true;
            }
            if (cboCategoria.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione una categooria de busqueda");
                return true;
            }
            return false;
        }
        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            AlumnoNegocio alumn = new AlumnoNegocio();
            try
            {
                if (validarBusqueda())
                    return;
                string danza = cboDanza.SelectedItem.ToString();
                string categoria = cboCategoria.SelectedItem.ToString();
                dgvAlumno.DataSource = alumn.filtrar(danza, categoria);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
