# Test-Driven Development

This project contains implementations of examples from the book "Test-Driven Development" written by Mauricio Aniche.

As I read through the book, I'll be adding code examples here.

## Implemented Classes

- **Funcionario**: Abstract base class for employees with subclasses Desenvolvedor, DBA, and Testador, each implementing salary calculation logic.
- **CalculadoraDeSalario**: Calculator that delegates salary computation to employee objects.
- **CarrinhoDeCompras**: Shopping cart class that holds items.
- **Item**: Represents an item in the cart with description, quantity, and unit price.
- **MaiorPreco**: Finds the highest total price in a shopping cart.

## Tests

- **FuncionarioTest**: Tests salary calculations for different employee types and salary ranges.
- **NumerosRomanosTest**: Tests for Roman numeral conversions (if implemented).

Requirements:
- .NET 9 SDK installed to build and run projects targeting `net9.0`.

Build and run (Windows):

```powershell
dotnet restore
dotnet build
dotnet test
```

