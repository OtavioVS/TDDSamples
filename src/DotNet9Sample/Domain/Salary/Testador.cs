namespace DotNet9Sample;

/// <summary>
/// Represents a tester employee.
/// </summary>
public class Testador : Funcionario
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Testador"/> class.
    /// </summary>
    /// <param name="nome">The tester's name.</param>
    /// <param name="salario">The tester's salary.</param>
    public Testador(string nome, double salario) : base(nome, salario) { }

    /// <summary>
    /// Calculates the tester's salary with a discount based on salary range.
    /// </summary>
    /// <returns>The calculated salary.</returns>
    public override double CalcularSalario()
    {
        if (Salario > 2000)
            return Salario * 0.75;
        return Salario * 0.85;
    }
}