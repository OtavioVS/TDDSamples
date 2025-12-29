namespace DotNet9Sample;

/// <summary>
/// Finds the highest total price in a shopping cart.
/// </summary>
public class MaiorPreco
{
    /// <summary>
    /// Finds the highest total price.
    /// </summary>
    /// <param name="carrinho">The shopping cart.</param>
    /// <returns>The highest total price, or 0 if the cart is empty.</returns>
    public double Encontra(CarrinhoDeCompras carrinho)
    {
        if (carrinho.Itens.Count == 0)
            return 0;
        return carrinho.Itens[0].ValorTotal;
    }
}