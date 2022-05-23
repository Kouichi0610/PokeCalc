using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using PokeCalc.Domain.DamageCalculator;
using PokeCalc.Domain.Types;
using PokeCalc.Domain.TypeCorrector;

namespace PokeCalc.Test.Domain.TypeCorrector
{
    public class TypesTest
    {
        IEffectiveLoader normal = new Normal();
        IEffectiveLoader fire = new Fire();
        IEffectiveLoader water = new Water();
        IEffectiveLoader electric = new Electric();
        IEffectiveLoader grass = new Grass();
        IEffectiveLoader ice = new Ice();
        IEffectiveLoader fighting = new Fighting();
        IEffectiveLoader poison = new Poison();
        IEffectiveLoader ground = new Ground();
        IEffectiveLoader flying = new Flying();
        IEffectiveLoader psychic = new Psychic();
        IEffectiveLoader bug = new Bug();
        IEffectiveLoader rock = new Rock();
        IEffectiveLoader ghost = new Ghost();
        IEffectiveLoader dragon = new Dragon();
        IEffectiveLoader dark = new Dark();
        IEffectiveLoader steel = new Steel();
        IEffectiveLoader fairy = new Fairy();

        Effective flat = Effective.Flat;
        Effective super = Effective.Super;
        Effective notvery = Effective.NotVery;
        Effective no = Effective.NoEffective;

        [Test]
        public void TypeCorrector()
        {
            var c = Corrector.Create(PokeType.Fire, new PokeType[] { PokeType.Grass, PokeType.Steel });

            Assert.That(c.Correct(new Damage(15)), Is.EqualTo(new Damage(60)));
        }

        [Test]
        public void こうかはばつぐんだｘこうかはばつぐんだ()
        {
            var a = Effective.Super;
            var b = Effective.Super;

            var c = a.Append(b) as ITypeCorrector;

            // 4倍になること
            Assert.That(c.Correct(new Damage(2)), Is.EqualTo(new Damage(8)));
        }

        [Test]
        public void ノーマル()
        {
            var effectives = new Dictionary<IEffectiveLoader, Effective>()
            {
                {normal, flat},
                {fire, flat},
                {water, flat},
                {electric, flat},
                {grass, flat},
                {ice, flat},
                {fighting, flat},
                {poison, flat},
                {ground, flat},
                {flying, flat},
                {psychic, flat},
                {bug, flat},
                {rock, notvery},
                {ghost, no},
                {dragon, flat},
                {dark, flat},
                {steel, notvery},
                {fairy, flat},
            };
            IEffectiveLoader offence = new Normal();

            foreach (var e in effectives)
            {
                var defence = e.Key;
                var expect = e.Value;
                Assert.That(offence.Correct(defence), Is.EqualTo(expect), defence.GetType().Name);
            }
        }

        [Test]
        public void ほのお()
        {
            var effectives = new Dictionary<IEffectiveLoader, Effective>()
            {
                {normal, flat},
                {fire, notvery},
                {water, notvery},
                {electric, flat},
                {grass, super},
                {ice, super},
                {fighting, flat},
                {poison, flat},
                {ground, flat},
                {flying, flat},
                {psychic, flat},
                {bug, super},
                {rock, notvery},
                {ghost, flat},
                {dragon, notvery},
                {dark, flat},
                {steel, super},
                {fairy, flat},
            };
            IEffectiveLoader offence = new Fire();

            foreach (var e in effectives)
            {
                var defence = e.Key;
                var expect = e.Value;
                Assert.That(offence.Correct(defence), Is.EqualTo(expect), defence.GetType().Name);
            }
        }

