namespace PokeCalc.Domain.TypeCorrector
{
    internal sealed class Fighting : IEffectiveLoader
    {
        Effective IEffectiveLoader.Correct(IEffectiveLoader defence)
        {
            switch (defence)
            {
                case Ghost _:
                    return Effective.NoEffective;
                case Poison _:
                case Flying _:
                case Psychic _:
                case Bug _:
                case Fairy _:
                    return Effective.NotVery;
                case Normal _:
                case Ice _:
                case Rock _:
                case Dark _:
                case Steel _:
                    return Effective.Super;
            }
            return Effective.Flat;
        }
    }
}
