using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class CidadeTeste : BaseTestes
{
    public CidadeTeste(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("Executando pesquisa de Cidade...");

         foreach (Cidade item in this.context.Cidades)
          {
         Console.WriteLine($"{item.CodigoCidade} - {item.Nome} - {item.CodigoIBGE7} - {item.UF} - {item.CodigoEstado}");
          }
          Console.WriteLine("Finalizando Cidade");
          Console.ReadLine();
    }
}
