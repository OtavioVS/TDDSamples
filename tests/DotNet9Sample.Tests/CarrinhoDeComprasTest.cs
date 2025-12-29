using DotNet9Sample;
using NUnit.Framework;

[TestFixture]
public class CarrinhoDeComprasTest
{
    private CarrinhoDeCompras carrinho;
    private CarrinhoDeCompras carrinhoComItens;
    private CarrinhoDeCompras carrinhoComUmItem;

    [SetUp]
    public void Inicializa()
    {
        this.carrinho = new CarrinhoDeCompras();

        this.carrinhoComUmItem = new CarrinhoDeComprasBuilder()
            .ComItens(new Item[] { new Item("Geladeira", 1, 900.0) })
            .Cria();

        this.carrinhoComItens = new CarrinhoDeComprasBuilder()
            .ComItens(
                new Item[]
                {
                    new Item("Geladeira", 1, 1500.0),
                    new Item("Microondas", 1, 200.0),
                    new Item("Airfryer", 1, 500.0),
                }
            )
            .Cria();
    }

    [Test]
    public void DeveRetornarZeroSeCarrinhoVazio()
    {
        Assert.That(0.0, Is.EqualTo(carrinho.MaiorValor()).Within(0.0001));
    }

    [Test]
    public void DeveRetornarValorDoItemSeCarrinhoCom1Elemento()
    {
        Assert.That(900.0, Is.EqualTo(carrinhoComUmItem.MaiorValor()).Within(0.0001));
    }

    [Test]
    public void DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos()
    {
        Assert.That(1500.0, Is.EqualTo(carrinhoComItens.MaiorValor()).Within(0.0001));
    }

    [Test]
    public void DeveAdicionarItens()
    {
        // garante que o carrinho está vazio
        Assert.That(0, Is.EqualTo(carrinho.Itens.Count));
        Item item = new Item("Geladeira", 1, 900.0);
        carrinho.Adiciona(item);
        Assert.That(1, Is.EqualTo(carrinho.Itens.Count));
        Assert.That(item, Is.EqualTo(carrinho.Itens[0]));
    }
}
