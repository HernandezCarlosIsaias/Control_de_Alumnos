using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using dominio;
using System.Data.SqlClient;

namespace datos
{
    public class AlumnoNegocio 
    {
        public List<Alumno> listar()
        {
            List<Alumno> lista = new List<Alumno>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select A.Id, Apellido, Nombre, Dni, C.descripcion Categoria, D.Descripcion Danza, Imagen, añoRendido, IdDanza, IdCategoria, Numero_Telefono From ALUMNOS A, CATEGORIAS C, DANZAS D where A.IdCategoria = C.Id and A.IdDanza = D.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Alumno aux = new Alumno();
                    if (!(datos.Lector["Id"] is DBNull))
                        aux.Id = (int)datos.Lector["Id"];
                    if (!(datos.Lector["Apellido"] is DBNull))
                        aux.Apellido = (string)datos.Lector["Apellido"];
                    if (!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["Dni"] is DBNull))
                        aux.Dni = (int)datos.Lector["Dni"];
                    if (!(datos.Lector["Imagen"] is DBNull))
                        aux.Imagen = (string)datos.Lector["Imagen"];
                    if (!(datos.Lector["añoRendido"] is DBNull))
                        aux.añoRendido = (int)datos.Lector["añoRendido"];
                    if (!(datos.Lector["Numero_Telefono"] is DBNull))
                        aux.Numero_Telefono= (long)datos.Lector["Numero_Telefono"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Danza = new Danza();
                    aux.Danza.Id = (int)datos.Lector["IdDanza"];
                    aux.Danza.Descripcion = (string)datos.Lector["Danza"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Alumno nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into ALUMNOS (Apellido, Nombre, Dni, IdCategoria, IdDanza, Imagen, añoRendido, Numero_Telefono)values('" + nuevo.Apellido + "', '" + nuevo.Nombre + "', '" + nuevo.Dni + "', @idCategoria, @idDanza, @Imagen , @añoRendido, @Numero_Telefono)");
                datos.setearParametro("@idCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@idDanza", nuevo.Danza.Id);
                datos.setearParametro("@Imagen", nuevo.Imagen);
                datos.setearParametro("@añoRendido", nuevo.añoRendido);
                datos.setearParametro("@Numero_Telefono", nuevo.Numero_Telefono);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void modificar(Alumno alumno)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ALUMNOS set Apellido = @Apellido, Nombre = @nombre, Dni = @DNI, Imagen = @imagen, IdDanza = @idDanza, IdCategoria = @idCategoria, añoRendido = @añoRendido,Numero_Telefono = @Numero_Telefono Where Id = @id");
                datos.setearParametro("@Apellido", alumno.Apellido);
                datos.setearParametro("@nombre", alumno.Nombre);
                datos.setearParametro("@DNI", alumno.Dni);
                datos.setearParametro("@imagen", alumno.Imagen);
                datos.setearParametro("@idDanza", alumno.Danza.Id);
                datos.setearParametro("@idCategoria", alumno.Categoria.Id);
                datos.setearParametro("@añoRendido", alumno.añoRendido);
                datos.setearParametro("@id", alumno.Id);
                datos.setearParametro("@Numero_Telefono", alumno.Numero_Telefono);


                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void eliminar(int Id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("Delete from ALUMNOS where Id = @id");
                datos.setearParametro("@id", Id);
                datos.ejecutarAccion();
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }

        public List<Alumno> filtrar (string danza, string categoria)
        {
            List<Alumno> lista = new List<Alumno>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "Select A.Id, Apellido, Nombre, Dni, C.descripcion Categoria, D.Descripcion Danza, Imagen, añoRendido, IdDanza, IdCategoria, Numero_Telefono From ALUMNOS A, CATEGORIAS C, DANZAS D where A.IdCategoria = C.Id and A.IdDanza = D.Id and ";

                if (danza == "Jazz")
                {
                    switch (categoria)
                    {
                        case "Infantil":
                            consulta += "D.descripcion = 'Jazz' and C.descripcion = 'Infantil ' ";
                            break;
                        case "Iniciacion":
                            consulta += "D.descripcion = 'Jazz' and C.descripcion = 'Iniciacion' ";
                            break;
                        case "Juvenil":
                            consulta += "D.descripcion = 'Jazz' and C.descripcion = 'Juvenil' ";
                            break;
                        case "Mayores":
                                consulta += "D.descripcion = 'Jazz' and C.descripcion = 'Mayores' ";
                            break;
                    }
                }
                else if (danza == "Arabe")
                {
                    switch (categoria)
                    {
                        case "Infantil":
                            consulta += "D.descripcion = 'Arabe' and C.descripcion = 'Infantil' ";
                            break;
                        case "Iniciacion":
                            consulta += "D.descripcion = 'Arabe' and C.descripcion = 'Iniciacion' ";
                            break;
                        case "Juvenil":
                            consulta += "D.descripcion = 'Arabe' and C.descripcion = 'Juvenil' ";
                            break;
                        case "Mayores":
                            consulta += "D.descripcion = 'Arabe' and C.descripcion = 'Mayores' ";
                            break;
                    }
                }
                else if (danza == "Reggaeton")
                {
                    switch (categoria)
                    {
                        case "Infantil":
                            consulta += "D.descripcion = 'Reggaeton' and C.descripcion = 'Infantil' ";
                            break;
                        case "Iniciacion":
                            consulta += "D.descripcion = 'Reggaeton' and C.descripcion = 'Iniciacion' ";
                            break;
                        case "Juvenil":
                            consulta += "D.descripcion = 'Reggaeton' and C.descripcion = 'Juvenil' ";
                            break;
                        case "Mayores":
                            consulta += "D.descripcion = 'Reggaeton' and C.descripcion = 'Mayores' ";
                            break;
                    }
                }
                else if (danza == "Urbano")
                {
                    switch (categoria)
                    {
                        case "Infantil":
                            consulta += "D.descripcion = 'Urbano' and C.descripcion = 'Infantil' ";
                            break;
                        case "Iniciacion":
                            consulta += "D.descripcion = 'Urbano' and C.descripcion = 'Iniciacion' ";
                            break;
                        case "Juvenil":
                            consulta += "D.descripcion = 'Urbano' and C.descripcion = 'Juvenil' ";
                            break;
                        case "Mayores":
                            consulta += "D.descripcion = 'Urbano' and C.descripcion = 'Mayores' ";
                            break;
                    }
                }
                else
                    switch (categoria)
                    {
                        case "Infantil":
                            consulta += "D.descripcion = 'Clasico' and C.descripcion = 'Infantil' ";
                            break;
                        case "Iniciacion":
                            consulta += "D.descripcion = 'Clasico' and C.descripcion = 'Iniciacion' ";
                            break;
                        case "Juvenil":
                            consulta += "D.descripcion = 'Clasico' and C.descripcion = 'Juvenil' ";
                            break;
                        case "Mayores":
                            consulta += "D.descripcion = 'Clasico' and C.descripcion = 'Mayores' ";
                            break;
                    }
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Alumno aux = new Alumno();
                    if (!(datos.Lector["Id"] is DBNull))
                        aux.Id = (int)datos.Lector["Id"];
                    if (!(datos.Lector["Apellido"] is DBNull))
                        aux.Apellido = (string)datos.Lector["Apellido"];
                    if (!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["Dni"] is DBNull))
                        aux.Dni = (int)datos.Lector["Dni"];
                    if (!(datos.Lector["Imagen"] is DBNull))
                        aux.Imagen = (string)datos.Lector["Imagen"];
                    if (!(datos.Lector["añoRendido"] is DBNull))
                        aux.añoRendido = (int)datos.Lector["añoRendido"];
                    if (!(datos.Lector["Numero_Telefono"] is DBNull))
                        aux.Numero_Telefono = (long)datos.Lector["Numero_Telefono"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Danza = new Danza();
                    aux.Danza.Id = (int)datos.Lector["IdDanza"];
                    aux.Danza.Descripcion = (string)datos.Lector["Danza"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex) 
            {
                throw;
            }
        }


    }

}

