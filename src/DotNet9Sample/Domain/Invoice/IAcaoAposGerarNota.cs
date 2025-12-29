namespace DotNet9Sample;

/// <summary>
/// Interface for actions to be executed after generating a nota fiscal.
/// </summary>
public interface IAcaoAposGerarNota
{
    /// <summary>
    /// Executes the action.
    /// </summary>
    /// <param name="nf">The nota fiscal.</param>
    void Executa(NotaFiscal nf);
}