namespace PokeCalc.Domain.TypeCorrector
{
    internal sealed class Psychic : IEffectiveLoader
    {
        Effective IEffectiveLoader.Correct(IEffectiveLoader defence)
        {
            switch (defence)
            {
                case Psychic _:
                case Steel _:
                    return Effective.NotVery;
                case Fighting _:
                case Poison _:
                    return Effective.Super;
                case Dark _:
                    return Effective.NoEffective;
            }
            return Effective.Flat;
        }
    }
}
