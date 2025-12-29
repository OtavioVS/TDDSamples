namespace DotNet9Sample;

/// <summary>
/// Represents a developer employee.
/// </summary>
public class Desenvolvedor : Funcionario
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Desenvolvedor"/> class.
    /// </summary>
    /// <param name="nome">The developer's name.</param>
    /// <param name="salario">The developer's salary.</param>
    public Desenvolvedor(string nome, double salario) : base(nome, salario) { }

    /// <summary>
    /// Calculates the developer's salary with a discount based on salary range.
    /// </summary>
    /// <returns>The calculated salary.</returns>
    public override double CalcularSalario()
    {
        if (Salario > 3000)
            return Salario * 0.8;
        return Salario * 0.9;
    }
}