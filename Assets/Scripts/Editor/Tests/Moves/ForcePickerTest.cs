using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

using PokeCalc.Domain.DamageCalculator;
using PokeCalc.Domain.Moves;

namespace PokeCalc.Test.Domain.Moves
{
    public class ForcePickerTest
    {
        [Test]
        public void ぶつり()
        {
        }
        [Test]
        public void とくしゅ()
        {
        }
        [Test]
        public void ボディプレス()
        {
        }
        [Test]
        public void サイコショック()
        {
        }
        [Test]
        public void イカサマ()
        {
        }
        [Test]
        public void シェルアームズ()
        {
        }

        class Force : IForce
        {
            public IStats Offence { get; private set; }
            public IStats Defence { get; private set; }



        }
    }
}
