namespace ProyectoFinalObligatorio;
public class TipoSocio
{
    #region Propiedades
    public int IdTipoSocio { get; set; }

    public string TipoNombre { get; set; }

    public string Beneficios { get; set; }
#endregion

    #region Constructor
    public TipoSocio (int idTipoSocio, string tipoNombre, string beneficios)
    {
        IdTipoSocio = idTipoSocio;
        TipoNombre = tipoNombre;
        Beneficios = beneficios;
    }

#endregion
}
