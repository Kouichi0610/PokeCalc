namespace PokeCalc.Domain.TypeCorrector
{
    internal sealed class Electric : IEffectiveLoader
    {
        Effective IEffectiveLoader.Correct(IEffectiveLoader defence)
        {
            switch (defence)
            {
                case Electric _:
                case Grass _:
                case Dragon _:
                    return Effective.NotVery;
                case Water _:
                case Flying _:
                    return Effective.Super;
                case Ground _:
                    return Effective.NoEffective;
            }
            return Effective.Flat;
        }
    }
}
