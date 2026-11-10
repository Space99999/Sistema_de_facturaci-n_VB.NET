# 🧾 Sistema de Facturación – VB.NET + SQL Server

Aplicación de escritorio desarrollada en **VB.NET (Windows Forms)** con base de datos **SQL Server**, que permite administrar clientes y productos, y emitir y consultar facturas. La lógica de negocio crítica (cálculo de totales, creación de facturas, actualización y eliminación de registros) se implementa mediante **procedimientos almacenados** y **triggers**.

> **Autor:** Olmedo Josue Pozo Quirumbay
> **Curso:** Ti 5/1
> **Proyecto:** `OP_proyecto_1p`

---

## 📑 Tabla de contenido

- [Características](#-características)
- [Tecnologías utilizadas](#-tecnologías-utilizadas)
- [Estructura del repositorio](#-estructura-del-repositorio)
- [Módulos de la aplicación](#-módulos-de-la-aplicación)
- [Base de datos](#-base-de-datos)
- [Procedimientos almacenados](#-procedimientos-almacenados)
- [Triggers](#-triggers)
- [Manejo de errores](#-manejo-de-errores)
- [Instalación y configuración](#-instalación-y-configuración)
- [Flujo de uso](#-flujo-de-uso)

---

## ✨ Características

- **Gestión de clientes:** registrar, buscar, actualizar y eliminar clientes.
- **Gestión de productos:** registrar, buscar, actualizar y eliminar productos, asociados a una categoría.
- **Facturación:**
  - Búsqueda del cliente por cédula.
  - Búsqueda de productos por código, con verificación de stock.
  - Detalle de la factura en una grilla (código, producto, precio, cantidad, subtotal y total).
  - Cálculo automático de **subtotal, IVA (12 %) y total a pagar**.
  - Registro de cabecera y detalle de la factura en la base de datos.
- **Consulta de facturas:** búsqueda por número de factura mostrando datos del cliente, fecha, detalle y valores.
- **Control de inventario automático:** el stock se descuenta mediante un trigger al guardar el detalle de la factura.
- **Auditoría:** cada modificación de un cliente queda registrada con su fecha.
- **Validaciones y manejo de excepciones** con `Try...Catch` y mensajes al usuario.

---

## 🛠 Tecnologías utilizadas

| Componente | Tecnología |
|---|---|
| Lenguaje | VB.NET |
| Interfaz | Windows Forms (.NET Framework) |
| IDE | Microsoft Visual Studio |
| Base de datos | Microsoft SQL Server |
| Administración de BD | SQL Server Management Studio (SSMS) |
| Acceso a datos | ADO.NET (`SqlConnection`, `SqlCommand`, `SqlDataAdapter`, `SqlDataReader`) |
| Control de versiones | Git / GitHub |

---

## 📂 Estructura del repositorio

```
Sistema_de_facturaci-n_VB.NET/
├── OP_proyecto_1p/          # Solución y código fuente de la aplicación (VB.NET)
├── BD_Proyecto_1p.sql       # Script de la base de datos
├── .gitignore
└── README.md
```

### Archivos principales del proyecto

| Archivo | Descripción |
|---|---|
| `Menu.vb` | Formulario principal (contenedor MDI) con el menú del sistema. |
| `IngresoDatosClientes.vb` | Registro de nuevos clientes. |
| `ActualizarCliente.vb` | Búsqueda, actualización y eliminación de clientes. |
| `IngresarProductos.vb` | Registro de nuevos productos. |
| `Actualizar_Producto.vb` | Búsqueda, actualización y eliminación de productos. |
| `facturacion.vb` | Emisión de facturas. |
| `MostrarFactura.vb` | Consulta de facturas emitidas. |
| `Conexion.vb` | Clase de conexión a la base de datos. |
| `Categorias.vb` | Clase de apoyo para las categorías de productos. |
| `DetFactTabla.vb` | Clase que representa una fila del detalle de factura. |
| `App.config` | Configuración de la aplicación (cadena de conexión). |

---

## 🧩 Módulos de la aplicación

### 👤 Clientes
- **Ingreso de clientes:** cédula, nombre, apellido, dirección y teléfono. Botones *Grabar*, *Cancelar* y *Salir*. Valida que no existan campos vacíos antes de guardar.
- **Actualizar / eliminar clientes:** se busca por *ID Cliente*, se cargan los datos y se puede *Actualizar* o *Eliminar*. Los textos se guardan en mayúsculas.

### 📦 Productos
- **Ingreso de productos:** código, nombre, precio, stock y categoría (lista desplegable).
- **Actualizar / eliminar productos:** búsqueda por `Producto_Id`, edición de datos y categoría, con opciones *Actualizar*, *Eliminar* y *Cancelar*.

### 🧾 Facturación
1. Se ingresa la cédula del cliente y se busca (muestra nombre y apellido).
2. Se ingresa el código del producto y se busca (muestra nombre, precio y stock).
3. Se indica la cantidad y se presiona **+ Agregar**; el cálculo se realiza con un procedimiento almacenado.
4. Se muestran sub total, valor IVA, total a pagar y fecha de emisión.
5. Al presionar **Grabar** se guarda la cabecera y el detalle de la factura.

### 🔍 Mostrar factura
Permite buscar una factura por su número y visualiza los datos del cliente, la fecha de emisión, el detalle de productos y los valores totales (sub total, IVA y total).

---

## 🗄 Base de datos

**Nombre:** `BD_Proyecto_1p`

### Tablas

| Tabla | Descripción |
|---|---|
| `Cliente` | Datos de los clientes (`cli_id`, `cli_cedula`, `cli_nombres`, `cli_apellidos`, `cli_direccion`, `cli_telefono`). |
| `Categorias_Prod` | Categorías de los productos (`categ_id`, …). |
| `Productos` | Catálogo de productos (`prod_id`, `categ_id`, `prod_codigo`, `prod_nombre`, `prod_precio`, `prod_stock`). |
| `Cabecera_Factura` | Encabezado de la factura (`cabe_id`, `cli_id`, `cabe_numfac`, `cabe_fecha`, `cabe_subTotal`, `cabe_iva`, `cabe_total`). |
| `Detalle_factura` | Detalle de cada factura (`cabe_id`, `prod_id`, `det_cantidad`, `det_precio`, `det_subtotal`, `det_iva`, `det_total`). |
| `tablaCli_cambios` | Auditoría de cambios en clientes (`cli_id`, `cli_cedula`, `cli_nombres`, `cli_apellidos`, `fecha_cambio`). |

### Relaciones principales

```
Cliente ──< Cabecera_Factura ──< Detalle_factura >── Productos >── Categorias_Prod
```

---

## ⚙️ Procedimientos almacenados

| Procedimiento | Función |
|---|---|
| `CalcularDetFactxProd` | Recibe `@Cantidad` y `@Cod_Prod`; obtiene el precio del producto y calcula subtotal, IVA (12 %) y total de la línea. |
| `CrearCabeceraFactura` | Inserta la cabecera de la factura y asigna el número de factura a partir de `SCOPE_IDENTITY()`. |
| `CrearDetalleFactura` | Inserta cada línea del detalle asociada a la última cabecera creada (usa la función `ObtenerUltimoIDCabeFact()`). |
| `ActualizarEliminarCliente` | Con `@verificador = 1` **actualiza** el cliente; en caso contrario lo **elimina**. |
| `ActualizarEliminarProducto` | Con `@verificador = 1` **actualiza** el producto; en caso contrario lo **elimina**. |

Los procedimientos se invocan desde VB.NET con `CommandType.StoredProcedure` y parámetros mediante `Parameters.AddWithValue(...)`.

---

## 🔔 Triggers

### `actualizarStockPostFactura`
Se ejecuta `AFTER INSERT` en `Detalle_Factura`. Descuenta del stock de `Productos` la cantidad vendida en cada detalle guardado.

```sql
CREATE TRIGGER actualizarStockPostFactura
ON Detalle_Factura
AFTER INSERT
AS
BEGIN
    UPDATE Productos
    SET prod_stock = prod_stock - i.det_cantidad
    FROM Productos AS p
    INNER JOIN inserted AS i ON p.prod_id = i.prod_id
END;
```

### `tr_AuditCustomerChanges`
Se ejecuta `AFTER UPDATE` en `Cliente`. Guarda en `tablaCli_cambios` los datos del cliente modificado junto con la fecha del cambio (`GETDATE()`).

```sql
CREATE TRIGGER tr_AuditCustomerChanges
ON Cliente
AFTER UPDATE
AS
BEGIN
    INSERT INTO tablaCli_cambios (cli_id, cli_cedula, cli_nombres, cli_apellidos, fecha_cambio)
    SELECT cli_id, cli_cedula, cli_nombres, cli_apellidos, GETDATE()
    FROM inserted
END;
```

---

## 🛡 Manejo de errores

El sistema utiliza bloques `Try...Catch` en las operaciones con la base de datos para evitar cierres inesperados y mostrar mensajes claros al usuario, por ejemplo:

- Validación de campos vacíos antes de grabar un cliente (*"Debes llenar todos los campos"*).
- Mensajes cuando un producto o una factura no se encuentran.
- Captura de excepciones (`ex.Message`) al consultar, insertar, actualizar o eliminar datos.
- Cierre de la conexión (`miConexion.Close()`) en el evento `FormClosing` de los formularios.

---

## 🚀 Instalación y configuración

### Requisitos

- Windows
- Visual Studio con soporte para **Windows Forms (.NET Framework)**
- SQL Server y SQL Server Management Studio (SSMS)

### Pasos

1. **Clonar el repositorio**
   ```bash
   git clone https://github.com/Space99999/Sistema_de_facturaci-n_VB.NET.git
   ```

2. **Crear la base de datos**
   - Abrir SSMS y conectarse a tu instancia de SQL Server.
   - Ejecutar el script `BD_Proyecto_1p.sql` para crear `BD_Proyecto_1p` con sus tablas, procedimientos almacenados, funciones y triggers.

3. **Configurar la cadena de conexión**
   - Abrir la solución `OP_proyecto_1p` en Visual Studio.
   - Ir a **Proyecto → Propiedades → Configuración** y editar la configuración `cadena` (tipo *Cadena de conexión*, ámbito *Aplicación*):

   ```
   Data Source=TU_SERVIDOR;Initial Catalog=BD_Proyecto_1p;User ID=TU_USUARIO;Password=TU_CONTRASEÑA
   ```

   > ⚠️ Reemplaza `TU_SERVIDOR`, `TU_USUARIO` y `TU_CONTRASEÑA` por los datos de tu entorno. No subas credenciales reales al repositorio.

4. **Ejecutar el proyecto**
   - Compilar y ejecutar con `F5`.

---

## 🧭 Flujo de uso

1. Registrar categorías y **productos** con su stock.
2. Registrar los **clientes**.
3. Ir a **Facturación**, buscar al cliente por cédula, agregar productos y presionar **Grabar**.
4. Verificar la factura en **Mostrar factura** ingresando su número.
5. Comprobar que el **stock** del producto se descontó automáticamente.

---



## 📄 Licencia

Proyecto académico desarrollado con fines educativos.
