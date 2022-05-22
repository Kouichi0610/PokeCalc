namespace PokeCalc.Domain.TypeCorrector
{
    internal interface IEffectiveLoader
    {
        Effective Correct(IEffectiveLoader defence);
    }
}
