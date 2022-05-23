namespace PokeCalc.Domain.DamageCalculator
{
    /// <summary>
    /// U–h‚Ìí—Í‚ğæ“¾
    /// </summary>
    public interface IForcePicker
    {
        Offence Offence { get; }
        Defence Defence { get; }
        Power Power { get; }
    }
}
