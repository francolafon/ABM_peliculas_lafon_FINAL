using System;
using System.Data;
using System.Data.OleDb;
using CE;


namespace CD
{
    public class ABMDatos : ConexionBD
    {
        //CARGA DE LISTADO
        public DataSet listaPeliculas(string cual)
        {
            string orden = string.Empty;

            if (cual != "Cargar")
                // orden = "SELECT Peliculas.id_pel, Peliculas.titulo, Peliculas.id_categoria, Peliculas.id_director, Peliculas.id_productora,  Peliculas.desc_pel, Peliculas.cant_pel, Peliculas.anio_pel FROM Peliculas WHERE id_pel = " + int.Parse(cual) + ";";
                //orden = "SELECT Peliculas.id_pel, Peliculas.titulo, Peliculas.id_categoria, Peliculas.id_director, Peliculas.id_productora,  Peliculas.desc_pel, Peliculas.cant_pel, Peliculas.anio_pel FROM Peliculas WHERE id_pel = " + int.Parse(cual) + ";";
                orden = "SELECT Peliculas.id_pel, Peliculas.titulo, Categoria.id_categoria, Director.id_director, Productora.id_productora, Peliculas.desc_pel, Peliculas.cant_pel, Peliculas.anio_pel FROM Productora INNER JOIN(Director INNER JOIN(Categoria INNER JOIN Peliculas ON Categoria.id_categoria = Peliculas.id_categoria) ON Director.id_director = Peliculas.id_director) ON Productora.id_productora = Peliculas.id_productora WHERE id_pel = " + int.Parse(cual) + ";";
            
            else
                //orden = "SELECT Peliculas.id_pel, Peliculas.titulo, Peliculas.id_categoria, Peliculas.id_director, Peliculas.id_productora,  Peliculas.desc_pel, Peliculas.cant_pel, Peliculas.anio_pel FROM Peliculas;";
                //orden = "SELECT Peliculas.id_pel, Peliculas.titulo, Peliculas.id_categoria, Director.nomb_director, Peliculas.id_productora,  Peliculas.desc_pel, Peliculas.cant_pel, Peliculas.anio_pel FROM Peliculas INNER JOIN Director ON Peliculas.id_director =Director.id_director;";
                orden = "SELECT Peliculas.id_pel, Peliculas.titulo, Categoria.nomb_categoria, Director.nomb_director, Productora.nomb_productora, Peliculas.desc_pel, Peliculas.cant_pel, Peliculas.anio_pel FROM Productora INNER JOIN(Director INNER JOIN(Categoria INNER JOIN Peliculas ON Categoria.id_categoria = Peliculas.id_categoria) ON Director.id_director = Peliculas.id_director) ON Productora.id_productora = Peliculas.id_productora;";

            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();

            try
            {
                AbrirConexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Profesores", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return ds;
        }

        //ALTA BAJA Y MODIFICAR
        public int ABM_Pelicula(string accion, Peliculas ObjPelicula)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "INSERT")

                //orden = "INSERT INTO ALUMNO (Nombre, Apellido, Domicilio, DNI, FechaNac, Telefono, Email, idProv, idLoc, AnioCurs, Division, Turno) VALUES ('" + ObjAlumno.p_nomb + "', '" + ObjAlumno.p_apell + "', '" + ObjAlumno.p_dom + "', " + ObjAlumno.p_dni + ", '" + ObjAlumno.p_fechaNac + "', " + ObjAlumno.p_tel + ", '" + ObjAlumno.p_mail + "', " + ObjAlumno.p_idProv + ", " + ObjAlumno.p_idLoc + ", " + ObjAlumno.p_AnioLect + ", '" + ObjAlumno.p_div + "', '" + ObjAlumno.p_turno + "');";
                //orden = "INSERT INTO Peliculas (id_director,id_categoria,id_productora,titulo,desc_pel,cant_pel,anio_pel) VALUES(" + ObjPelicula.Id_director + ", " + ObjPelicula.Id_categoria + ", " + ObjPelicula.Id_productora + ", '" + ObjPelicula.Titulo + "', '" + ObjPelicula.Desc_pel + "', " + ObjPelicula.Cant_pel + ", " + ObjPelicula.Anio_pel +");";
                //orden = "INSERT INTO Peliculas (id_director,id_categoria,id_productora,titulo,desc_pel,cant_pel,anio_pel) VALUES(1, 1, 1, '" + ObjPelicula.Titulo + "', '" + ObjPelicula.Desc_pel + "', 3, 2023); ";
                orden = "INSERT INTO Peliculas (id_director,id_categoria,id_productora,titulo,desc_pel,cant_pel,anio_pel) VALUES(" + ObjPelicula.Id_director + ", " + ObjPelicula.Id_categoria + ", " + ObjPelicula.Id_productora + ", '" + ObjPelicula.Titulo + "', '" + ObjPelicula.Desc_pel + "'," + ObjPelicula.Cant_pel + "," + ObjPelicula.Anio_pel + "); ";

            if (accion == "DELETE")
                orden = "DELETE FROM Peliculas WHERE(id_pel = " + ObjPelicula.Id_pel + ")";
            //if (accion == "UPDATE")
                //orden = "UPDATE Peliculas SET Nombre = '" + ObjAlumno.p_nomb + "', Apellido = '" + ObjAlumno.p_apell + "', Domicilio = '" + ObjAlumno.p_dom + "', DNI = " + ObjAlumno.p_dni + ", FechaNac = '" + ObjAlumno.p_fechaNac + "', Telefono = " + ObjAlumno.p_tel + ", Email = '" + ObjAlumno.p_mail + "', idProv = " + ObjAlumno.p_idProv + ", idLoc = " + ObjAlumno.p_idLoc + ", AnioCurs = " + ObjAlumno.p_AnioLect + ", Division = '" + ObjAlumno.p_div + "', Turno = '" + ObjAlumno.p_turno + "' WHERE idPersona= " + ObjAlumno.p_id + ";";
            

            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            try
            {
                AbrirConexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de Agregar, Borrar o Modificar una pelicula", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return resultado;
        }
    }
}

