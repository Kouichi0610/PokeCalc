namespace PokeCalc.Domain.TypeCorrector
{
    internal sealed class Dark : IEffectiveLoader
    {
        Effective IEffectiveLoader.Correct(IEffectiveLoader defence)
        {
            switch (defence)
            {
                case Fighting _:
                case Dark _:
                case Fairy _:
                    return Effective.NotVery;
                case Psychic _:
                case Ghost _:
                    return Effective.Super;
            }
            return Effective.Flat;
        }
    }
}
