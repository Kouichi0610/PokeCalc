namespace PokeCalc.Domain.DamageCalculator
{
    public interface IDamageCorrector
    {
        Damage Correct(Damage baseDamage);
    }
}
