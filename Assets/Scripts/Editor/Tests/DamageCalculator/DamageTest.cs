using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using PokeCalc.Domain.DamageCalculator;
using System.Linq;

namespace PokeCalc.Test.Domain.DamageCalculator
{
    public class DamageTest
    {
        /// <summary>
        /// 通常のダメージ計算式
        /// </summary>
        [Test]
        public void ダメージ計算_通常()
        {
            var d = new DefaultCalculator(
                new Level(50),
                new Power(100),
                new Offence(182),
                new Defence(189),
                new Corrector()
                ) as IDamageCalculator;

            var dmg = d.Calculate();
            Assert.That(dmg, Is.EqualTo(new Damage(44)));
        }

        [Test]
        public void ダメージ計算_ちきゅうなげ()
        {
            // こうかはばつぐん、いまひとつの影響を受けないこと
            var effective = new FixedCalculator(50, TypeCorrector.Flat) as IDamageCalculator;
            Assert.That(effective.Calculate(), Is.EqualTo(new Damage(50)));

            var super = new FixedCalculator(50, TypeCorrector.Super) as IDamageCalculator;
            Assert.That(super.Calculate(), Is.EqualTo(new Damage(50)));

            var notVery = new FixedCalculator(50, TypeCorrector.NotVery) as IDamageCalculator;
            Assert.That(notVery.Calculate(), Is.EqualTo(new Damage(50)));

            // こうかがない場合は0になること
            var none = new FixedCalculator(50, TypeCorrector.NoEffect) as IDamageCalculator;
            Assert.That(none.Calculate(), Is.EqualTo(new Damage(0)));
        }

        [Test]
        public void DamagePattern()
        {
            var d = new Damage(44);
            var p = new DamagePattern(d, new CriticalCorrector());

            Assert.That(p.Damages.Length, Is.EqualTo(16));
            Assert.That(p.Criticals.Length, Is.EqualTo(16));

            Assert.That(p.Damages,   Is.EqualTo(Damages(37, 37, 38, 38, 39, 39, 40, 40, 40, 41, 41, 42, 42, 43, 43, 44)));
            Assert.That(p.Criticals, Is.EqualTo(Damages(55, 55, 57, 57, 58, 58, 60, 60, 60, 61, 61, 63, 63, 64, 64, 66)));
        }


        Damage[] Damages(params int[] dmgs)
        {
            return dmgs.Select(dmg => new Damage(dmg)).ToArray();
        }

        class CriticalCorrector : ICriticalCorrector
        {
            Damage ICriticalCorrector.Correct(Damage damage)
            {
                return damage.Mul(1.5f);
            }
        }

        class Corrector : IDamageCorrector
        {
            Damage IDamageCorrector.Correct(Damage baseDamage)
            {
                return baseDamage;
            }
        }

        class TypeCorrector : ITypeCorrector
        {
            public static ITypeCorrector Flat => new TypeCorrector(1.0f);
            public static ITypeCorrector Super => new TypeCorrector(2.0f);
            public static ITypeCorrector NotVery => new TypeCorrector(0.5f);
            public static ITypeCorrector NoEffect => new TypeCorrector(0.0f);

            readonly float value;

            private TypeCorrector(float v)
            {
                value = v;
            }
            Damage ITypeCorrector.Correct(Damage damage)
            {
                return damage.Mul(value);
            }

            // TODO:削除していい
            string ITypeCorrector.State => "";
        }
    }
}
