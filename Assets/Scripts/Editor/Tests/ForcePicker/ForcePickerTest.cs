using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

using PokeCalc.Domain.DamageCalculator;
using PokeCalc.Domain.ForcePicker;

namespace PokeCalc.Test.Domain.ForcePicker
{
    public class ForcePickerTest
    {
        [Test]
        public void ぶつり()
        {
            var f = F(1, 2, 3, 4, 5, 6,
                      7, 8, 9, 10, 11, 12);
            var p = new Physical(f) as IForcePicker;

            Assert.That(p.Offence, Is.EqualTo(new Offence(2)));
            Assert.That(p.Defence, Is.EqualTo(new Defence(9)));

        }
        [Test]
        public void とくしゅ()
        {
            var f = F(1, 2, 3, 4, 5, 6,
                      7, 8, 9, 10, 11, 12);
            var p = new Special(f) as IForcePicker;

            Assert.That(p.Offence, Is.EqualTo(new Offence(4)));
            Assert.That(p.Defence, Is.EqualTo(new Defence(11)));
        }
        [Test]
        public void ボディプレス()
        {
            var f = F(1, 2, 3, 4, 5, 6,
                      7, 8, 9, 10, 11, 12);
            var p = new BodyPress(f) as IForcePicker;

            Assert.That(p.Offence, Is.EqualTo(new Offence(3)));
            Assert.That(p.Defence, Is.EqualTo(new Defence(9)));
        }
        [Test]
        public void サイコショック()
        {
            var f = F(1, 2, 3, 4, 5, 6,
                      7, 8, 9, 10, 11, 12);
            var p = new PsycoShock(f) as IForcePicker;

            Assert.That(p.Offence, Is.EqualTo(new Offence(4)));
            Assert.That(p.Defence, Is.EqualTo(new Defence(9)));
        }
        [Test]
        public void イカサマ()
        {
            var f = F(1, 2, 3, 4, 5, 6,
                      7, 8, 9, 10, 11, 12);
            var p = new FoulPlay(f) as IForcePicker;

            Assert.That(p.Offence, Is.EqualTo(new Offence(8)));
            Assert.That(p.Defence, Is.EqualTo(new Defence(9)));
        }
        [Test]
        public void シェルアームズ()
        {
            var f = F(999, 150, 777, 200, 666, 888,
                      999, 777, 160, 666, 210, 888);
            var p = new ShellArms(f) as IForcePicker;

            Assert.That(p.Offence, Is.EqualTo(new Offence(200)));
            Assert.That(p.Defence, Is.EqualTo(new Defence(210)));
            
            f = F(999, 302, 777, 132, 666, 888,
                  999, 777, 250, 666, 120, 888);
            p = new ShellArms(f) as IForcePicker;

            Assert.That(p.Offence, Is.EqualTo(new Offence(302)));
            Assert.That(p.Defence, Is.EqualTo(new Defence(250)));
        }

        IForce F(params int[] p)
        {
            return new Force(p);
        }

        class Force : IForce
        {
            public IStats Offence { get; private set; }
            public IStats Defence { get; private set; }

            public Force(params int[] p)
            {
                Offence = new Stats(p[0], p[1], p[2], p[3], p[4], p[5]);
                Defence = new Stats(p[6], p[7], p[8], p[9], p[10], p[11]);
            }
            class Stats : IStats
            {
                public int HP { get; private set; }
                public int Attack { get; private set; }
                public int Defence { get; private set; }
                public int SpAttack { get; private set; }
                public int SpDefence { get; private set; }
                public int Speed { get; private set; }

                public Stats(int a, int b, int c, int d, int e, int f)
                {
                    HP = a;
                    Attack = b;
                    Defence = c;
                    SpAttack = d;
                    SpDefence = e;
                    Speed = f;
                }
            }
        }
    }
}
