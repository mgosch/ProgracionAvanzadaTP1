# Trabajo Práctico
Alan Facundo Biglieri

Cristian Espíndola

Victoria Gosch

Bruno Mastrangelo

Natacha Martínez

Iván Montano

# Respuesta Conversiones 1

- Convert:Convierte un tipo de datos base en otro tipo de datos base.

Al usar el método para convertir un valor int en bool mediante Convert.ToBoolean o de forma contraria convertir un bool en int mediante Convert.ToInt32, la conversión se realiza de forma exitosa en el formato de dato esperado.

- Parse: Convierte un tipo de datos string en otro tipo de datos base. Si no puede lograr la conversión, arroja una excepción.

Al usar el método bool.Parse para convertir un string “true” o “false”, la conversión se realiza correctamente al valor boolean correspondiente.
Si se realiza el mismo método, pero intentando convertir un string “1” o “0” se recibe una excepción de “System.FormatException: String was not recognized as a valid Boolean.”
Por otro lado, si se realiza el mismo método pero intentando convertir un Int 1 o 0 se recibe un error de compilación ya que el método bool.Parse recibe como parámetro/argumento un string: “The best overloaded method match for `bool.Parse(string)' has some invalid arguments”

- TryParse: Convierte un tipo de datos string en otro tipo de datos base. Si no puede lograr la conversión, devuelve false (booleano).

Si al método bool.TryParse se le pasa como argumento un string ya sea “true” o “false”, la conversión dará como resultado un boolean de valor True.
En cambio si al mismo método se le indica como argumento un string “1” o “0”, , la conversión dará como resultado un boolean de valor False.
Por otro lado si se le indica como argumento un int 1 o 0, se recibe un error de compilación ya que el método bool.TryParse acepta como argumento solo datos del tipo sting: “The best overloaded method match for `bool.TryParse(string, out bool)' has some invalid arguments”

# Respuesta Conversiones 2

2.a) Muestra el número entero correspondiente.

2.b) No muestra los decimales porque no tiene decimales que mostrar.

2.c) Convierte el entero al tipo de dato short cuyos valores oscilan entre el -32.768 y 32.768

# Respuesta Conversiones 6

La principal diferencia, en la mayoría de los lenguajes, es que un for itera
sobre cosas que no tienen porqué existir, y nos garantiza el orden de acceso; 
por su parte, un for-each itera sobre cosas que, obligatoriamente, han de existir. 
Además, no nos garantiza el orden en el que se accede. 


