using DotNet9Sample;
using NUnit.Framework;

[TestFixture]
public class ConversorDeNumeroRomanoTest
{
    [Test]
    public void DeveEntenderOSimboloI()
    {
        ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
        int numero = romano.Converte("I");
        Assert.That(numero, Is.EqualTo(1));
    }

    [Test]
    public void DeveEntenderOSimboloV()
    {
        ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
        int numero = romano.Converte("V");
        Assert.That(numero, Is.EqualTo(5));
    }
    
    [Test]
    public void DeveEntenderDoisSimbolosComoII()
    {
        ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
        int numero = romano.Converte("II");
        Assert.That(numero, Is.EqualTo(2));
    }

    [Test]
    public void DeveEntenderQuatroSimbolosDoisADoisComoXXII()
    {
        ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
        int numero = romano.Converte("XXII");
        Assert.That(numero, Is.EqualTo(22));
    }

    [Test]
    public void DeveEntenderNumerosComoIX()
    {
        ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
        int numero = romano.Converte("IX");
        Assert.That(numero, Is.EqualTo(9));
    }

    [Test]
    public void DeveEntenderNumerosComplexosComoXXIV()
    {
        ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
        int numero = romano.Converte("XXIV");
        Assert.That(numero, Is.EqualTo(24));
    }
}

