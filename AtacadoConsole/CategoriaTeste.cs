namespace AtacadoConsole;
using Atacado.BD.EF.Database;

public class CategoriaTeste: BaseTestes
{
    public CategoriaTeste (AtacadoContext contexto) : base (contexto)
    {
        
    }

    public override void Imprimir()
    {
        Console.WriteLine("Executando pesquisa de Categoria...");

         foreach (Categoria item in this.context.Categorias)
          {
         Console.WriteLine($"{item.Codigo} - {item.Descricao}");
          }
          Console.WriteLine("Finalizando Categoria");
          Console.ReadLine();
    }
}
