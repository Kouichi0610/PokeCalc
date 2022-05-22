namespace PokeCalc.Domain.TypeCorrector
{
    internal sealed class Ice : IEffectiveLoader
    {
        Effective IEffectiveLoader.Correct(IEffectiveLoader defence)
        {
            switch (defence)
            {
                case Fire _:
                case Water _:
                case Ice _:
                case Steel _:
                    return Effective.NotVery;
                case Grass _:
                case Ground _:
                case Flying _:
                case Dragon _:
                    return Effective.Super;
            }
            return Effective.Flat;
        }
    }
}
