namespace DotNet9Sample;

/// <summary>
/// Builder for CarrinhoDeCompras.
/// </summary>
public class CarrinhoDeComprasBuilder
{
    private IList<Item> itens = new List<Item>();

    /// <summary>
    /// Adds items to the cart.
    /// </summary>
    /// <param name="itens">The items to add.</param>
    /// <returns>The builder instance.</returns>
    public CarrinhoDeComprasBuilder ComItens(Item[] itens)
    {
        foreach (var item in itens)
        {
            this.itens.Add(item);
        }
        return this;
    }

    /// <summary>
    /// Creates the CarrinhoDeCompras instance.
    /// </summary>
    /// <returns>The created cart.</returns>
    public CarrinhoDeCompras Cria()
    {
        CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
        foreach (var item in itens)
        {
            carrinho.Adiciona(item);
        }
        return carrinho;
    }
}