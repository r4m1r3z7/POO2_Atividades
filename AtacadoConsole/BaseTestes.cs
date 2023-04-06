namespace AtacadoConsole;
using Atacado.BD.EF.Database;

public abstract class BaseTestes
{
    protected AtacadoContext context;
    public BaseTestes(AtacadoContext contexto)
    {
        this.context = contexto;
    }
    public abstract void Imprimir();
}
