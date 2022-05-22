namespace PokeCalc.Domain.TypeCorrector
{
    internal sealed class Ground : IEffectiveLoader
    {
        Effective IEffectiveLoader.Correct(IEffectiveLoader defence)
        {
            switch (defence)
            {
                case Grass _:
                case Bug _:
                    return Effective.NotVery;
                case Fire _:
                case Electric _:
                case Poison _:
                case Rock _:
                case Steel _:
                    return Effective.Super;
                case Flying _:
                    return Effective.NoEffective;

            }
            return Effective.Flat;
        }
    }
}
