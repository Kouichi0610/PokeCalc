using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using PokeCalc.Domain.DamageCalculator;
using PokeCalc.Domain.Types;
using PokeCalc.Domain.TypeMatch;

namespace PokeCalc.Test.Domain.TypeMatchCorrectorTest
{
    public class TypeMatchCorrectorTest
    {
        [Test]
        public void タイプ一致()
        {
            var offences = new PokeType[] { PokeType.Fire, PokeType.Water };
            var move = PokeType.Water;

            var c = TypeMatchCorrector.Create(offences, move);

            Assert.That(c.Correct(new Damage(20)), Is.EqualTo(new Damage(30)));
        }
        [Test]
        public void タイプ不一致()
        {
            var offences = new PokeType[] { PokeType.Fire, PokeType.Water };
            var move = PokeType.Dark;

            var c = TypeMatchCorrector.Create(offences, move);

            Assert.That(c.Correct(new Damage(20)), Is.EqualTo(new Damage(20)));
        }
    }
}
