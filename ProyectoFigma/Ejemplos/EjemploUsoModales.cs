using System;
using System.Windows.Forms;
using ProyectoFigma.Vista;

namespace ProyectoFigma.Ejemplos
{
    /// <summary>
 /// Clase de ejemplo que muestra cómo usar los modales desde las pantallas de gestión
    /// Tu compañero puede copiar estos ejemplos en las pantallas de Usuarios, Libros y Préstamos
    /// </summary>
    public class EjemploUsoModales
    {
        // ============================================================
        // EJEMPLO 1: Usar el modal para AÑADIR un nuevo USUARIO
        // ============================================================
        public void EjemploAñadirUsuario()
        {
  // Crear el modal en modo "Añadir"
            ModalUsuario modal = new ModalUsuario(ModalUsuario.ModoModal.Añadir);
    
            // Mostrar el modal y esperar el resultado
     if (modal.ShowDialog() == DialogResult.OK)
          {
           // El usuario presionó GUARDAR
            // Aquí puedes acceder a los datos ingresados:
       string nombre = modal.Nombre;
 string primerApellido = modal.PrimerApellido;
       string segundoApellido = modal.SegundoApellido;
          string telefono = modal.Telefono;
    
     // Aquí llamarías a tu método para guardar en la base de datos
   // Por ejemplo:
         // GuardarUsuarioEnBD(nombre, primerApellido, segundoApellido, telefono);
  
    MessageBox.Show("Usuario añadido correctamente");
             // Actualizar el DataGridView o la lista
            }
     else
  {
      // El usuario presionó CANCELAR
           MessageBox.Show("Operación cancelada");
   }
        }

        // ============================================================
        // EJEMPLO 2: Usar el modal para EDITAR un USUARIO existente
        // ============================================================
     public void EjemploEditarUsuario()
        {
  // Estos datos deberían venir de la fila seleccionada del DataGridView
       string nombreActual = "Juan";
      string primerApellidoActual = "García";
       string segundoApellidoActual = "López";
     string telefonoActual = "666777888";
  
      // Crear el modal en modo "Editar" con los datos existentes
     ModalUsuario modal = new ModalUsuario(
    ModalUsuario.ModoModal.Editar,
 nombreActual,
    primerApellidoActual,
          segundoApellidoActual,
    telefonoActual
     );
     
 if (modal.ShowDialog() == DialogResult.OK)
      {
     // Obtener los datos modificados
  string nombre = modal.Nombre;
  string primerApellido = modal.PrimerApellido;
       // ... etc
    
      // Aquí llamarías a tu método para actualizar en la base de datos
        // Por ejemplo:
        // ActualizarUsuarioEnBD(nombre, primerApellido, ...);
       
   MessageBox.Show("Usuario actualizado correctamente");
        // Actualizar el DataGridView
     }
        }

        // ============================================================
        // EJEMPLO 3: Usar el modal para AÑADIR un nuevo LIBRO
        // ============================================================
        public void EjemploAñadirLibro()
        {
   ModalLibro modal = new ModalLibro(ModalLibro.ModoModal.Añadir);
        
         if (modal.ShowDialog() == DialogResult.OK)
      {
     string titulo = modal.Titulo;
           string autor = modal.Autor;
  string isbn = modal.ISBN;
      string editorial = modal.Editorial;
   int anioPublicacion = modal.AnioPublicacion;
       string genero = modal.Genero;
      int cantidad = modal.Cantidad;
   
   // Guardar en BD
  // GuardarLibroEnBD(titulo, autor, isbn, editorial, anioPublicacion, genero, cantidad);
   
        MessageBox.Show("Libro añadido correctamente");
          }
        }

        // ============================================================
      // EJEMPLO 4: Usar el modal para EDITAR un LIBRO existente
        // ============================================================
   public void EjemploEditarLibro()
        {
            // Datos que vienen del DataGridView
   string tituloActual = "Don Quijote";
        string autorActual = "Miguel de Cervantes";
    string isbnActual = "978-3-16-148410-0";
         string editorialActual = "Editorial Planeta";
     int anioActual = 1605;
            string generoActual = "Novela";
         int cantidadActual = 5;
            
  ModalLibro modal = new ModalLibro(
      ModalLibro.ModoModal.Editar,
           tituloActual,
         autorActual,
      isbnActual,
        editorialActual,
      anioActual,
           generoActual,
       cantidadActual
       );
            
          if (modal.ShowDialog() == DialogResult.OK)
       {
    // Actualizar en BD
         MessageBox.Show("Libro actualizado correctamente");
   }
        }

// ============================================================
        // EJEMPLO 5: Usar el modal para AÑADIR un nuevo PRÉSTAMO
      // ============================================================
        public void EjemploAñadirPrestamo()
        {
            ModalPrestamo modal = new ModalPrestamo(ModalPrestamo.ModoModal.Añadir);
            
       // NOTA: Tu compañero debería cargar los ComboBox de usuarios y libros
// antes de mostrar el modal. Por ejemplo:
            // modal.CargarUsuarios(listaUsuarios);
          // modal.CargarLibros(listaLibros);
            
         if (modal.ShowDialog() == DialogResult.OK)
            {
     int usuarioId = modal.UsuarioId;
        int libroId = modal.LibroId;
       DateTime fechaPrestamo = modal.FechaPrestamo;
         DateTime fechaDevolucion = modal.FechaDevolucion;
   string estado = modal.Estado;
        
          // Guardar en BD
      // GuardarPrestamoEnBD(usuarioId, libroId, fechaPrestamo, fechaDevolucion, estado);
       
     MessageBox.Show("Préstamo registrado correctamente");
      }
        }

