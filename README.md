# Sistema de Gestión de Tienda de Ropa | Grupo 9

## Descripción del sistema

El sistema tiene como objetivo gestionar las operaciones principales de una tienda de ropa. Permitirá administrar los productos disponibles, sus categorías, los clientes y los vendedores, además de registrar las ventas realizadas.

La aplicación será desarrollada como una aplicación de escritorio utilizando Windows Forms y estará conectada a una base de datos mediante Entity Framework Core. El proyecto estará organizado en capas para separar la interfaz, la lógica de acceso a datos y las entidades del sistema.

Las principales entidades del sistema serán:

* **Producto:** representa las prendas disponibles para la venta, incluyendo información como nombre, precio, stock y categoría.
* **Categoría:** permite clasificar los productos según su tipo, por ejemplo remeras, pantalones, camperas, accesorios, etc.
* **Cliente:** almacena los datos básicos de las personas que realizan compras.
* **Vendedor:** representa a los empleados encargados de registrar las ventas.
* **Venta:** representa una operación de compra realizada por un cliente y registrada por un vendedor.
* **DetalleVenta:** registra los productos incluidos en cada venta, junto con su cantidad y precio.

## Objetivos

Los objetivos principales del sistema son:

* Gestionar de manera sencilla los productos disponibles en la tienda.
* Organizar los productos mediante categorías.
* Registrar y administrar los clientes.
* Registrar y administrar los vendedores.
* Registrar las ventas realizadas y los productos incluidos en cada una.
* Mantener actualizado el stock de los productos.
* Asociar cada venta con el cliente correspondiente y el vendedor que la registró.
* Facilitar la consulta de información mediante reportes.
  
## Funcionalidades previstas

### Gestión de productos

* Dar de alta un producto.
* Modificar los datos de un producto.
* Dar de baja un producto.
* Consultar los productos registrados.
* Consultar el stock disponible.

### Gestión de categorías

* Dar de alta una categoría.
* Modificar una categoría.
* Dar de baja una categoría.
* Consultar las categorías registradas.

### Gestión de clientes

* Dar de alta un cliente.
* Modificar los datos de un cliente.
* Dar de baja un cliente.
* Consultar los clientes registrados.

### Gestión de vendedores

* Dar de alta un vendedor.
* Modificar los datos de un vendedor.
* Dar de baja un vendedor.
* Consultar los vendedores registrados.

### Gestión de ventas

* Registrar una nueva venta.
* Seleccionar un cliente para la venta.
* Seleccionar el vendedor que registra la venta.
* Agregar uno o más productos a la venta.
* Registrar la cantidad de cada producto.
* Calcular el total de la venta.
* Actualizar el stock de los productos vendidos.
* Consultar las ventas realizadas.

## Reportes

El sistema permitirá generar los siguientes reportes:

1. **Productos con stock disponible:** mostrará los productos registrados junto con su stock actual.

2. **Ventas por cliente:** permitirá consultar las ventas realizadas por cada cliente y el total de compras realizadas.

3. **Ventas por vendedor:** permitirá consultar las ventas registradas por cada vendedor.

4. **Vendedor con mayor cantidad de ventas:** permitirá identificar al vendedor que haya registrado la mayor cantidad de ventas.

5. **Productos por categoría:** permitirá consultar los productos agrupados según su categoría.

## Integración de las capas

El sistema estará organizado en diferentes capas donde cada una tendrá una responsabilidad específica. La idea es que los datos vayan pasando de una capa a otra hasta llegar a la base de datos, evitando que todas las partes del sistema estén mezcladas.

Por ejemplo, para registrar un nuevo producto, el recorrido sería el siguiente:

1. **Capa de presentación:** el usuario completa los datos del producto desde un formulario de Windows Forms. Al presionar el botón para guardar, la información ingresada se envía a la siguiente capa.

2. **Capa de lógica o servicios:** recibe los datos provenientes del formulario y se encarga de realizar las validaciones necesarias antes de guardarlos.

3. **Capa de acceso a datos:** una vez que los datos fueron validados, esta capa se encarga de comunicarse con la base de datos utilizando Entity Framework Core. Se crea el objeto `Producto` con los datos recibidos y se agrega al contexto de Entity Framework.

4. **Entity Framework Core y base de datos:** Entity Framework Core transforma la operación realizada sobre el objeto en la consulta correspondiente y la ejecuta sobre la base de datos. De esta manera, el nuevo producto queda almacenado en la tabla correspondiente.

5. **Respuesta al usuario:** una vez que la operación se completa correctamente, el resultado vuelve hacia la capa de presentación y el sistema informa al usuario que el producto fue registrado correctamente. Si ocurre algún error, se informa para que pueda corregirse.

## Diagrama de clases

El diagrama de clases inicial del sistema se encuentra en:

[Diagrama/diagrama-clases.png](https://github.com/laraglaria/TP_Gestion_Tienda_Ropa_Grupo_9/blob/main/Diagrama%20de%20clases.png)

