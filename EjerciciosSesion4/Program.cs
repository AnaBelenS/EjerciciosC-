/* Ejercicio 1 - While
 *  Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola. 
 *  Es decir, un programa que presente para el 1:
 *              1 x 1 = 1
 *              1 x 2 = 2
 *              …
 *              1 x 10 = 10
 */

int i = 0;
Console.WriteLine("EJERCICIO 1: \nIntroduce un número para ver su tabla de multiplicar");
int j = Convert.ToInt32(Console.ReadLine());

while (i <= 10)
{
    Console.WriteLine($"{j} x {i} = {j * i}");
    i++;
}

Console.WriteLine("");


/* Ejercicio 2 - Do while
 *  Escribe un programa que realice estos pasos:
 *      - Reciba al menos un número por consola
 *      - Determine si el número es positivo o negativo
 *      - Presente un contador para cada tipo (positivo y negativo).
 *      
 *      - Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. 
 *              Tienes completa libertad para elegir el formato de la salida.
 
*/

int contadorNegativos = 0;
int contadorPositivos = 0;
Console.WriteLine("EJERCICIO 2: \nEscribe un número");
int numeroRecibido = Convert.ToInt32(Console.ReadLine());
if (numeroRecibido == 0)
{
    Console.WriteLine("El número introducido es Cero, este número no es positivo ni negativo.");

}
else if (numeroRecibido < 0)
{

    Console.WriteLine($"El número {numeroRecibido} es negativo.");

    do
    {
        Console.WriteLine(contadorNegativos);

        contadorNegativos--;

    } while (contadorNegativos >= numeroRecibido);

}
else
{
    Console.WriteLine($"El número {numeroRecibido} es positivo.");

    do
    {
        Console.WriteLine(contadorPositivos);

        contadorPositivos++;

    } while (contadorPositivos <= numeroRecibido);
}

Console.WriteLine("");

/* Ejercicio 3 - For
 *  Escribe un programa que realice estos pasos:
 *     - Reciba 3 datos: 
 *          > ancho
 *          > alto
 *          > relleno o no
 *          
 *     - Dibuje en consola con un mismo caracter, por ejemplo *, 
 *       un rectángulo de las dimensiones introducidas y use el tercer dato para discernir 
 *       si el rectángulo está relleno (tiene más * dentro) o no.
 *       
 *     - En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.
 * /
 
 /*     Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos 
 *           que se deben dibujar en la pantalla. Ejemplos:
 *                  - Input: 2,2,2, relleno = true
 *                    Output:
 *                    ** **
 *                    ** **
 *                    
 *                  - Input: 3, 4, 1, relleno = false
 *                    Output:
 *                    ***
 *                    * *
 *                    * *
 *                    ***
 */


Console.WriteLine("EJERCICIO 3: \nIntroduce el Ancho");
int ancho = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduce el Alto");
int alto = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("¿Quieres que esté relleno? S / N");
string? relleno = Console.ReadLine();

if (relleno == "S" || relleno == "s")
{
    for (int a = 0; a < alto; a++)
    {

        for (int b = 0; b < ancho; b++)
        {
            Console.Write("*");
        }
        Console.WriteLine("");
    }
}
else
{

    for (int r = 0; r < alto; r++)
    {
        if (r == 0 || r == alto - 1)
        {
            for (int s = 0; s < ancho; s++)
            {
                Console.Write('*');
            }
            Console.WriteLine("");
        }
        else
        {
            for (int p = 0; p < ancho; p++)
            {
                if (p == 0 || p == ancho - 1)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine("");

        }

    }
}

Console.WriteLine("");


/*     Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos 
 *           que se deben dibujar en la pantalla. Ejemplos:
 *                  - Input: 2,2,2, relleno = true
 *                    Output:
 *                    ** **
 *                    ** **
 *                    
 *                  - Input: 3, 4, 1, relleno = false
 *                    Output:
 *                    ***
 *                    * *
 *                    * *
 *                    ***
 */


Console.WriteLine("EJERCICIO RETO: \nIntroduce el Ancho");
int anchoReto = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduce el Alto");
int altoReto = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Indica el número de cuadros");
int cuadros = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("¿Quieres que esté relleno? S / N");
string? rellenoReto = Console.ReadLine();

if (rellenoReto == "S" || rellenoReto == "s")
{

    for (int a = 0; a < altoReto; a++)
    {
        for (int c = 0; c < cuadros; c++)
        {
            for (int b = 0; b < anchoReto; b++)
            {
                Console.Write("*");

            }
            Console.Write(' ');
        }
        Console.WriteLine("");
    }
}
else
{
    for (int r = 0; r < altoReto; r++)
    {
        if (r == 0 || r == altoReto - 1)
        {

            for (int c = 0; c < cuadros; c++)
            {

                for (int s = 0; s < anchoReto; s++)
                {
                    Console.Write('*');
                }

                Console.Write(' ');
            }

            Console.WriteLine("");
        }
        else
        {

            for (int c = 0; c < cuadros; c++)
            {
                for (int p = 0; p < anchoReto; p++)
                {
                    if (p == 0 || p == anchoReto - 1)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.Write(' ');
            }
            Console.WriteLine("");

        }

    }
}


