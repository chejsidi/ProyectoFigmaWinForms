# ??? Modal de Eliminación - Guía Rápida

## ? ¿Qué hace?

El `ModalEliminar` es un **único formulario** que sirve para confirmar la eliminación de:
- ? Usuarios
- ? Libros
- ? Préstamos

---

## ?? Uso Básico

### Opción 1: Mensaje genérico (sin nombre específico)

```csharp
// Muestra: "¿Estás seguro que deseas borrar el usuario?"
ModalEliminar modal = new ModalEliminar(ModalEliminar.TipoEntidad.Usuario);

if (modal.ShowDialog() == DialogResult.OK)
{
    // Usuario confirmó - ejecutar eliminación
    EliminarUsuarioEnBD(id);
    MessageBox.Show("Usuario eliminado");
}
else
{
    // Usuario canceló
    MessageBox.Show("Operación cancelada");
}
```

### Opción 2: Mensaje personalizado (con nombre específico)

```csharp
// Muestra: "¿Estás seguro que deseas borrar el usuario 'Juan García'?"
ModalEliminar modal = new ModalEliminar(
    ModalEliminar.TipoEntidad.Usuario, 
    "Juan García"
);

if (modal.ShowDialog() == DialogResult.OK)
{
    // Confirmado
    EliminarUsuarioEnBD(id);
}
```

---

## ?? Ejemplo Completo en Botón Eliminar

```csharp
private void btnEliminar_Click(object sender, EventArgs e)
{
    // 1. Verificar que hay algo seleccionado
    if (dataGridView.SelectedRows.Count == 0)
    {
        MessageBox.Show("Selecciona un elemento para eliminar");
        return;
    }

    // 2. Obtener datos de la fila
    var fila = dataGridView.SelectedRows[0];
  string nombre = fila.Cells["Nombre"].Value.ToString();
    int id = Convert.ToInt32(fila.Cells["Id"].Value);

    // 3. Mostrar modal de confirmación
    ModalEliminar modal = new ModalEliminar(
ModalEliminar.TipoEntidad.Usuario, 
        nombre  // opcional
    );

    // 4. Si confirma, eliminar
    if (modal.ShowDialog() == DialogResult.OK)
    {
      try
  {
    // Eliminar de BD
            EliminarEnBaseDatos(id);
          
    // Refrescar tabla
        CargarDatos();
        
            MessageBox.Show("Eliminado correctamente");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al eliminar: " + ex.Message);
        }
    }
}
```

---

## ?? Tipos de Entidad

```csharp
ModalEliminar.TipoEntidad.Usuario   // "¿Estás seguro que deseas borrar el usuario?"
ModalEliminar.TipoEntidad.Libro     // "¿Estás seguro que deseas borrar el libro?"
ModalEliminar.TipoEntidad.Prestamo  // "¿Estás seguro que deseas borrar el préstamo?"
```

---

## ? Ejemplos Rápidos por Entidad

### Usuario
```csharp
ModalEliminar modal = new ModalEliminar(ModalEliminar.TipoEntidad.Usuario, "Juan García");
```

### Libro
```csharp
ModalEliminar modal = new ModalEliminar(ModalEliminar.TipoEntidad.Libro, "Don Quijote");
```

### Préstamo
```csharp
ModalEliminar modal = new ModalEliminar(ModalEliminar.TipoEntidad.Prestamo, "123");
```

---

## ?? Resultado del Modal

El modal devuelve un `DialogResult`:

- **DialogResult.OK** ? Usuario presionó CONFIRMAR ? **Eliminar**
- **DialogResult.Cancel** ? Usuario presionó CANCELAR o cerró la X ? **No hacer nada**

---

## ?? Consejo

Siempre verifica que `ShowDialog() == DialogResult.OK` antes de eliminar:

```csharp
if (modal.ShowDialog() == DialogResult.OK)
{
  // SOLO aquí ejecutas la eliminación
    EliminarDeBD(id);
}
// Si es Cancel, no se ejecuta nada
```

---

¡Listo! ??
