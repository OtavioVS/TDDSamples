namespace DotNet9Sample;

/// <summary>
/// Represents a nota fiscal (invoice).
/// </summary>
public class NotaFiscal
{
    /// <summary>
    /// Gets the client's name.
    /// </summary>
    public string Cliente { get; private set; }

    /// <summary>
    /// Gets the value of the nota fiscal.
    /// </summary>
    public double Valor { get; private set; }

    /// <summary>
    /// Gets the date of the nota fiscal.
    /// </summary>
    public DateTime Data { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="NotaFiscal"/> class.
    /// </summary>
    /// <param name="cliente">The client's name.</param>
    /// <param name="valor">The value.</param>
    /// <param name="data">The date.</param>
    public NotaFiscal(string cliente, double valor, DateTime data)
    {
        this.Cliente = cliente;
        this.Valor = valor;
        this.Data = data;
    }
}