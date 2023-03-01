/* Ejercicio 1
 * Crea una estructura de datos para un cliente con estos campos:
 *  - Nombre completo 
 *  - Teléfono
 *  - Dirección
 *  - Email
 *  - Si es nuevo cliente
 *  
 *  Bonus: escribe un método para presentar estos datos desde la estructura 
 *  al hacer Console.WriteLine(...)
 * 
 */

Cliente miCliente = new Cliente("Antonio Espejo", 666555444, "C/ Alcantara, 3", "antonio@gmail.com", "Si");
Console.WriteLine(miCliente);


public struct Cliente
{
 
    public Cliente(string Nombre, int Telefono, string Direccion, string Email, string Nuevo)
    {
        NombreCliente = Nombre;
        TelefonoCliente = Telefono;
        DireccionCliente = Direccion;
        EmailCliente = Email;
        NuevoCliente = Nuevo;
    }

    public string NombreCliente { get; set; }
    public int TelefonoCliente { get; set; }
    public string DireccionCliente { get; set; }
    public string EmailCliente { get; set; }
    public string NuevoCliente { get; set; }

    public override string ToString() => $"Nombre del Cliente: {NombreCliente}, Teléfono: {TelefonoCliente}, Dirección: {DireccionCliente}, Email: {EmailCliente}, Cliente nuevo: {NuevoCliente}";




}


