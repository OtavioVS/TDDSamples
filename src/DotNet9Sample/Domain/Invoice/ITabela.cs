namespace DotNet9Sample;

/// <summary>
/// Interface for tax table calculations.
/// </summary>
public interface ITabela
{
    /// <summary>
    /// Gets the tax rate for the given value.
    /// </summary>
    /// <param name="valor">The value.</param>
    /// <returns>The tax rate.</returns>
    double ParaValor(double valor);
}