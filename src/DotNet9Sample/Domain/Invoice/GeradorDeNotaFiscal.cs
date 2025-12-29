namespace DotNet9Sample;

/// <summary>
/// Generator for nota fiscal.
/// </summary>
public class GeradorDeNotaFiscal
{
    private readonly IList<IAcaoAposGerarNota> acoes;
    private IRelogio relogio;
    private ITabela tabela;

    /// <summary>
    /// Initializes a new instance of the <see cref="GeradorDeNotaFiscal"/> class.
    /// </summary>
    /// <param name="acoes">The list of actions to execute after generating the nota fiscal.</param>
    /// <param name="relogio">The clock service.</param>
    /// <param name="tabela">The tax table.</param>
    public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes, IRelogio relogio, ITabela tabela)
    {
        this.acoes = acoes;
        this.relogio = relogio;
        this.tabela = tabela;
    }

    /// <summary>
    /// Generates a nota fiscal from the given order.
    /// </summary>
    /// <param name="pedido">The order.</param>
    /// <returns>The generated nota fiscal.</returns>
    public NotaFiscal Gera(Pedido pedido)
    {
        NotaFiscal nf = new NotaFiscal(
            pedido.Cliente,
            pedido.ValorTotal * tabela.ParaValor(pedido.ValorTotal),
            relogio.Hoje()
        );
        foreach (var acao in acoes)
        {
            acao.Executa(nf);
        }
        return nf;
    }
}