        // ============================================================
        // EJEMPLO 6: Cómo conectar el botón "Añadir" en un formulario
      // ============================================================
      // En el evento Click del botón "Añadir Usuario":
        private void btnAñadirUsuario_Click(object sender, EventArgs e)
     {
     ModalUsuario modal = new ModalUsuario(ModalUsuario.ModoModal.Añadir);

          if (modal.ShowDialog() == DialogResult.OK)
       {
     // Guardar en base de datos
       // ...
      
       // Refrescar el DataGridView
      // CargarUsuarios(); // método que recarga los datos
      }
  }

        // ============================================================
        // EJEMPLO 7: Cómo conectar el botón "Editar" en un formulario
      // ============================================================
        // En el evento Click del botón "Editar Usuario":
        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
       // Verificar que hay una fila seleccionada
      if (dataGridViewUsuarios.SelectedRows.Count == 0)
    {
         MessageBox.Show("Por favor, selecciona un usuario para editar", 
  "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
   return;
  }
    
     // Obtener los datos de la fila seleccionada
       DataGridViewRow fila = dataGridViewUsuarios.SelectedRows[0];
       string nombre = fila.Cells["Nombre"].Value.ToString();
 string primerApellido = fila.Cells["Apellido_1"].Value.ToString();
         string segundoApellido = fila.Cells["Apellido_2"].Value.ToString();
 string telefono = fila.Cells["Telefono"].Value.ToString();
      
     // Abrir el modal con los datos
    ModalUsuario modal = new ModalUsuario(
    ModalUsuario.ModoModal.Editar,
         nombre,
     primerApellido,
    segundoApellido,
    telefono
     );
       
       if (modal.ShowDialog() == DialogResult.OK)
      {
  // Actualizar en base de datos
      // ...
     
       // Refrescar el DataGridView
     // CargarUsuarios();
    }
        }
        
        // Declaración ficticia del DataGridView para el ejemplo
        private DataGridView dataGridViewUsuarios = new DataGridView();

        // ============================================================
        // EJEMPLO 8: Usar el modal para ELIMINAR un USUARIO
        // ============================================================
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
     // Verificar que hay una fila seleccionada
if (dataGridViewUsuarios.SelectedRows.Count == 0)
 {
  MessageBox.Show("Por favor, selecciona un usuario para eliminar", 
       "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
   return;
    }

  // Obtener datos de la fila seleccionada
       DataGridViewRow fila = dataGridViewUsuarios.SelectedRows[0];
string nombre = fila.Cells["Nombre"].Value.ToString();

        // Mostrar mensaje de confirmación
       var confirm = MessageBox.Show(
       $"¿Seguro que quieres borrar el usuario {nombre}?",
      "Confirmar",
       MessageBoxButtons.YesNo);

     if (confirm == DialogResult.Yes)
{
     // Eliminar de la base de datos
       // EliminarUsuarioEnBD(id);

        MessageBox.Show("Usuario eliminado correctamente");
   // Refrescar el DataGridView
       // CargarUsuarios();
     }
      else
 {
        // Usuario presionó CANCELAR
     MessageBox.Show("Eliminación cancelada");
            }
        }
     // ============================================================
        // EJEMPLO 9: Usar el modal para ELIMINAR un LIBRO
        // ============================================================
    private void btnEliminarLibro_Click(object sender, EventArgs e)
      {
          // Verificar selección
  if (dataGridViewLibros.SelectedRows.Count == 0)
 {
         MessageBox.Show("Selecciona un libro para eliminar");
   return;
            }

       DataGridViewRow fila = dataGridViewLibros.SelectedRows[0];
      string titulo = fila.Cells["Titulo"].Value.ToString();

     // Mostrar confirmación
     var confirm = MessageBox.Show(
    $"¿Seguro que quieres eliminar el libro '{titulo}'?",
    "Confirmar",
    MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
     {
    // Eliminar de BD
      // EliminarLibroEnBD(isbn);

     MessageBox.Show("Libro eliminado correctamente");
            }
        }

        // ============================================================
        // EJEMPLO 10: Usar el modal para ELIMINAR un PRÉSTAMO
        // ============================================================
        private void btnEliminarPrestamo_Click(object sender, EventArgs e)
        {
    // Verificar selección
if (dataGridViewPrestamos.SelectedRows.Count == 0)
      {
         MessageBox.Show("Selecciona un préstamo para eliminar");
  return;
      }

     DataGridViewRow fila = dataGridViewPrestamos.SelectedRows[0];
            int prestamoId = Convert.ToInt32(fila.Cells["Id"].Value);

     // Mostrar confirmación
       var confirm = MessageBox.Show(
    $"¿Seguro que quieres eliminar el préstamo #{prestamoId}?",
 "Confirmar",
       MessageBoxButtons.YesNo);

       if (confirm == DialogResult.Yes)
  {
   // Eliminar de BD
     // EliminarPrestamoEnBD(prestamoId);

       MessageBox.Show("Préstamo eliminado correctamente");
      }
  }

        // Declaraciones ficticias para los ejemplos
        private DataGridView dataGridViewLibros = new DataGridView();
     private DataGridView dataGridViewPrestamos = new DataGridView();
    }
}
