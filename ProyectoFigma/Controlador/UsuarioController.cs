using Microsoft.Data.Sqlite;
using ProyectoFigma.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFigma.Controlador
{
    public class UsuarioController
    {
        private string conexion = "Data Source=Biblioteca.db";

        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();

            using (var conn = new SqliteConnection(conexion))
            {
                conn.Open();
                var cmd = new SqliteCommand("SELECT * FROM Usuarios", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Usuario
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido_1 = reader.GetString(2),
                        Apellido_2 = reader.GetString(3),
                        Telefono = reader.GetInt32(4)
                    });
                }
            }
            return lista;
        }

        public void AgregarUsuario(Usuario u)
        {
            using (var conn = new SqliteConnection(conexion))
            {
                conn.Open();
                var cmd = new SqliteCommand(
                    "INSERT INTO Usuarios (Nombre, Apellido_1, Apellido_2, Telefono) VALUES (@n, @a1, @a2, @t)", conn);

                cmd.Parameters.AddWithValue("@n", u.Nombre);
                cmd.Parameters.AddWithValue("@a1", u.Apellido_1);
                cmd.Parameters.AddWithValue("@a2", u.Apellido_2);
                cmd.Parameters.AddWithValue("@t", u.Telefono);
                cmd.ExecuteNonQuery();
            }
        }

        public void BorrarUsuario(int id)
        {
            using (var conn = new SqliteConnection(conexion))
            {
                conn.Open();
                var cmd = new SqliteCommand(
                    "DELETE FROM Usuarios WHERE Id=@id", conn);

                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe eliminar los prestamos y libros del usuarios antes de borrarlo");
                }
            }
        }
    }
}
