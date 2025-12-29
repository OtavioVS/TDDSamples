namespace DotNet9Sample;

/// <summary>
/// Represents an order.
/// </summary>
public class Pedido
{
    /// <summary>
    /// Gets the client's name.
    /// </summary>
    public string Cliente { get; private set; }

    /// <summary>
    /// Gets the total value of the order.
    /// </summary>
    public double ValorTotal { get; private set; }

    /// <summary>
    /// Gets the number of items in the order.
    /// </summary>
    public int QuantidadeItens { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Pedido"/> class.
    /// </summary>
    /// <param name="cliente">The client's name.</param>
    /// <param name="valorTotal">The total value.</param>
    /// <param name="quantidadeItens">The number of items.</param>
    public Pedido(string cliente, double valorTotal, int quantidadeItens)
    {
        this.Cliente = cliente;
        this.ValorTotal = valorTotal;
        this.QuantidadeItens = quantidadeItens;
    }
}