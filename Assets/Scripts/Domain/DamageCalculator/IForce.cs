namespace PokeCalc.Domain.DamageCalculator
{
    /// <summary>
    /// UŒ‚‘¤‚Æ–hŒä‘¤‚Ìí—Í
    /// </summary>
    public interface IForce
    {
        IStats Offence { get; }
        IStats Defence { get; }
    }
}
