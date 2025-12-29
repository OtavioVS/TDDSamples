namespace DotNet9Sample;

/// <summary>
/// System clock implementation.
/// </summary>
public class RelogioDoSistema : IRelogio
{
    /// <summary>
    /// Gets the current date and time from the system.
    /// </summary>
    /// <returns>The current date and time.</returns>
    public DateTime Hoje()
    {
        return DateTime.Now;
    }
}