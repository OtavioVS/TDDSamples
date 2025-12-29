namespace DotNet9Sample;

public abstract class Funcionario
{
    public string Nome { get; private set; }
    public double Salario { get; private set; }

    protected Funcionario(string nome, double salario)
    {
        this.Nome = nome;
        this.Salario = salario;ad
    }

    public abstract double CalcularSalario();
}

public class Desenvolvedor : Funcionario
{
    public Desenvolvedor(string nome, double salario) : base(nome, salario) { }

    public override double CalcularSalario()
    {
        return new DezOuVintePorCento().Calcula(this);
    }
}

public class DBA : Funcionario
{
    public DBA(string nome, double salario) : base(nome, salario) { }

    public override double CalcularSalario()
    {
        return new QuinzeOuVinteCincoPorCento().Calcula(this);
    }
}

public class Testador : Funcionario
{
    public Testador(string nome, double salario) : base(nome, salario) { }

    public override double CalcularSalario()
    {
        return new QuinzeOuVinteCincoPorCento().Calcula(this);
    }
}

public class CalculadoraDeSalario
{
    public double CalculaSalario(Funcionario funcionario)
    {
        return funcionario.CalcularSalario();
    }
}
