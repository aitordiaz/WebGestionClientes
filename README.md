
# Web Gestión Clientes

Esta herramienta permite gestionar una base de datos de clientes, realizando las operaciones
de creación, visualización, modificación y borrado de los mismos.
La aplicación se ha desarrollado con el marco ASP.NET Core MVC con Entity Framework 6 para el acceso a datos.

## Requisitos 

 1. Los datos del cliente son (todos son obligatorios)
	- Documento de identificación (DNI/NIE)
	- Nombre
	- Apellidos
	- Email
	- Teléfono
	- País de residencia
	- Fecha de Nacimiento
2. Visualicación de clientes con páginación
3. Los módulos necesarios para la aplicación son CRUD
	- Creación de Cliente
	- Visualización de datos del cliente (P.ej. con BootstrapTables)
	- Edición de los datos
	- Borrado del cliente

## Extra

 1. Desarrollar la aplicación con pruebas unitarias
2. Datos adicionales del cliente
	- Nombre empresa
	- Cuenta de Twitter
	- Intereses (Deportes, Literatura, Cine, Juegos, Formación), pudiendo elegir varios
	- Género (Masculino / Femenino)
	Para ello el sistema debe tener una acción para enviar un email al cliente con un enlace a un formulario donde el
mismo cliente rellene los datos.
Página de recepción de nuevos datos.
En el módulo de visualización de datos del cliente se deberán de mostrar los datos nuevos.

En la ruta /Clientes se encuentra la visualización de los clientes con paginación. 
El tamaño de la página se ha definido en 3.



### Checklist

- [x] Controlador y Vista Inicio
- [x] Crear Modelo Cliente (con comprobación de restricción a nivel de código)
- [x] Contexto Base de datos y configuración en _Startup.cs_
- [x] Uso de `Migrations` para crear, añadir restricciones y actualizar la base de datos
- [x] Generar datos de prueba (`SeedData`)
- [x] Configuración para usar LocalDB en `appsettings.json`
- [x] Crear Controlador para CRUD básico del Cliente (1)
- [x] Ruta /Clientes con páginación
- [x] Ruta /Clientes/Details/{id} para visualización de datos del cliente
- [x] Ruta /Clientes/Edit/{id} para modificación de datos del cliente
- [x] Ruta /Clientes/Delete/{id} para eliminación de datos del cliente (con página de confirmación)
- [x] Preparación Modelo para añadir datos adicionales (2) y uso de `Migrations` para la modificación en la base de datos
- [x] Crear Proyecto Test para pruebas unitarias 
- [x] Prueba unitaria de una acción del controlador Home
- [x] Vista `AdditionalData` para la recepción de los datos adicionales
- [ ] Pruebas unitarias del CRUD de Cliente
- [ ] Añadir DB constraint a los nuevos campos adicionales
- [ ] Crear ruta /Clientes/AdditionalData/{id} para permitir la actualización de datos
- [ ] Módulo de correo con el enlace a la ruta anterior

### Trabajo futuro y sugerencias

* ¿`TryUpdateModel` o nuevo `ViewModel` para añadir los datos adicionales?
* Gestión de las páginas de error
* Registro de excepciones (producción)
* Añadir filtro de búsqueda por nombre o apellidos y posibilidad de ordenación por varios campos en la lista de clientes.
* Crear una página `Sobre la aplicación`a partir de este README
* Generación de documentación