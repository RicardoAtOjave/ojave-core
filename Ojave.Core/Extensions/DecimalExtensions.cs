namespace Ojave.Core.Extensions;

public static class DecimalExtensions
{
    /// <summary>
    ///     Sets the precision on decimal. Defaulted to 2 and can be changed using a second argument.
    /// </summary>
    /// <param name="value">A System.Decimal value</param>
    /// <param name="precision">A 32-bit Integer value</param>
    /// <returns>
    ///   The decimal value with the requested precision set and rounded away from zero
    /// </returns>
    public static decimal Precision(this decimal value)
        => decimal.Round(value, 2, MidpointRounding.AwayFromZero);

    /// <summary>
    ///     Sets the precision on decimal. Defaulted to 2 and can be changed using a second argument.
    /// </summary>
    /// <param name="value">A System.Decimal value</param>
    /// <param name="precision">A 32-bit Integer value</param>
    /// <returns>
    ///   The decimal value with the requested precision set and rounded away from zero
    /// </returns>
    public static decimal Precision(this decimal value, int precision = 2)
        => decimal.Round(value, precision, MidpointRounding.AwayFromZero);

    /// <summary>
    ///     Used on a decimal within Expression Trees and sets the precision to 2.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>
    ///    The decimal value with a precision of 2 rounded away from zero
    /// </returns>
    public static decimal PrecisionExpression(this decimal value)
        => decimal.Round(value, 2, MidpointRounding.AwayFromZero);
}
