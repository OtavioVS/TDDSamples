namespace DotNet9Sample;

/// <summary>
/// Represents a shopping cart.
/// </summary>
public class CarrinhoDeCompras
{
    /// <summary>
    /// Gets the list of items in the cart.
    /// </summary>
    public readonly IList<Item> Itens;

    /// <summary>
    /// Initializes a new instance of the <see cref="CarrinhoDeCompras"/> class.
    /// </summary>
    public CarrinhoDeCompras()
    {
        this.Itens = new List<Item>();
    }

    /// <summary>
    /// Adds an item to the cart.
    /// </summary>
    /// <param name="item">The item to add.</param>
    public void Adiciona(Item item)
    {
        this.Itens.Add(item);
    }

    /// <summary>
    /// Gets the highest total value of items in the cart.
    /// </summary>
    /// <returns>The highest total value.</returns>
    public double MaiorValor()
    {
        if (Itens.Count == 0)
            return 0;
        double maior = Itens[0].ValorTotal;
        foreach (var item in Itens)
        {
            if (item.ValorTotal > maior)
                maior = item.ValorTotal;
        }
        return maior;
    }
}