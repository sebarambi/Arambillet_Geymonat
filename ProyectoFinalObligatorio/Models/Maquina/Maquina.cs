namespace ProyectoFinalObligatorio;
public class Maquina
{
    #region Propiedades
    public int IdMaquina { get; set; }

    public Local Local { get; set; }

    public DateTime FechaCompra { get; set; }

    public int PrecioCompra { get; set; }

    public int VidaUtil { get; set; }

    public TipoMaquina Tipo { get; set; }

    public bool Disponible { get; set; }
    #endregion

    #region Constructor
    public Maquina(int idMaquina, Local local, DateTime fechaCompra, int precioCompra, int vidaUtil, TipoMaquina tipo, bool disponible)
    {
        IdMaquina = idMaquina;
        Local = local;
        FechaCompra = fechaCompra;
        PrecioCompra = precioCompra;
        VidaUtil = vidaUtil;
        Tipo = tipo;
        Disponible = disponible;

    }
    #endregion
}
