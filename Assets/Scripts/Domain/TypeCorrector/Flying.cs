namespace PokeCalc.Domain.TypeCorrector
{
    internal sealed class Flying : IEffectiveLoader
    {
        Effective IEffectiveLoader.Correct(IEffectiveLoader defence)
        {
            switch (defence)
            {
                case Electric _:
                case Rock _:
                case Steel _:
                    return Effective.NotVery;
                case Grass _:
                case Fighting _:
                case Bug _:
                    return Effective.Super;
            }
            return Effective.Flat;
        }
    }
}
