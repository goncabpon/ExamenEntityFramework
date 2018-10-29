# ExamenEntityFramework

# Pregunta 1

Aquí lo que he hecho ha sido crear la clase contexto, a la que he llamado Pizza_Context, y que extiende de DbContext. Dentro de esa clase, con DbSet<> he puesto las clases a partir de las cuales se van a crear las tablas de la base de datos, que son Pizzas e Ingredients.

A continuación he creado las clases Pizzas e Ingredients, a las que les he puesto Id, Nombres y Precios en el caso de los ingredientes. Cómo una pizza puede tener varios ingredientes, y un ingrediente puede aparecer en varias pizzas, existe una relación many-to-many entre ambas clases, y por ello he añadido también un ICollection<Pizzas> Pizzas en la clase Ingredientes y un ICollection<Ingredients> Ingredients en la clase Pizzas.

Para calcular el precio de las pizzas he creado el valor del beneficio obtenido por cada venta en app.config. Lo he creado en un archivo externo al código para no tener que revisar el código entero en caso de querer modificar el valor del beneficio. Una vez definido el beneficio, el precio de las pizzas lo he calculado sumando el precio de los ingredientes de cada pizza y multiplicándolo por el beneficio que he establecido. Esto lo he hecho en una clase llamada PizzaPrice. Cuando he puesto esta clase en el Pizza_Context y he actualizado la base de datos me ha dado error porque la clase PizzaPrice no tiene PrimaryKey. Creo que debería haber puesto en esa clase los Id de las pizzas y los ingredientes, o haber creado una clase PizzaIngredients donde apareciesen los Id y haber calculado el precio ahí.

Para crear la base de datos, usando enable-migrations, add-migration +nombremigración y update-database se crea la base de datos.
  
# Pregunta 2

Para extraer la interfaz del unit of work he crado una interfaz y en ella he puesto los métodos que tiene UOW y que no implementa el DbContext, que son los que tiene Save. Una vez creada esa interfaz, he hecho que la clase Pizza_Context extienda de la interfaz IUnitOW que he creado.

Para implementar el repository pattern, he creado una interfaz con los métodos que quiero que se hagan para las pizzas (get, add, delete, save) y una clase definiéndolos. En esa clase, a la que he llamado RepositoryPizza, he creado un objeto context de la clase Pizza_Context y he creado un constructor y los métodos que quiero que se hagan para las pizzas: GetPizza (le doy el Id de la pizza y lo busca para context), AddPizza (añade una pizza dándole como parámetro dicha pizza), DeletePizza para eliminar pizzas y Save para guardarlas con SaveChanges();

# Pregunta 3

He utilizado Skip y Take para hacer este ejercicio. Skip se usa para ignorar X elementos de una secuencia y mostrar el resto de elementos. Take se usa para lo contrario; devuelve X elementos de una secuencia e ignora el resto. 

El código significa que de una lista de pizzas, para un tamaño de página de 15 (15 pizzas por página), estando en una determinada página se ignoren todas las pizzas anteriores a esa página (skip((page-1)*pageSize)) y se devuelvan las pizzas de la página en cuestión (Take(pageSize)).


# Pregunta 4

Aquí he creado una propiedad Amount, que es del tipo int, ya que da la cantidad de un ingrediente en una pizza. Esa cantidad es el número de veces que la Id de un ingrediente se repite en una pizza, y eso es lo que he expresado con "var amount = pizza.Ingredients.Sum(c => c.IngId);". Con un if he dicho que si la variable amount es menor que uno lance una excepción y que si no que devuelva la cantidad de ingrediente.
