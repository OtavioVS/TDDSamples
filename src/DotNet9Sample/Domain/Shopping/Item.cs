namespace DotNet9Sample;

/// <summary>
/// Represents an item in the shopping cart.
/// </summary>
public class Item
{
    /// <summary>
    /// Gets the item's description.
    /// </summary>
    public string Descricao { get; private set; }

    /// <summary>
    /// Gets the quantity of the item.
    /// </summary>
    public int Quantidade { get; private set; }

    /// <summary>
    /// Gets the unit price of the item.
    /// </summary>
    public double ValorUnitario { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Item"/> class.
    /// </summary>
    /// <param name="descricao">The item's description.</param>
    /// <param name="quantidade">The quantity.</param>
    /// <param name="valorUnitario">The unit price.</param>
    public Item(string descricao, int quantidade, double valorUnitario)
    {
        this.Descricao = descricao;
        this.Quantidade = quantidade;
        this.ValorUnitario = valorUnitario;
    }

    /// <summary>
    /// Gets the total value of the item.
    /// </summary>
    public double ValorTotal
    {
        get { return this.ValorUnitario * this.Quantidade; }
    }
}