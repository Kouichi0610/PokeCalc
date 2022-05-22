namespace PokeCalc.Domain.DamageCalculator
{
    public interface ICriticalCorrector
    {
        Damage Correct(Damage damage);
    }
}
