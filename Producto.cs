class Producto
{
    private static int cantidadProductosCreados = 0;
    private string nombre;
    private int precio;
    private int cantidad;
    public Producto(string nombre, int precio, int cantidad)
    {
        this.nombre = nombre;
        this.precio = precio;
        this.cantidad = 0;
        cantidadProductosCreados++;
    }

    public string Nombre { get { return nombre; }  set { nombre = value; } }
    public int Precio { get { return precio; }  set { precio = value; } }

    public int Cantidad { get { return cantidad;} set{ cantidad = value; } }
    

    public static int contadorProductos()
    {
        return cantidadProductosCreados;
    }

    public int AgregarCantidad(int cant)
    {
        return cantidad = cantidad + cant;
    }

    public int CalcularPrecio()
    {
        return precio * cantidad; 
    }

    public int Vender(int cant, string nombreProducto)
    {
        if(this.nombre == nombreProducto)
        {
            cantidad = cantidad - cant;
        }
        return cantidad;
    }

    public void ImprimirInformacion()
    {
        Console.WriteLine($"Nombre del producto: {Nombre}\nCantidad de {Nombre}: {Cantidad}\nPrecio del total de {Nombre}: {CalcularPrecio()}");

    }

}