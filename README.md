
# Web Gesti�n Clientes

Esta herramienta permite gestionar una base de datos de clientes, realizando las operaciones
de creaci�n, visualizaci�n, modificaci�n y borrado de los mismos.
La aplicaci�n se ha desarrollado con el marco ASP.NET Core MVC con Entity Framework 6 para el acceso a datos.

## Requisitos 

 1. Los datos del cliente son (todos son obligatorios)
	- Documento de identificaci�n (DNI/NIE)
	- Nombre
	- Apellidos
	- Email
	- Tel�fono
	- Pa�s de residencia
	- Fecha de Nacimiento
2. Visualicaci�n de clientes con p�ginaci�n
3. Los m�dulos necesarios para la aplicaci�n son CRUD
	- Creaci�n de Cliente
	- Visualizaci�n de datos del cliente (P.ej. con BootstrapTables)
	- Edici�n de los datos
	- Borrado del cliente

## Extra

 1. Desarrollar la aplicaci�n con pruebas unitarias
2. Datos adicionales del cliente
	- Nombre empresa
	- Cuenta de Twitter
	- Intereses (Deportes, Literatura, Cine, Juegos, Formaci�n), pudiendo elegir varios
	- G�nero (Masculino / Femenino)
	Para ello el sistema debe tener una acci�n para enviar un email al cliente con un enlace a un formulario donde el
mismo cliente rellene los datos.
P�gina de recepci�n de nuevos datos.
En el m�dulo de visualizaci�n de datos del cliente se deber�n de mostrar los datos nuevos.

En la ruta /Clientes se encuentra la visualizaci�n de los clientes con paginaci�n. 
El tama�o de la p�gina se ha definido en 3.



### Checklist

- [x] Controlador y Vista Inicio
- [x] Crear Modelo Cliente (con comprobaci�n de restricci�n a nivel de c�digo)
- [x] Contexto Base de datos y configuraci�n en _Startup.cs_
- [x] Uso de `Migrations` para crear, a�adir restricciones y actualizar la base de datos
- [x] Generar datos de prueba (`SeedData`)
- [x] Configuraci�n para usar LocalDB en `appsettings.json`
- [x] Crear Controlador para CRUD b�sico del Cliente (1)
- [x] Ruta /Clientes con p�ginaci�n
- [x] Ruta /Clientes/Details/{id} para visualizaci�n de datos del cliente
- [x] Ruta /Clientes/Edit/{id} para modificaci�n de datos del cliente
- [x] Ruta /Clientes/Delete/{id} para eliminaci�n de datos del cliente (con p�gina de confirmaci�n)
- [x] Preparaci�n Modelo para a�adir datos adicionales (2) y uso de `Migrations` para la modificaci�n en la base de datos
- [x] Crear Proyecto Test para pruebas unitarias 
- [x] Prueba unitaria de una acci�n del controlador Home
- [x] Vista `AdditionalData` para la recepci�n de los datos adicionales
- [ ] Pruebas unitarias del CRUD de Cliente
- [ ] A�adir DB constraint a los nuevos campos adicionales
- [ ] Crear ruta /Clientes/AdditionalData/{id} para permitir la actualizaci�n de datos
- [ ] M�dulo de correo con el enlace a la ruta anterior

### Trabajo futuro y sugerencias

* �`TryUpdateModel` o nuevo `ViewModel` para a�adir los datos adicionales?
* Gesti�n de las p�ginas de error
* Registro de excepciones (producci�n)
* A�adir filtro de b�squeda por nombre o apellidos y posibilidad de ordenaci�n por varios campos en la lista de clientes.
* Crear una p�gina `Sobre la aplicaci�n`a partir de este README
* Generaci�n de documentaci�n