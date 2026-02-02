# Modales Reutilizables para Gestión de Biblioteca

## ?? Archivos Creados

He creado cuatro tipos de modales reutilizables en la carpeta `Vista`:

### 1. **ModalUsuario** (Añadir/Editar Usuarios)
- `ModalUsuario.cs` - Lógica del formulario
- `ModalUsuario.Designer.cs` - Diseño generado
- `ModalUsuario.resx` - Recursos

**Campos:**
- Nombre (obligatorio)
- Primer Apellido (obligatorio)
- Segundo Apellido
- DNI (obligatorio)
- Email (obligatorio)
- Teléfono
- Dirección

### 2. **ModalLibro** (Añadir/Editar Libros)
- `ModalLibro.cs` - Lógica del formulario
- `ModalLibro.Designer.cs` - Diseño generado
- `ModalLibro.resx` - Recursos

**Campos:**
- Título (obligatorio)
- Autor (obligatorio)
- ISBN (obligatorio)
- Editorial
- Año de Publicación (obligatorio, NumericUpDown)
- Género
- Cantidad (NumericUpDown)

### 3. **ModalPrestamo** (Añadir/Editar Préstamos)
- `ModalPrestamo.cs` - Lógica del formulario
- `ModalPrestamo.Designer.cs` - Diseño generado
- `ModalPrestamo.resx` - Recursos

**Campos:**
- Usuario (ComboBox - pendiente de implementar carga de datos)
- Libro (ComboBox - pendiente de implementar carga de datos)
- Fecha Préstamo (DateTimePicker)
- Fecha Devolución (DateTimePicker)
- Estado (ComboBox: Activo, Devuelto, Retrasado)

### 4. **ModalEliminar** (Confirmar Eliminación)
- `ModalEliminar.cs` - Lógica del formulario
- `ModalEliminar.Designer.cs` - Diseño generado
- `ModalEliminar.resx` - Recursos

**Características:**
- Modal genérico para confirmar eliminación de Usuario, Libro o Préstamo
- Mensaje personalizado según el tipo de entidad
- Puede mostrar el nombre específico del elemento a eliminar
- Botones CONFIRMAR (gris) y CANCELAR (rojo)

---

## ?? Cómo Usar los Modales

### Ejemplo 1: Añadir un Usuario

```csharp
private void btnAñadirUsuario_Click(object sender, EventArgs e)
{
    // Crear el modal en modo Añadir
    ModalUsuario modal = new ModalUsuario(ModalUsuario.ModoModal.Añadir);
    
    // Mostrar el modal
    if (modal.ShowDialog() == DialogResult.OK)
    {
        // El usuario presionó GUARDAR
   string nombre = modal.Nombre;
        string primerApellido = modal.PrimerApellido;
        string segundoApellido = modal.SegundoApellido;
        string dni = modal.DNI;
 string email = modal.Email;
        string telefono = modal.Telefono;
 string direccion = modal.Direccion;
   
        // Aquí guardarías en la base de datos
        // GuardarUsuario(nombre, primerApellido, ...);
   
     MessageBox.Show("Usuario añadido correctamente");
        
        // Recargar el DataGridView
    // CargarUsuarios();
    }
}
```

### Ejemplo 2: Editar un Usuario

```csharp
private void btnEditarUsuario_Click(object sender, EventArgs e)
{
    // Verificar que hay una fila seleccionada
    if (dataGridViewUsuarios.SelectedRows.Count == 0)
    {
    MessageBox.Show("Selecciona un usuario", "Aviso", 
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
    }
    
    // Obtener datos de la fila seleccionada
    DataGridViewRow fila = dataGridViewUsuarios.SelectedRows[0];
    string nombre = fila.Cells["Nombre"].Value.ToString();
    string primerApellido = fila.Cells["PrimerApellido"].Value.ToString();
    string segundoApellido = fila.Cells["SegundoApellido"].Value.ToString();
    string dni = fila.Cells["DNI"].Value.ToString();
    string email = fila.Cells["Email"].Value.ToString();
    string telefono = fila.Cells["Telefono"].Value.ToString();
    string direccion = fila.Cells["Direccion"].Value.ToString();
    
    // Crear el modal en modo Editar con los datos existentes
    ModalUsuario modal = new ModalUsuario(
        ModalUsuario.ModoModal.Editar,
      nombre, primerApellido, segundoApellido,
        dni, email, telefono, direccion
    );
    
    if (modal.ShowDialog() == DialogResult.OK)
    {
        // Actualizar en base de datos
  // ActualizarUsuario(modal.DNI, modal.Nombre, ...);
    
      MessageBox.Show("Usuario actualizado correctamente");
    
        // Recargar el DataGridView
        // CargarUsuarios();
    }
}
```

### Ejemplo 3: Eliminar un Usuario

