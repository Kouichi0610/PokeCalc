namespace PokeCalc.Domain.TypeCorrector
{
    internal sealed class Poison : IEffectiveLoader
    {
        Effective IEffectiveLoader.Correct(IEffectiveLoader defence)
        {
            switch (defence)
            {
                case Poison _:
                case Ground _:
                case Rock _:
                case Ghost _:
                    return Effective.NotVery;
                case Grass _:
                case Fairy _:
                    return Effective.Super;
                case Steel _:
                    return Effective.NoEffective;
            }
            return Effective.Flat;
        }
    }
}
