namespace Dominio;

public class Reserva
{
    private Usuario usuario;
    private Modelo modelo;
    private EstadoReserva estado;
    private DateTime fechaCreacion;
    private DateTime fechaActualizacion;

    public Reserva(Usuario usuario, Modelo modelo)
    {
        this.usuario = usuario;
        this.modelo = modelo;
        estado = EstadoReserva.Pendiente;
        fechaCreacion = DateTime.Now;
        fechaActualizacion = fechaCreacion;
    }

    public Usuario Usuario
    {
        get => usuario;
        set => usuario = value;
    }

    public Modelo Modelo
    {
        get => modelo;
        set => modelo = value;
    }

    public EstadoReserva Estado
    {
        get => estado;
        set => estado = value;
    }

    public DateTime FechaCreacion
    {
        get => fechaCreacion;
        set => fechaCreacion = value;
    }

    public DateTime FechaActualizacion
    {
        get => fechaActualizacion;
        set => fechaActualizacion = value;
    }
}
