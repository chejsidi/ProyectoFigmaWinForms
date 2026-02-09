using Microsoft.Data.Sqlite;
using ProyectoFigma.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFigma.Controlador
{
    public class PrestamoController
    {
        private string conexion = "Data Source=Biblioteca.db";

        public List<Prestamo> ObtenerPrestamos()
        {
            List<Prestamo> lista = new List<Prestamo>();

            using (var conn = new SqliteConnection(conexion))
            {
                conn.Open();
                var cmd = new SqliteCommand(
                    "SELECT p.ID, p.ID_Libro, p.ID_Usuario, p.Fecha_Inicio, p.Fecha_Fin, u.Nombre AS UsuarioNombre, l.Titulo AS LibroTitulo " +
                    "FROM Prestamos p " +
                    "JOIN Usuarios u ON u.ID = p.ID_Usuario " +
                    "JOIN Libros l ON l.ID = p.ID_Libro",
                    conn);

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Prestamo
                    {
                        Id = reader.GetInt32(0),
                        ID_Libro = reader.GetInt32(1),
                        ID_Usuario = reader.GetInt32(2),
                        Fecha_Inicio = reader.GetString(3),
                        Fecha_Fin = reader.GetString(4),
                        UsuarioNombre = reader.IsDBNull(5) ? "" : reader.GetString(5),
                        LibroTitulo = reader.IsDBNull(6) ? "" : reader.GetString(6)
                    });
                }
            }

            return lista;
        }

        public void AgregarPrestamo(Prestamo p)
        {
            using (var conn = new SqliteConnection(conexion))
            {
                conn.Open();
                var cmd = new SqliteCommand(
                    "INSERT INTO Prestamos (ID_Libro, ID_Usuario, Fecha_Inicio, Fecha_Fin) " +
                    "VALUES (@libro, @usuario, @inicio, @fin)",
                    conn);

                cmd.Parameters.AddWithValue("@libro", p.ID_Libro);
                cmd.Parameters.AddWithValue("@usuario", p.ID_Usuario);
                cmd.Parameters.AddWithValue("@inicio", p.Fecha_Inicio);
                cmd.Parameters.AddWithValue("@fin", p.Fecha_Fin);

                cmd.ExecuteNonQuery();
            }
        }

        public void BorrarPrestamo(int id)
        {
            using (var conn = new SqliteConnection(conexion))
            {
                conn.Open();
                var cmd = new SqliteCommand(
                    "DELETE FROM Prestamos WHERE Id=@id",
                    conn);

                cmd.Parameters.AddWithValue("@id", id);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe eliminar los libros y el usuario antes de borrar el prestamo");
                }
            }
        }
    }
}
