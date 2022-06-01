using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

using PokeCalc.Domain.DamageCalculator;
using PokeCalc.Domain.Stats;
using PokeCalc.Domain.Stats.Calculator;
using PokeCalc.Domain.Stats.Builder;

namespace PokeCalc.Test.Domain.Stats.Builder
{
    public class BuilderTest
    {
        [Test]
        [TestCase(Nature.Bashful,   207, 152, 152, 152, 152, 152)]
        [TestCase(Nature.Lonely,    207, 167, 136, 152, 152, 152)]
        [TestCase(Nature.Adamant,   207, 167, 152, 136, 152, 152)]
        [TestCase(Nature.Naughty,   207, 167, 152, 152, 136, 152)]
        [TestCase(Nature.Brave,     207, 167, 152, 152, 152, 136)]
        [TestCase(Nature.Bold,      207, 136, 167, 152, 152, 152)]
        [TestCase(Nature.Impish,    207, 152, 167, 136, 152, 152)]
        [TestCase(Nature.Lax,       207, 152, 167, 152, 136, 152)]
        [TestCase(Nature.Relaxed,   207, 152, 167, 152, 152, 136)]
        [TestCase(Nature.Modest,    207, 136, 152, 167, 152, 152)]
        [TestCase(Nature.Mild,      207, 152, 136, 167, 152, 152)]
        [TestCase(Nature.Rash,      207, 152, 152, 167, 136, 152)]
        [TestCase(Nature.Quiet,     207, 152, 152, 167, 152, 136)]
        [TestCase(Nature.Calm,      207, 136, 152, 152, 167, 152)]
        [TestCase(Nature.Gentle,    207, 152, 136, 152, 167, 152)]
        [TestCase(Nature.Careful,   207, 152, 152, 136, 167, 152)]
        [TestCase(Nature.Sassy,     207, 152, 152, 152, 167, 136)]
        [TestCase(Nature.Timid,     207, 136, 152, 152, 152, 167)]
        [TestCase(Nature.Hasty,     207, 152, 136, 152, 152, 167)]
        [TestCase(Nature.Jolly,     207, 152, 152, 136, 152, 167)]
        [TestCase(Nature.Naive,     207, 152, 152, 152, 136, 167)]
        public void ê´äiï‚ê≥(Nature nature, int hp, int at, int df, int sa, int sd, int dx)
        {
            var actual = new Dummy(hp, at, df, sa, sd, dx);
            var expect = Expect(nature.ToStatsBuilder());
           
            Assert.That(actual, Is.EqualTo(expect));
        }

        Dummy Expect(IStatsBuilder builder)
        {
            var lv = new Level(50);
            var sp = new Species(100);
            var bp = new BasePoints(252);
            var ip = Individuals.Max;

            var h = builder.HP.Calculate(lv, sp, ip, bp).Value;
            var a = builder.Attack.Calculate(lv, sp, ip, bp).Value;
            var b = builder.Defence.Calculate(lv, sp, ip, bp).Value;
            var c = builder.SpAttack.Calculate(lv, sp, ip, bp).Value;
            var d = builder.SpDefence.Calculate(lv, sp, ip, bp).Value;
            var s = builder.Speed.Calculate(lv, sp, ip, bp).Value;
            return new Dummy(h, a, b, c, d, s);
        }

        class Dummy
        {
            int hp;
            int at;
            int df;
            int sa;
            int sd;
            int dx;

            public Dummy(int hp, int at, int df, int sa, int sd, int dx)
            {
                this.hp = hp;
                this.at = at;
                this.df = df;
                this.sa = sa;
                this.sd = sd;
                this.dx = dx;
            }

            public override bool Equals(object obj)
            {
                if (!(obj is Dummy)) return false;
                return GetHashCode() == obj.GetHashCode();
            }

            public override int GetHashCode()
            {
                return new { hp, at, df, sa, sd, dx }.GetHashCode();
            }

            public override string ToString()
            {
                return string.Format("HP:{0} AT:{1} DF:{2} SA:{3} SD:{4} DX:{5}", hp, at, df, sa, sd, dx);
            }

        }
    }
}
