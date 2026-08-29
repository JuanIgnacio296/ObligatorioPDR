namespace Dominio;

public class Actividad
{
    private Usuario usuario;
    private TipoActividad tipo;
    private DateTime fecha;
    private string descripcion;

    public Actividad(Usuario usuario, TipoActividad tipo, string descripcion)
    {
        this.usuario = usuario;
        this.tipo = tipo;
        this.descripcion = descripcion;
        fecha = DateTime.Now;
    }

    public Usuario Usuario
    {
        get => usuario;
        set => usuario = value;
    }

    public TipoActividad Tipo
    {
        get => tipo;
        set => tipo = value;
    }

    public DateTime Fecha
    {
        get => fecha;
        set => fecha = value;
    }

    public string Descripcion
    {
        get => descripcion;
        set => descripcion = value;
    }
}