```csharp
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
    string dni = fila.Cells["DNI"].Value.ToString();

    // Opción 1: Modal simple sin mostrar el nombre
    ModalEliminar modal = new ModalEliminar(ModalEliminar.TipoEntidad.Usuario);

    // Opción 2: Modal mostrando el nombre del usuario
    // ModalEliminar modal = new ModalEliminar(ModalEliminar.TipoEntidad.Usuario, nombre);

    if (modal.ShowDialog() == DialogResult.OK)
    {
        // Usuario presionó CONFIRMAR
        // Eliminar de la base de datos
  // EliminarUsuarioEnBD(dni);

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
```

### Ejemplo 4: Añadir un Libro

```csharp
private void btnAñadirLibro_Click(object sender, EventArgs e)
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
        
        // Guardar en base de datos
     // GuardarLibro(titulo, autor, isbn, ...);
     
        MessageBox.Show("Libro añadido correctamente");
  }
}
```

### Ejemplo 5: Editar un Libro

```csharp
private void btnEditarLibro_Click(object sender, EventArgs e)
{
    // Verificar selección
    if (dataGridViewLibros.SelectedRows.Count == 0)
    {
    MessageBox.Show("Selecciona un libro", "Aviso", 
   MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
    }
    
 // Obtener datos
    DataGridViewRow fila = dataGridViewLibros.SelectedRows[0];
    string titulo = fila.Cells["Titulo"].Value.ToString();
    string autor = fila.Cells["Autor"].Value.ToString();
    string isbn = fila.Cells["ISBN"].Value.ToString();
    string editorial = fila.Cells["Editorial"].Value.ToString();
 int anio = Convert.ToInt32(fila.Cells["AnioPublicacion"].Value);
    string genero = fila.Cells["Genero"].Value.ToString();
    int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
    
    // Abrir modal
    ModalLibro modal = new ModalLibro(
     ModalLibro.ModoModal.Editar,
     titulo, autor, isbn, editorial, anio, genero, cantidad
    );
    
    if (modal.ShowDialog() == DialogResult.OK)
    {
        // Actualizar en base de datos
     MessageBox.Show("Libro actualizado correctamente");
    }
}
```

### Ejemplo 6: Eliminar un Libro

```csharp
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
    string isbn = fila.Cells["ISBN"].Value.ToString();

    // Mostrar modal con el título del libro
    ModalEliminar modal = new ModalEliminar(ModalEliminar.TipoEntidad.Libro, titulo);

    if (modal.ShowDialog() == DialogResult.OK)
    {
        // Eliminar de BD
        // EliminarLibroEnBD(isbn);

        MessageBox.Show("Libro eliminado correctamente");
    }
}
```

### Ejemplo 7: Añadir un Préstamo

```csharp
private void btnAñadirPrestamo_Click(object sender, EventArgs e)
{
    ModalPrestamo modal = new ModalPrestamo(ModalPrestamo.ModoModal.Añadir);
    
    // NOTA: Aquí tu compañero debería cargar los ComboBox
    // Puedes agregar métodos públicos en ModalPrestamo.cs para esto:
    // modal.CargarUsuarios(listaUsuarios);
    // modal.CargarLibros(listaLibros);
  
    if (modal.ShowDialog() == DialogResult.OK)
    {
        int usuarioId = modal.UsuarioId;
        int libroId = modal.LibroId;
        DateTime fechaPrestamo = modal.FechaPrestamo;
        DateTime fechaDevolucion = modal.FechaDevolucion;
        string estado = modal.Estado;
    
        // Guardar en base de datos
    MessageBox.Show("Préstamo registrado correctamente");
 }
}
```

### Ejemplo 8: Eliminar un Préstamo

```csharp
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

// Mostrar modal con el ID del préstamo
    ModalEliminar modal = new ModalEliminar(
        ModalEliminar.TipoEntidad.Prestamo, 
        prestamoId.ToString()
    );

    if (modal.ShowDialog() == DialogResult.OK)
    {
        // Eliminar de BD
        // EliminarPrestamoEnBD(prestamoId);

        MessageBox.Show("Préstamo eliminado correctamente");
    }
}
```

---

## ? Características

### Validaciones Incluidas

**ModalUsuario:**
- Valida que Nombre, Primer Apellido, DNI y Email sean obligatorios
- Muestra mensajes de error claros
- Enfoca automáticamente el campo con error

**ModalLibro:**
- Valida Título, Autor, ISBN y Año de Publicación
- Año de publicación entre 1000 y 2100
- Cantidad entre 0 y 1000

**ModalPrestamo:**
- Valida que la fecha de devolución sea posterior a la de préstamo
- Valida que se seleccione un estado
- Por defecto: fecha préstamo = hoy, devolución = +14 días

