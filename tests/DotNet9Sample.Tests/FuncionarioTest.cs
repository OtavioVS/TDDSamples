using DotNet9Sample;
using NUnit.Framework;

[TestFixture]
public class CalculadoraDeSalarioTest
{
    [Test]
    public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
    {
        CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
        Funcionario desenvolvedor = new Desenvolvedor("Mauricio", 1500.0);
        double salario = calculadora.CalculaSalario(desenvolvedor);
        Assert.That(salario, Is.EqualTo(1500.0 * 0.9));
    }

    [Test]
    public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAcimaDoLimite()
    {
        CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
        Funcionario desenvolvedor = new Desenvolvedor("Mauricio", 4000.0);
        double salario = calculadora.CalculaSalario(desenvolvedor);
        Assert.That(salario, Is.EqualTo(4000.0 * 0.8).Within(0.00001));
    }

    [Test]
    public void deveCalcularSalarioParaDBAsComSalarioAbaixoDoLimite()
    {
        CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
        Funcionario dba = new DBA("Mauricio", 500.0);
        double salario = calculadora.CalculaSalario(dba);
        Assert.That(salario, Is.EqualTo(500.0 * 0.85).Within(0.00001));
    }
}
