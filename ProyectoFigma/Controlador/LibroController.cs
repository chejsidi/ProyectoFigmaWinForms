using Microsoft.Data.Sqlite;
using ProyectoFigma.Modelo;
using System.Collections.Generic;

namespace ProyectoFigma.Controlador
{
    public class LibroController
    {
        private string conexion = "Data Source=Biblioteca.db";

        public List<Libro> ObtenerLibros()
        {
            List<Libro> lista = new List<Libro>();

            using (var conn = new SqliteConnection(conexion))
            {
                conn.Open();
                var cmd = new SqliteCommand("SELECT * FROM Libros", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Libro
                    {
                        ID = reader.GetInt32(0),
                        Titulo = reader.GetString(1),
                        Escritor = reader.GetString(2),
                        Ano_Edicion = reader.GetInt32(3),
                        Sinopsis = reader.GetString(4),
                        Disponible = reader.GetInt32(5),
                    });
                }
            }

            return lista;
        }

        public void AgregarLibro(Libro l)
        {
            using (var conn = new SqliteConnection(conexion))
            {
                conn.Open();
                var cmd = new SqliteCommand(
                    "INSERT INTO Libros (Titulo, Escritor, Ano_Edicion, Sinopsis, Disponible) VALUES (@t, @e, @a, @s, @d)",
                    conn);

                cmd.Parameters.AddWithValue("@t", l.Titulo);
                cmd.Parameters.AddWithValue("@e", l.Escritor);
                cmd.Parameters.AddWithValue("@a", l.Ano_Edicion);
                cmd.Parameters.AddWithValue("@s", l.Sinopsis);
                cmd.Parameters.AddWithValue("@d", l.Disponible);
                cmd.ExecuteNonQuery();
            }
        }

        public void BorrarLibro(int id)
        {
            using (var conn = new SqliteConnection(conexion))
            {
                conn.Open();
                var cmd = new SqliteCommand(
                    "DELETE FROM Libros WHERE Id=@id", conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarLibro(Libro libro)
        {
            using (var conn = new SqliteConnection(conexion))
            {
                conn.Open();
                var cmd = new SqliteCommand(
                    "UPDATE Libros SET Titulo=@t, Escritor=@e, Ano_Edicion=@a, Sinopsis=@s, Disponible=@d WHERE Id=@id",
                    conn);

                cmd.Parameters.AddWithValue("@t", libro.Titulo);
                cmd.Parameters.AddWithValue("@e", libro.Escritor);
                cmd.Parameters.AddWithValue("@a", libro.Ano_Edicion);
                cmd.Parameters.AddWithValue("@s", libro.Sinopsis);
                cmd.Parameters.AddWithValue("@d", libro.Disponible);
                cmd.Parameters.AddWithValue("@id", libro.ID);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
