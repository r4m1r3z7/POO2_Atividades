using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class SubcategoriaTestes : BaseTestes
{
    public SubcategoriaTestes(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("Executando pesquisa de Subcategoria...");

         foreach (Subcategoria item in this.context.Subcategorias)
          {
         Console.WriteLine($"{item.Codigo} -{item.CodigoCategoria} - {item.Descricao}");
          }
          Console.WriteLine("Finalizando Subcategoria");
          Console.ReadLine();
    }
}
