namespace Dominio;

public class Modelo
{
    private string nombre;
    private string descripcion;
    private decimal precio;
    private DateTime fechaEntrega;
    private int stock;
    private string? imagen; // SE DEBE CAMBIAR, TODAVIA NO LO DIMOS EN CLASE
    private Usuario creador;

    public Modelo(string nombre, string descripcion, decimal precio, DateTime fechaEntrega, int stock, Usuario creador, string? imagen = null)
    {
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.precio = precio;
        this.fechaEntrega = fechaEntrega;
        this.stock = stock;
        this.creador = creador;
        this.imagen = imagen;
    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    public string Descripcion
    {
        get => descripcion;
        set => descripcion = value;
    }

    public decimal Precio
    {
        get => precio;
        set => precio = value;
    }

    public DateTime FechaEntrega
    {
        get => fechaEntrega;
        set => fechaEntrega = value;
    }

    public int Stock
    {
        get => stock;
        set => stock = value;
    }

    public string? Imagen
    {
        get => imagen;
        set => imagen = value;
    }

    public Usuario Creador
    {
        get => creador;
        set => creador = value;
    }
}
