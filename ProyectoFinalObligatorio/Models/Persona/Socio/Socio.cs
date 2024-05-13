namespace ProyectoFinalObligatorio;
public class Socio : Persona
{
    #region Propiedades
    public int IdSocio { get; set; }

    public TipoSocio Tipo { get; set; }

    public Local Local { get; set; }
    #endregion


    #region Constructor
    public Socio(int idSocio, string nombre, TipoSocio tipo, string telefono, string mail, Local local)
    {
        IdSocio = idSocio;
        Nombre = nombre;
        Tipo = tipo;
        Telefono = telefono;
        Email = mail;
        Local = local;
    }
    #endregion
}
