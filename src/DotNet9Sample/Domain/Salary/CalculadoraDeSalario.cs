namespace DotNet9Sample;

/// <summary>
/// Calculator for employee salaries.
/// </summary>
public class CalculadoraDeSalario
{
    /// <summary>
    /// Calculates the salary for the given employee.
    /// </summary>
    /// <param name="funcionario">The employee.</param>
    /// <returns>The calculated salary.</returns>
    public double CalculaSalario(Funcionario funcionario)
    {
        return funcionario.CalcularSalario();
    }
}