using DotNet9Sample;

public class CarrinhoDeComprasBuilder
{
    public CarrinhoDeCompras carrinho;

    public CarrinhoDeComprasBuilder()
    {
        this.carrinho = new CarrinhoDeCompras();
    }

    public CarrinhoDeComprasBuilder ComItens(Item[] valores)
    {
        foreach (Item item in valores)
        {
            int i = 0;
            carrinho.Adiciona(item);
            i++;
        }
        return this;
    }

    public CarrinhoDeCompras Cria()
    {
        return carrinho;
    }
}
