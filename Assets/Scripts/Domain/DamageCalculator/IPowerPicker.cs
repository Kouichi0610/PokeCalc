using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PokeCalc.Domain.DamageCalculator
{
    public interface IPowerPicker
    {
        Power Power { get; }
    }
}
