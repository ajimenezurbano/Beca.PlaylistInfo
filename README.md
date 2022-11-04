# Beca.PlaylistInfo
PRÁCTICA API

Antecedentes:
Acabamos de terminar un curso donde se construía una API para consumir Ciudades que, a su vez, cada ciudad tiene una colección de Puntos Turísticos.
Se ha podido ver cómo hacer los controladores, el enrutamiento de los métodos de los controladores, acciones de tipo: get, delete, put, patch y post.
También hemos podido documentarla con swagger, y hemos visto como se usa Entity Framework.

Práctica:
Elegir cualquier tipo de entidad que tenga a su vez una colección de elementos (libertad de elección, pero debe asemejarse a las Ciudades que tienen puntos turísticos). Por ejemplo:
•	Un libro que tiene capítulos
•	Una playlist que tiene canciones
•	Una marca de coches que tiene modelos de coches.
•	Un jugador de una web que tiene puntuaciones en distintos juegos.
•	Cualquier ejemplo del estilo valdría.

A partir de ahora a la Ciudad/libro/playlist… les llamaremos “entidad padre” y a las entidades que están contenidas en la colección (capítulos, puntos de interés, modelos de coches…) les llamaremos “entidades hijas”.

Objetivo: Hacer una API que cumpla las siguientes características:

(Supongamos que escogemos la opción de hacer Libros con Capítulos)

Tipo de proyecto: ASP.Net Core Web API
Project Name: Beca.BookInfo.API
Solution Name: Beca.BookInfo

Base de datos: SQL Lite. (igual que en el curso).
Entity Framework: Entidades:
Entidad Padre: Por ejemplo, Book
-	Columnas:
o	Id. Int. Autoincremental (identidad). PK
o	Title. String. Not null. Max. 50 caracteres.
o	Description. String. Allow null. Max. 300 caracteres.
o	Colección de entidades hijas (en el ejemplo Chapters).
Entidad Hija: Por ejemplo, Chapter
-	Columnas:
o	Id. Int. Autoincremental (identidad). PK
o	Title. String. Not null. Max. 50 caracteres.
o	Description. String. Allow null. Max. 300 caracteres.
o	Book y BookId para hacer referencia al libro al que pertenece el capítulo.

Controlador de la entidad padre: BooksController
-	Puedo obtener todos los libros
-	Puedo obtener un libro por su id (y opcionalmente sus capítulos).
-	Puedo obtener libros filtrando por su título.
-	Puedo obtener los libros de manera paginada.

Controlador para las entidades hijas: ChaptersController
-	Puedo obtener todos los capítulos de un libro
-	Puedo obtener un capítulo de un libro
-	Puedo añadir un capítulo a un libro
-	Puedo modificar por completo un capítulo de un libro
-	Puedo modificar parcialmente un capítulo de un libro
-	Puedo eliminar un capítulo de un libro

Otros requisitos:
-	Se debe inyectar la dependencia para loggear y poder dejar trazas de nivel warning o superior.
-	Se debe utilizar el patrón IRepository para acceder/actualizar la información de base de datos.
-	Debe estar documentada con Swagger y poder probarse desde ahí.
-	Se debe utilizar Automapper para el mapeo de las entidades a modelos y viceversa.
-	Se debe subir el código a un github público y una vez finalizado todo apuntarse en el Excel indicando el enlace al GitHub.

