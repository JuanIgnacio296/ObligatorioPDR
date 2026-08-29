namespace Dominio;

public class Usuario
{
    private string nombre;
    private string contrasena;
    private bool autenticado;

    public Usuario(string nombre, string contrasena)
    {
        this.nombre = nombre;
        this.contrasena = contrasena;
        autenticado = false;
    }

    public string Nombre
    {
        get => nombre; 
        set => nombre = value; 
    }

    public string Contrasena
    {
        get => contrasena;
        set => contrasena = value;
    }

    public bool Autenticado
    {
        get => autenticado;
        set => autenticado = value;
    }
}