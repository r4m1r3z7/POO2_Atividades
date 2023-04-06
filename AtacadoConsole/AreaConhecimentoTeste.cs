using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class AreaConhecimentoTeste : BaseTestes
{
    public AreaConhecimentoTeste(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("Executando pesquisa de AreaConhecimento...");

         foreach (AreaConhecimento item in this.context.AreaConhecimentos)
          {
         Console.WriteLine($"{item.CodigoArea} - {item.Descricao}");
          }
          Console.WriteLine("Finalizando AreaConhecimento");
          Console.ReadLine();
    }
}