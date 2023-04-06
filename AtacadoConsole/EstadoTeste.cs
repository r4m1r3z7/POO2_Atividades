using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class EstadoTeste : BaseTestes
{
    public EstadoTeste(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("Executando pesquisa de Estado...");

         foreach (Estado item in this.context.Estados)
          {
         Console.WriteLine($"{item.CodigoEstado} - {item.Nome} - {item.UF} - {item.CodigoRegiao}");
          }
          Console.WriteLine("Finalizando Estado");
          Console.ReadLine();
    }
}
