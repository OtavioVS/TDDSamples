# Test-Driven Development

This project implements examples from the book "Test-Driven Development" by Mauricio Aniche. It demonstrates Test-Driven Development (TDD) practices by building features through tests first, ensuring clean, maintainable code.

## Implemented Classes

### Salary Domain
- **Funcionario**: Abstract base class representing an employee with properties for name and salary. It defines an abstract method `CalcularSalario()` for calculating salary based on employee type.
- **Desenvolvedor**: Inherits from `Funcionario`. Calculates salary with a 10% discount for salaries below 3000, or 20% above.
- **DBA**: Inherits from `Funcionario`. Calculates salary with a 15% discount for salaries below 2000, or 25% above.
- **Testador**: Inherits from `Funcionario`. Same calculation as DBA.
- **CalculadoraDeSalario**: Service class that delegates salary calculation to the `Funcionario` instance, promoting polymorphism.

### Shopping Domain
- **CarrinhoDeCompras**: Represents a shopping cart holding a list of items. Provides methods to add items and find the highest total value.
- **Item**: Represents a cart item with description, quantity, and unit price. Calculates total value.
- **MaiorPreco**: Utility class to find the highest total price in a cart (though the logic is now in `CarrinhoDeCompras`).
- **CarrinhoDeComprasBuilder**: Builder pattern implementation for creating `CarrinhoDeCompras` instances with predefined items.

### Invoice Domain
- **IAcaoAposGerarNota**: Interface for actions to perform after generating an invoice.
- **ITabela**: Interface for tax table calculations.
- **IRelogio**: Interface for time services.
- **RelogioDoSistema**: Implementation of `IRelogio` using system time.
- **Pedido**: Represents an order with client, total value, and item count.
- **NotaFiscal**: Represents an invoice with client, value, and date.
- **SAP**: Service for sending invoices to SAP.
- **NFDao**: Data access object for persisting invoices.
- **GeradorDeNotaFiscal**: Main class for generating invoices from orders, applying taxes, and executing post-generation actions.

## Tests

- **FuncionarioTest**: Tests salary calculations for different employee types and thresholds.
- **CarrinhoDeComprasTest**: Tests cart operations like adding items and finding max values.
- **NotaFiscalTest**: Tests invoice generation, mocking dependencies with Moq.
- **NumerosRomanosTest**: Tests for Roman numeral conversions.

Requirements:
- .NET 9 SDK installed to build and run projects targeting `net9.0`.

Build and run (Windows):

```powershell
dotnet restore
dotnet build
dotnet test
```

