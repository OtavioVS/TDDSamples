namespace DotNet9Sample;

/// <summary>
/// Represents a DBA employee.
/// </summary>
public class DBA : Funcionario
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DBA"/> class.
    /// </summary>
    /// <param name="nome">The DBA's name.</param>
    /// <param name="salario">The DBA's salary.</param>
    public DBA(string nome, double salario) : base(nome, salario) { }

    /// <summary>
    /// Calculates the DBA's salary with a discount based on salary range.
    /// </summary>
    /// <returns>The calculated salary.</returns>
    public override double CalcularSalario()
    {
        if (Salario > 2000)
            return Salario * 0.75;
        return Salario * 0.85;
    }
}