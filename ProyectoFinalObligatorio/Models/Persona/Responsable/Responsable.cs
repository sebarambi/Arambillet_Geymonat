namespace ProyectoFinalObligatorio;
public class Responsable : Persona
{
    #region Propiedades
    public int IdResponsable { get; set; }

    #endregion

    #region Constructor
    public Responsable(int idResponsable, string nombre, string telefono)
    {
        IdResponsable = idResponsable;
        Nombre = nombre;
        Telefono = telefono;
    }
    #endregion
}
