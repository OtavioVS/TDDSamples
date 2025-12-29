using System.Collections.Generic;
using DotNet9Sample;
using Moq;
using NUnit.Framework;

[TestFixture]
public class NotaFiscalTest
{
    [Test]
    public void DeveInvocarAcoesPosteriores()
    {
        Mock<IAcaoAposGerarNota> acao1 = new Mock<IAcaoAposGerarNota>();
        Mock<IAcaoAposGerarNota> acao2 = new Mock<IAcaoAposGerarNota>();
        Mock<IRelogio> relogio = new Mock<IRelogio>();
        Mock<ITabela> tabela = new Mock<ITabela>();
        IList<IAcaoAposGerarNota> acoes = new List<IAcaoAposGerarNota>()
        {
            acao1.Object,
            acao2.Object,
        };
        GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(acoes, relogio.Object, tabela.Object);
        Pedido pedido = new Pedido("Mauricio", 1000, 1);
        NotaFiscal nf = gerador.Gera(pedido);
        acao1.Verify(a => a.Executa(nf));
        acao2.Verify(a => a.Executa(nf));
    }

    [Test]
    public void DeveConsultarATabelaParaCalcularValor()
    {
        // mockando uma tabela, que ainda nem existe
        var tabela = new Mock<ITabela>();
        var relogio = new Mock<IRelogio>();
        // definindo o futuro comportamento "paraValor",
        // que deve retornar 0.2 caso o valor seja 1000.0
        tabela.Setup(t => t.ParaValor(1000.0)).Returns(0.2);
        IList<IAcaoAposGerarNota> nenhumaAcao = new List<IAcaoAposGerarNota>();
        GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(nenhumaAcao, relogio.Object, tabela.Object);
        Pedido pedido = new Pedido("Mauricio", 1000, 1);
        NotaFiscal nf = gerador.Gera(pedido);
        // garantindo que a tabela foi consultada
        tabela.Verify(t => t.ParaValor(1000.0));
        Assert.That(nf.Valor, Is.EqualTo(1000 * 0.2).Within(0.00001));
    }
}
