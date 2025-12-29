namespace DotNet9Sample;

/// <summary>
/// Abstract base class for employees.
/// </summary>
public abstract class Funcionario
{
    /// <summary>
    /// Gets the employee's name.
    /// </summary>
    public string Nome { get; private set; }

    /// <summary>
    /// Gets the employee's salary.
    /// </summary>
    public double Salario { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Funcionario"/> class.
    /// </summary>
    /// <param name="nome">The employee's name.</param>
    /// <param name="salario">The employee's salary.</param>
    protected Funcionario(string nome, double salario)
    {
        this.Nome = nome;
        this.Salario = salario;
    }

    /// <summary>
    /// Calculates the employee's salary.
    /// </summary>
    /// <returns>The calculated salary.</returns>
    public abstract double CalcularSalario();
}