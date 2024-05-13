namespace ProyectoFinalObligatorio;
public class Local
{
    #region Propiedades
    public int IdLocal { get; set; }

    public string Nombre { get; set; }

    public string Ciudad { get; set; }

    public string Direccion { get; set; }

    public string Telefono { get; set; }

    public Responsable Responsable { get; set; }

    public List<Maquina> Maquinas { get; set; }

    public List<Socio> Socios { get; set; }
    #endregion


    #region Constructor
    public Local(int idLocal, string nombre, string ciudad, string direccion, string telefono, Responsable responsable, List<Maquina> maquinas, List<Socio> socios)
    {
        IdLocal = idLocal;
        Nombre = nombre;
        Ciudad = ciudad;
        Direccion = direccion;
        Telefono = telefono;
        Responsable = responsable;
        Maquinas = maquinas;
        Socios = socios;
    }
    #endregion
}
