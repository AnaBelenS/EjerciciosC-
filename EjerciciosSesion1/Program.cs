/* EJERCICIO 1
 * Escribe un programa que reciba tu nombre y lo escriba por consola.
 */

Console.WriteLine("¿Cómo te llamas?");
string nombre = Console.ReadLine();
Console.WriteLine("Hola " + nombre);


// EJERCICIO 2
// Escribe un programa que tome la hora y la escriba por pantalla.
Console.WriteLine("Introduce la hora");
String hora = Console.ReadLine();
Console.WriteLine("Introduce los minutos");
String minutos = Console.ReadLine();
Console.WriteLine("Introduce los segundos");
String segundos = Console.ReadLine();

Console.WriteLine("Son las " + hora + ":" + minutos + ":" + segundos);