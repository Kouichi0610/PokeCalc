using System.Collections.Generic;
using PokeCalc.Domain.Types;

namespace PokeCalc.Domain.TypeCorrector
{
    internal sealed class Factory
    {
        Dictionary<PokeType, IEffectiveLoader> dict = new Dictionary<PokeType, IEffectiveLoader>()
        {
            {PokeType.Normal, new Normal()},
            {PokeType.Fire, new Fire()},
            {PokeType.Water, new Water()},
            {PokeType.Electric, new Electric()},
            {PokeType.Grass, new Grass()},
            {PokeType.Ice, new Ice()},
            {PokeType.Fighting, new Fighting()},
            {PokeType.Poison, new Poison()},
            {PokeType.Ground, new Ground()},
            {PokeType.Flying, new Flying()},
            {PokeType.Psychic, new Psychic()},
            {PokeType.Bug, new Bug()},
            {PokeType.Rock, new Rock()},
            {PokeType.Ghost, new Ghost()},
            {PokeType.Dragon, new Dragon()},
            {PokeType.Dark, new Dark()},
            {PokeType.Steel, new Steel()},
            {PokeType.Fairy, new Fairy()},
        };
        public IEffectiveLoader Create(PokeType type)
        {
            return dict[type];
        }
    }
}
