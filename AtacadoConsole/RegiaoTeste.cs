using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class RegiaoTeste : BaseTestes
{
    public RegiaoTeste(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("Executando pesquisa de Regiao...");

         foreach (Regiao item in this.context.Regioes)
          {
         Console.WriteLine($"{item.CodigoRegiao} - {item.Nome}");
          }
          Console.WriteLine("Finalizando Regiao");
          Console.ReadLine();
    }
}
