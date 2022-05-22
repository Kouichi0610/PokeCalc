namespace PokeCalc.Domain.TypeCorrector
{
    internal sealed class Normal : IEffectiveLoader
    {
        Effective IEffectiveLoader.Correct(IEffectiveLoader defence)
        {
            switch (defence)
            {
                case Rock _:
                case Steel _:
                    return Effective.NotVery;
                case Ghost _:
                    return Effective.NoEffective;
            }
            return Effective.Flat;
        }
    }
}
