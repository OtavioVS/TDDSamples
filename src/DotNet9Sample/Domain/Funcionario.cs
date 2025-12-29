namespace DotNet9Sample;

public abstract class Funcionario
{
    public string Nome { get; private set; }
    public double Salario { get; private set; }

    protected Funcionario(string nome, double salario)
    {
        this.Nome = nome;
        this.Salario = salario;
    }

    public abstract double CalcularSalario();
}

public class Desenvolvedor : Funcionario
{
    public Desenvolvedor(string nome, double salario) : base(nome, salario) { }

    public override double CalcularSalario()
    {
        if (Salario > 3000)
            return Salario * 0.8;
        return Salario * 0.9;
    }
}

public class DBA : Funcionario
{
    public DBA(string nome, double salario) : base(nome, salario) { }

    public override double CalcularSalario()
    {
        if (Salario > 2000)
            return Salario * 0.75;
        return Salario * 0.85;
    }
}

public class Testador : Funcionario
{
    public Testador(string nome, double salario) : base(nome, salario) { }

    public override double CalcularSalario()
    {
        if (Salario > 2000)
            return Salario * 0.75;
        return Salario * 0.85;
    }
}

public class CalculadoraDeSalario
{
    public double CalculaSalario(Funcionario funcionario)
    {
        return funcionario.CalcularSalario();
    }
}
