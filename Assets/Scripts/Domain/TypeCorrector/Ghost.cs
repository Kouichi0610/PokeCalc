namespace PokeCalc.Domain.TypeCorrector
{
    internal sealed class Ghost : IEffectiveLoader
    {
        Effective IEffectiveLoader.Correct(IEffectiveLoader defence)
        {
            switch (defence)
            {
                case Dark _:
                    return Effective.NotVery;
                case Psychic _:
                case Ghost _:
                    return Effective.Super;
                case Normal _:
                    return Effective.NoEffective;
            }
            return Effective.Flat;
        }
    }
}
