# DotNet9Sample

Minimal C# .NET 9 sample solution.

Requirements:
- .NET 9 SDK installed to build and run projects targeting `net9.0`.

Build and run (Windows):

```powershell
dotnet restore
dotnet build
dotnet test
```

If you don't have .NET 9 installed, you can either install it from Microsoft or change the TargetFramework in the project files to `net8.0` and run the same commands.
