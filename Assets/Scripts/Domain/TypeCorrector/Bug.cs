namespace PokeCalc.Domain.TypeCorrector
{
    internal sealed class Bug : IEffectiveLoader
    {
        Effective IEffectiveLoader.Correct(IEffectiveLoader defence)
        {
            switch (defence)
            {
                case Fire _:
                case Fighting _:
                case Poison _:
                case Flying _:
                case Ghost _:
                case Steel _:
                case Fairy _:
                    return Effective.NotVery;
                case Grass _:
                case Psychic _:
                case Dark _:
                    return Effective.Super;
            }
            return Effective.Flat;
        }
    }
}
