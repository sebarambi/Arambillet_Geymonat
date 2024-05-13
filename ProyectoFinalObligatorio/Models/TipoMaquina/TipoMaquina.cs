namespace ProyectoFinalObligatorio;
public class TipoMaquina
{
    #region Propiedades
    public int IdTipoMaq { get; set; }

    public string MaquinaNombre { get; set; }

    public string Descripcion { get; set; }
    #endregion

    #region Constructor
    public TipoMaquina (int idTipoMaq, string maquinaNombre, string descripcion)
    {
        IdTipoMaq = idTipoMaq;
        MaquinaNombre = maquinaNombre;
        Descripcion = descripcion;
    }
    #endregion
}
