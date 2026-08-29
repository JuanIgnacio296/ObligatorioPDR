namespace Dominio;

public class Compra
{
    private Reserva reserva;
    private DateTime fecha;
    private decimal montoFinal;

    public Compra(Reserva reserva, decimal montoFinal)
    {
        this.reserva = reserva;
        this.montoFinal = montoFinal;
        fecha = DateTime.Now;
    }

    public Reserva Reserva
    {
        get => reserva;
        set => reserva = value;
    }

    public DateTime Fecha
    {
        get => fecha;
        set => fecha = value;
    }

    public decimal MontoFinal
    {
        get => montoFinal;
        set => montoFinal = value;
    }
}
