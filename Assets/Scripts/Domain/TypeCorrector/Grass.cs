namespace PokeCalc.Domain.TypeCorrector
{
    internal sealed class Grass : IEffectiveLoader
    {
        Effective IEffectiveLoader.Correct(IEffectiveLoader defence)
        {
            switch (defence)
            {
                case Fire _:
                case Grass _:
                case Poison _:
                case Flying _:
                case Bug _:
                case Dragon _:
                case Steel _:
                    return Effective.NotVery;
                case Water _:
                case Ground _:
                case Rock _:
                    return Effective.Super;
            }
            return Effective.Flat;
        }
    }
}