**ModalEliminar:**
- Modal de confirmación simple
- Mensaje personalizado según el tipo de entidad (Usuario, Libro o Préstamo)
- Opcionalmente puede mostrar el nombre específico del elemento a eliminar
- Devuelve DialogResult.OK si confirma, DialogResult.Cancel si cancela

### Diseño

**Modales de Añadir/Editar:**
- **Título dinámico:** Cambia entre "Añadir X" y "Editar X"
- **Botones estilizados:** 
  - GUARDAR (gris oscuro)
- CANCELAR (rojo)
- **Panel con borde:** Agrupa los campos de forma visual
- **Colores:** Paleta gris claro para fondo, blanco para inputs

**Modal de Eliminar:**
- **Diseño minimalista:** Solo mensaje y botones
- **Mensaje centrado:** Pregunta de confirmación clara
- **Botones estilizados:**
  - CONFIRMAR (gris oscuro)
  - CANCELAR (rojo)
- **Título dinámico:** "Eliminar Usuario", "Eliminar Libro" o "Eliminar Préstamo"

---

## ?? Tareas Pendientes para tu Compañero

### En ModalPrestamo.cs

Agregar métodos para cargar los ComboBox:

```csharp
public void CargarUsuarios(List<Usuario> usuarios)
{
    cmbUsuario.DataSource = usuarios;
    cmbUsuario.DisplayMember = "Nombre"; // o el campo que quieras mostrar
    cmbUsuario.ValueMember = "Id";
}

public void CargarLibros(List<Libro> libros)
{
    cmbLibro.DataSource = libros;
    cmbLibro.DisplayMember = "Titulo";
    cmbLibro.ValueMember = "Id";
}
```

Y en el getter de las propiedades:

```csharp
public int UsuarioId 
{ 
    get 
    { 
        if (cmbUsuario.SelectedValue != null)
            return (int)cmbUsuario.SelectedValue;
        return 0;
    }
    set { /* ... */ }
}
```

---

## ?? Ventajas de esta Implementación

1. **Reutilizable:** Un solo modal sirve para Añadir y Editar
2. **Modal de eliminación genérico:** Un solo formulario para los tres tipos de entidad
3. **Validaciones centralizadas:** No necesitas repetir validaciones
4. **Fácil de usar:** Solo 2-3 líneas para abrir el modal
5. **Tipo seguro:** Usa propiedades con tipos correctos y enums
6. **Separación de responsabilidades:** El modal no necesita saber de base de datos
7. **Diseño consistente:** Todos los modales tienen el mismo estilo

---

## ?? Estructura de Archivos

```
ProyectoFigma/
??? Vista/
?   ??? ModalUsuario.cs
?   ??? ModalUsuario.Designer.cs
?   ??? ModalUsuario.resx
?   ??? ModalLibro.cs
?   ??? ModalLibro.Designer.cs
?   ??? ModalLibro.resx
?   ??? ModalPrestamo.cs
?   ??? ModalPrestamo.Designer.cs
? ??? ModalPrestamo.resx
?   ??? ModalEliminar.cs
?   ??? ModalEliminar.Designer.cs
?   ??? ModalEliminar.resx
??? Ejemplos/
    ??? EjemploUsoModales.cs (Ejemplos completos de uso)
```

---

## ?? Personalización

Si necesitas modificar el diseño, edita los archivos `.Designer.cs` o usa el diseñador visual de Visual Studio.

Para cambiar colores:
- Fondo panel: `Color.FromArgb(240, 240, 240)`
- Botón Guardar/Confirmar: `Color.FromArgb(100, 100, 100)`
- Botón Cancelar: `Color.FromArgb(200, 80, 80)`

---

## ?? Resumen de Uso

| Acción | Modal a usar | Constructor |
|--------|--------------|-------------|
| **Añadir Usuario** | `ModalUsuario` | `new ModalUsuario(ModoModal.Añadir)` |
| **Editar Usuario** | `ModalUsuario` | `new ModalUsuario(ModoModal.Editar, datos...)` |
| **Eliminar Usuario** | `ModalEliminar` | `new ModalEliminar(TipoEntidad.Usuario)` |
| **Añadir Libro** | `ModalLibro` | `new ModalLibro(ModoModal.Añadir)` |
| **Editar Libro** | `ModalLibro` | `new ModalLibro(ModoModal.Editar, datos...)` |
| **Eliminar Libro** | `ModalEliminar` | `new ModalEliminar(TipoEntidad.Libro, nombre)` |
| **Añadir Préstamo** | `ModalPrestamo` | `new ModalPrestamo(ModoModal.Añadir)` |
| **Editar Préstamo** | `ModalPrestamo` | `new ModalPrestamo(ModoModal.Editar, datos...)` |
| **Eliminar Préstamo** | `ModalEliminar` | `new ModalEliminar(TipoEntidad.Prestamo, id)` |

---

¡Listo para usar! ??
