namespace PokeCalc.Domain.TypeCorrector
{
    internal sealed class Rock : IEffectiveLoader
    {
        Effective IEffectiveLoader.Correct(IEffectiveLoader defence)
        {
            switch (defence)
            {
                case Fighting _:
                case Ground _:
                case Steel _:
                    return Effective.NotVery;
                case Fire _:
                case Ice _:
                case Flying _:
                case Bug _:
                    return Effective.Super;
            }
            return Effective.Flat;
        }
    }
}
