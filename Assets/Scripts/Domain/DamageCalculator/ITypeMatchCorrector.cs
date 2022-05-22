namespace PokeCalc.Domain.DamageCalculator
{
    public interface ITypeMatchCorrector
    {
        Damage Correct(Damage damage);
        string State { get; }
    }
}
