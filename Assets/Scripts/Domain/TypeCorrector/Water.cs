namespace PokeCalc.Domain.TypeCorrector
{
    internal sealed class Water : IEffectiveLoader
    {
        Effective IEffectiveLoader.Correct(IEffectiveLoader defence)
        {
            switch (defence)
            {
                case Water _:
                case Grass _:
                case Dragon _:
                    return Effective.NotVery;
                case Fire _:
                case Ground _:
                case Rock _:
                    return Effective.Super;
            }
            return Effective.Flat;
        }
    }
}
