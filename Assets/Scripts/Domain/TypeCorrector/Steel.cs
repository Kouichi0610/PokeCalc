namespace PokeCalc.Domain.TypeCorrector
{
    internal sealed class Steel : IEffectiveLoader
    {
        Effective IEffectiveLoader.Correct(IEffectiveLoader defence)
        {
            switch (defence)
            {
                case Fire _:
                case Water _:
                case Electric _:
                case Steel _:
                    return Effective.NotVery;
                case Ice _:
                case Rock _:
                case Fairy _:
                    return Effective.Super;
            }
            return Effective.Flat;
        }
    }
}
