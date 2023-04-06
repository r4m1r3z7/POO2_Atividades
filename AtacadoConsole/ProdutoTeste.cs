using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class ProdutoTeste : BaseTestes
{
    public ProdutoTeste(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("Executando pesquisa de Produto...");

         foreach (Produto item in this.context.Produtos)
          {
         Console.WriteLine($"{item.Codigo} - {item.CodigoSubcategoria} - {item.Descricao} - {item.Valor}");
          }
          Console.WriteLine("Finalizando Produto");
          Console.ReadLine();
    }
}
