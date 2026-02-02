# Modales Reutilizables para Gestión de Biblioteca

## ?? Archivos Creados

He creado tres modales reutilizables en la carpeta `Vista`:

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

### Ejemplo 3: Añadir un Libro

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

### Ejemplo 4: Editar un Libro

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

### Ejemplo 5: Añadir un Préstamo

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

### Diseño

- **Título dinámico:** Cambia entre "Añadir X" y "Editar X"
- **Botones estilizados:** 
  - GUARDAR (gris oscuro)
  - CANCELAR (rojo)
- **Panel con borde:** Agrupa los campos de forma visual
- **Colores:** Paleta gris claro para fondo, blanco para inputs

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
2. **Validaciones centralizadas:** No necesitas repetir validaciones
3. **Fácil de usar:** Solo 2-3 líneas para abrir el modal
4. **Tipo seguro:** Usa propiedades con tipos correctos
5. **Separación de responsabilidades:** El modal no necesita saber de base de datos
6. **Diseño consistente:** Todos los modales tienen el mismo estilo

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
???? ModalLibro.resx
?   ??? ModalPrestamo.cs
?   ??? ModalPrestamo.Designer.cs
?   ??? ModalPrestamo.resx
??? Ejemplos/
    ??? EjemploUsoModales.cs(Ejemplos completos de uso)
```

---

## ?? Personalización

Si necesitas modificar el diseño, edita los archivos `.Designer.cs` o usa el diseñador visual de Visual Studio.

Para cambiar colores:
- Fondo panel: `Color.FromArgb(240, 240, 240)`
- Botón Guardar: `Color.FromArgb(100, 100, 100)`
- Botón Cancelar: `Color.FromArgb(200, 80, 80)`

---

¡Listo para usar! ??
