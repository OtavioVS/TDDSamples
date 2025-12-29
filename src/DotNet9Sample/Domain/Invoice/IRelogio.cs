namespace DotNet9Sample;

/// <summary>
/// Interface for clock services.
/// </summary>
public interface IRelogio
{
    /// <summary>
    /// Gets the current date and time.
    /// </summary>
    /// <returns>The current date and time.</returns>
    DateTime Hoje();
}