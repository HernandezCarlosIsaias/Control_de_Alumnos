using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using datos;
using System.Xml.Linq;
using System.IO;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class frmAgregarAlumno : Form
    {
        private Alumno alumno = null;
        private OpenFileDialog archivo = null;
        public frmAgregarAlumno()
        {
            InitializeComponent();
        }
        public frmAgregarAlumno(Alumno alumno)
        {
            InitializeComponent();
            this.alumno = alumno;
            Text = "Modificar Alumno";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool soloNumeros(string cadena)
        {
            decimal number;
            return decimal.TryParse(cadena,out number);
        }
        private bool validarAñoRendido()
        {
            if (string.IsNullOrEmpty(txtAñoRendido.Text))
            {
                MessageBox.Show("Debes cargar el año rendido");
                return true;
            }

            if (!(soloNumeros(txtAñoRendido.Text))) 
            {
                MessageBox.Show("Solo se puede ingresar números para el año rendido");
                return true;
            }
            return false;
        }
        private bool validarDni()
        {
            if (string.IsNullOrEmpty(txtDni.Text))
            {
                MessageBox.Show("Debes cargar el DNI");
                return true;
            }

            if (!(soloNumeros(txtDni.Text)))
            {
                MessageBox.Show("Solo se puede ingresar números para el DNI");
                return true;
            }
            return false;
        }


        private bool validarNombre()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debes colocar el nombre del Alumno.");
                return true;
            }
            return false;    
        }
        private bool validarCategoria()
        {
            if (cboCategorias.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione una categoria.");
                return true;
            }
            return false;
        }

         


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            AlumnoNegocio negocio = new AlumnoNegocio();
            try
            {
                if (alumno == null) 
                    alumno = new Alumno();

                alumno.Apellido = txtApellido.Text;
                
                if (validarNombre())
                    return;
                alumno.Nombre = txtNombre.Text;
                if (validarDni())
                    return;
                alumno.Dni = int.Parse(txtDni.Text);
                alumno.Imagen = txtImagen.Text;
                
                if(validarAñoRendido())
                    return;               
                alumno.añoRendido = int.Parse(txtAñoRendido.Text);

                alumno.Categoria = (Categoria)cboCategorias.SelectedItem;
                alumno.Danza = (Danza)cboDanza.SelectedItem;
                alumno.Numero_Telefono = long.Parse(txtTelefono.Text);

                if ( alumno.Id != 0) 
                {
                    negocio.modificar(alumno);
                    MessageBox.Show("Se modifico correctamente");
                }
                else
                {
                    negocio.agregar(alumno);
                    MessageBox.Show("Se agregó correctamente");
                }
                if (archivo != null && !(txtImagen.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["carpetaImagen"] + archivo.SafeFileName);


                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            

        }

        private void frmAgregarAlumnos_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            DanzaNegocio danzaNegocio = new DanzaNegocio();
            try
            {
                cboCategorias.DataSource = categoriaNegocio.listar();
                cboCategorias.ValueMember = "Id";
                cboCategorias.DisplayMember = "Descripcion";
                cboDanza.DataSource = danzaNegocio.listar();
                cboDanza.ValueMember = "Id";
                cboDanza.DisplayMember = "Descripcion";

                if(alumno != null)
                {
                    txtApellido.Text = alumno.Apellido;
                    txtNombre.Text = alumno.Nombre;
                    txtDni.Text = alumno.Dni.ToString();
                    txtAñoRendido.Text = alumno.añoRendido.ToString();
                    txtImagen.Text = alumno.Imagen;
                    cargarImagen(alumno.Imagen);
                    cboCategorias.SelectedValue = alumno.Categoria.Id;
                    cboDanza.SelectedValue = alumno.Danza.Id;
                    txtTelefono.Text = alumno.Numero_Telefono.ToString();
                }


            }
            catch (Exception ex) 
            {
                MessageBox.Show("Algo salío mal, intentemos de nuevo");
            }
            
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxAgregarAlumnos.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxAgregarAlumnos.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if ( archivo.ShowDialog() == DialogResult.OK ) 
            { 
                txtImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

            }
        }
    }
}