        [Test]
        public void みず()
        {
            var effectives = new Dictionary<IEffectiveLoader, Effective>()
            {
                {normal, flat},
                {fire, super},
                {water, notvery},
                {electric, flat},
                {grass, notvery},
                {ice, flat},
                {fighting, flat},
                {poison, flat},
                {ground, super},
                {flying, flat},
                {psychic, flat},
                {bug, flat},
                {rock, super},
                {ghost, flat},
                {dragon, notvery},
                {dark, flat},
                {steel, flat},
                {fairy, flat},
            };
            IEffectiveLoader offence = new Water();

            foreach (var e in effectives)
            {
                var defence = e.Key;
                var expect = e.Value;
                Assert.That(offence.Correct(defence), Is.EqualTo(expect), defence.GetType().Name);
            }
        }
        [Test]
        public void でんき()
        {
            var effectives = new Dictionary<IEffectiveLoader, Effective>()
            {
                {normal, flat},
                {fire, flat},
                {water, super},
                {electric, notvery},
                {grass, notvery},
                {ice, flat},
                {fighting, flat},
                {poison, flat},
                {ground, no},
                {flying, super},
                {psychic, flat},
                {bug, flat},
                {rock, flat},
                {ghost, flat},
                {dragon, notvery},
                {dark, flat},
                {steel, flat},
                {fairy, flat},
            };
            IEffectiveLoader offence = new Electric();

            foreach (var e in effectives)
            {
                var defence = e.Key;
                var expect = e.Value;
                Assert.That(offence.Correct(defence), Is.EqualTo(expect), defence.GetType().Name);
            }
        }
        [Test]
        public void くさ()
        {
            var effectives = new Dictionary<IEffectiveLoader, Effective>()
            {
                {normal, flat},
                {fire, notvery},
                {water, super},
                {electric, flat},
                {grass, notvery},
                {ice, flat},
                {fighting, flat},
                {poison, notvery},
                {ground, super},
                {flying, notvery},
                {psychic, flat},
                {bug, notvery},
                {rock, super},
                {ghost, flat},
                {dragon, notvery},
                {dark, flat},
                {steel, notvery},
                {fairy, flat},
            };
            IEffectiveLoader offence = new Grass();

            foreach (var e in effectives)
            {
                var defence = e.Key;
                var expect = e.Value;
                Assert.That(offence.Correct(defence), Is.EqualTo(expect), defence.GetType().Name);
            }
        }
        [Test]
        public void こおり()
        {
            var effectives = new Dictionary<IEffectiveLoader, Effective>()
            {
                {normal, flat},
                {fire, notvery},
                {water, notvery},
                {electric, flat},
                {grass, super},
                {ice, notvery},
                {fighting, flat},
                {poison, flat},
                {ground, super},
                {flying, super},
                {psychic, flat},
                {bug, flat},
                {rock, flat},
                {ghost, flat},
                {dragon, super},
                {dark, flat},
                {steel, notvery},
                {fairy, flat},
            };
            IEffectiveLoader offence = new Ice();

            foreach (var e in effectives)
            {
                var defence = e.Key;
                var expect = e.Value;
                Assert.That(offence.Correct(defence), Is.EqualTo(expect), defence.GetType().Name);
            }
        }
        [Test]
        public void かくとう()
        {
            var effectives = new Dictionary<IEffectiveLoader, Effective>()
            {
                {normal, super},
                {fire, flat},
                {water, flat},
                {electric, flat},
                {grass, flat},
                {ice, super},
                {fighting, flat},
                {poison, notvery},
                {ground, flat},
                {flying, notvery},
                {psychic, notvery},
                {bug, notvery},
                {rock, super},
                {ghost, no},
                {dragon, flat},
                {dark, super},
                {steel, super},
                {fairy, notvery},
            };
            IEffectiveLoader offence = new Fighting();

            foreach (var e in effectives)
            {
                var defence = e.Key;
                var expect = e.Value;
                Assert.That(offence.Correct(defence), Is.EqualTo(expect), defence.GetType().Name);
            }
        }
        [Test]
        public void どく()
        {
            var effectives = new Dictionary<IEffectiveLoader, Effective>()
            {
                {normal, flat},
                {fire, flat},
                {water, flat},
                {electric, flat},
                {grass, super},
                {ice, flat},
                {fighting, flat},
                {poison, notvery},
                {ground, notvery},
                {flying, flat},
                {psychic, flat},
                {bug, flat},
                {rock, notvery},
                {ghost, notvery},
                {dragon, flat},
                {dark, flat},
                {steel, no},
                {fairy, super},
            };
            IEffectiveLoader offence = new Poison();

            foreach (var e in effectives)
            {
                var defence = e.Key;
                var expect = e.Value;
                Assert.That(offence.Correct(defence), Is.EqualTo(expect), defence.GetType().Name);
            }
        }
        [Test]
        public void じめん()
        {
            var effectives = new Dictionary<IEffectiveLoader, Effective>()
            {
                {normal, flat},
                {fire, super},
                {water, flat},
                {electric, super},
                {grass, notvery},
                {ice, flat},
                {fighting, flat},
                {poison, super},
                {ground, flat},
                {flying, no},
                {psychic, flat},
                {bug, notvery},
                {rock, super},
                {ghost, flat},
                {dragon, flat},
                {dark, flat},
                {steel, super},
                {fairy, flat},
            };
            IEffectiveLoader offence = new Ground();

            foreach (var e in effectives)
            {
                var defence = e.Key;
                var expect = e.Value;
                Assert.That(offence.Correct(defence), Is.EqualTo(expect), defence.GetType().Name);
            }
        }
        [Test]
        public void ひこう()
        {
            var effectives = new Dictionary<IEffectiveLoader, Effective>()
            {
                {normal, flat},
                {fire, flat},
                {water, flat},
                {electric, notvery},
                {grass, super},
                {ice, flat},
                {fighting, super},
                {poison, flat},
                {ground, flat},
                {flying, flat},
                {psychic, flat},
                {bug, super},
                {rock, notvery},
                {ghost, flat},
                {dragon, flat},
                {dark, flat},
                {steel, notvery},
                {fairy, flat},
            };
            IEffectiveLoader offence = new Flying();

            foreach (var e in effectives)
            {
                var defence = e.Key;
                var expect = e.Value;
                Assert.That(offence.Correct(defence), Is.EqualTo(expect), defence.GetType().Name);
            }
        }
        [Test]
        public void エスパー()
        {
            var effectives = new Dictionary<IEffectiveLoader, Effective>()
            {
                {normal, flat},
                {fire, flat},
                {water, flat},
                {electric, flat},
                {grass, flat},
                {ice, flat},
                {fighting, super},
                {poison, super},
                {ground, flat},
                {flying, flat},
                {psychic, notvery},
                {bug, flat},
                {rock, flat},
                {ghost, flat},
                {dragon, flat},
                {dark, no},
                {steel, notvery},
                {fairy, flat},
            };
            IEffectiveLoader offence = new Psychic();

            foreach (var e in effectives)
            {
                var defence = e.Key;
                var expect = e.Value;
                Assert.That(offence.Correct(defence), Is.EqualTo(expect), defence.GetType().Name);
            }
        }
        [Test]
        public void むし()
        {
            var effectives = new Dictionary<IEffectiveLoader, Effective>()
            {
                {normal, flat},
                {fire, notvery},
                {water, flat},
                {electric, flat},
                {grass, super},
                {ice, flat},
                {fighting, notvery},
                {poison, notvery},
                {ground, flat},
                {flying, notvery},
                {psychic, super},
                {bug, flat},
                {rock, flat},
                {ghost, notvery},
                {dragon, flat},
                {dark, super},
                {steel, notvery},
                {fairy, notvery},
            };
            IEffectiveLoader offence = new Bug();

            foreach (var e in effectives)
            {
                var defence = e.Key;
                var expect = e.Value;
                Assert.That(offence.Correct(defence), Is.EqualTo(expect), defence.GetType().Name);
            }
        }
        [Test]
        public void いわ()
        {
            var effectives = new Dictionary<IEffectiveLoader, Effective>()
            {
                {normal, flat},
                {fire, super},
                {water, flat},
                {electric, flat},
                {grass, flat},
                {ice, super},
                {fighting, notvery},
                {poison, flat},
                {ground, notvery},
                {flying, super},
                {psychic, flat},
                {bug, super},
                {rock, flat},
                {ghost, flat},
                {dragon, flat},
                {dark, flat},
                {steel, notvery},
                {fairy, flat},
            };
            IEffectiveLoader offence = new Rock();

            foreach (var e in effectives)
            {
                var defence = e.Key;
                var expect = e.Value;
                Assert.That(offence.Correct(defence), Is.EqualTo(expect), defence.GetType().Name);
            }
        }
        [Test]
        public void ゴースト()
        {
            var effectives = new Dictionary<IEffectiveLoader, Effective>()
            {
                {normal, no},
                {fire, flat},
                {water, flat},
                {electric, flat},
                {grass, flat},
                {ice, flat},
                {fighting, flat},
                {poison, flat},
                {ground, flat},
                {flying, flat},
                {psychic, super},
                {bug, flat},
                {rock, flat},
                {ghost, super},
                {dragon, flat},
                {dark, notvery},
                {steel, flat},
                {fairy, flat},
            };
            IEffectiveLoader offence = new Ghost();

            foreach (var e in effectives)
            {
                var defence = e.Key;
                var expect = e.Value;
                Assert.That(offence.Correct(defence), Is.EqualTo(expect), defence.GetType().Name);
            }
        }
        [Test]
        public void ドラゴン()
        {
            var effectives = new Dictionary<IEffectiveLoader, Effective>()
            {
                {normal, flat},
                {fire, flat},
                {water, flat},
                {electric, flat},
                {grass, flat},
                {ice, flat},
                {fighting, flat},
                {poison, flat},
                {ground, flat},
                {flying, flat},
                {psychic, flat},
                {bug, flat},
                {rock, flat},
                {ghost, flat},
                {dragon, super},
                {dark, flat},
                {steel, notvery},
                {fairy, no},
            };
            IEffectiveLoader offence = new Dragon();

            foreach (var e in effectives)
            {
                var defence = e.Key;
                var expect = e.Value;
                Assert.That(offence.Correct(defence), Is.EqualTo(expect), defence.GetType().Name);
            }
        }
        [Test]
        public void あく()
        {
            var effectives = new Dictionary<IEffectiveLoader, Effective>()
            {
                {normal, flat},
                {fire, flat},
                {water, flat},
                {electric, flat},
                {grass, flat},
                {ice, flat},
                {fighting, notvery},
                {poison, flat},
                {ground, flat},
                {flying, flat},
                {psychic, super},
                {bug, flat},
                {rock, flat},
                {ghost, super},
                {dragon, flat},
                {dark, notvery},
                {steel, flat},
                {fairy, notvery},
            };
            IEffectiveLoader offence = new Dark();

            foreach (var e in effectives)
            {
                var defence = e.Key;
                var expect = e.Value;
                Assert.That(offence.Correct(defence), Is.EqualTo(expect), defence.GetType().Name);
            }
        }
        [Test]
        public void はがね()
        {
            var effectives = new Dictionary<IEffectiveLoader, Effective>()
            {
                {normal, flat},
                {fire, notvery},
                {water, notvery},
                {electric, notvery},
                {grass, flat},
                {ice, super},
                {fighting, flat},
                {poison, flat},
                {ground, flat},
                {flying, flat},
                {psychic, flat},
                {bug, flat},
                {rock, super},
                {ghost, flat},
                {dragon, flat},
                {dark, flat},
                {steel, notvery},
                {fairy, super},
            };
            IEffectiveLoader offence = new Steel();

            foreach (var e in effectives)
            {
                var defence = e.Key;
                var expect = e.Value;
                Assert.That(offence.Correct(defence), Is.EqualTo(expect), defence.GetType().Name);
            }
        }
        [Test]
        public void フェアリー()
        {
            var effectives = new Dictionary<IEffectiveLoader, Effective>()
            {
                {normal, flat},
                {fire, notvery},
                {water, flat},
                {electric, flat},
                {grass, flat},
                {ice, flat},
                {fighting, super},
                {poison, notvery},
                {ground, flat},
                {flying, flat},
                {psychic, flat},
                {bug, flat},
                {rock, flat},
                {ghost, flat},
                {dragon, super},
                {dark, super},
                {steel, notvery},
                {fairy, flat},
            };
            IEffectiveLoader offence = new Fairy();

            foreach (var e in effectives)
            {
                var defence = e.Key;
                var expect = e.Value;
                Assert.That(offence.Correct(defence), Is.EqualTo(expect), defence.GetType().Name);
            }
        }
    }
}
