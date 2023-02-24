/* Ejercicio 1
 * Variables Escribe un programa que reciba datos de una persona y genera un mensaje, 
 * usa una variable para cada dato y otra para el mensaje. 
 * Ej: nombre, apellido, edad, sabe programar, etc.
 */

string nombre;
string apellido;
int edad;

Console.WriteLine("Introduce tu nombre: ");
nombre = Console.ReadLine();

Console.WriteLine("Introduce tu apellido: ");
apellido = Console.ReadLine();

Console.WriteLine("Intruduce tu edad: ");
edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Eres " + nombre + " " + apellido + " y tienes " + edad + " años.");


/*Ejercicio 2
 * Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:
 * 
 * Coche: puertas, ruedas, marca, ITV vigente
 * Mesa: peso, largo, material, color
 * 
 * Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.
 **/

int puertas;
int ruedas;
string marca;
bool itvVigente;

int peso;
int largo;
string material;
string color;

/* Ejercicio 3
 * 
 * Operadores Determina los operadores para verificar las siguientes condiciones:
 * 
 * Un número es mayor o igual a 18
 * Un char es ‘a’
 * Se cumplen dos conciones a la vez (ambas verdaderas)
 * Se cumple una de dos condiciones a la vez (una true y otra false)
 * 
 * Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.
 * */

//Un número es mayor o igual a 18
int numeroMayorIgual = 1;
Console.WriteLine("Mayor o Igual: " +(20 >= numeroMayorIgual));

//Un char es ‘a’
char caracterIgual = 'a';
Console.WriteLine("¿Char es igual a 'a'?: " + (caracterIgual == 'a'));

//Se cumplen dos conciones a la vez (ambas verdaderas)
Console.WriteLine("¿Es 20 menor o igual que uno y Char es igual a 'a'?: " + (20 >= numeroMayorIgual && caracterIgual == 'a'));

//Se cumple una de dos condiciones a la vez (una true y otra false)
Console.WriteLine("¿Es 20 mayor o igual que uno y Char es igual a 'a'?: " + (20 <= numeroMayorIgual || caracterIgual == 'a'));