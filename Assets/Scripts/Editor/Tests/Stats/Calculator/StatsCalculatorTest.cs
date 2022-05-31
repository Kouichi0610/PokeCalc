using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

using PokeCalc.Domain.DamageCalculator;
using PokeCalc.Domain.Stats;
using PokeCalc.Domain.Stats.Calculator;

namespace PokeCalc.Test.Domain.Stats.Calculator
{
    public class StatsCalculatorTest
    {
        // “ü—Í‚ÉŠÖŒW‚È‚­1ŒÅ’è‚Å‚ ‚é‚±‚Æ
        [Test]
        public void ƒkƒPƒjƒ“([Random(1, 100, 1)] int level, [Random(0, 252, 1)] int basePoint)
        {
            Assert.That(Calc(new ShadinjaHP(), level, 150, 31, basePoint), Is.EqualTo(1));
        }
        [Test]
        [TestCase( 0, 176)]
        [TestCase( 1, 177)]
        [TestCase(31, 192)]
        public void HP(int i, int expect)
        {
            Assert.That(Calc(new HP(), 50, 85, i, 252), Is.EqualTo(expect));
        }
        [Test]
        [TestCase(0, 141)]
        [TestCase(1, 142)]
        [TestCase(30, 156)]
        [TestCase(31, 157)]
        public void Flat(int i, int expect)
        {
            Assert.That(Calc(new Flat(), 50, 105, i, 252), Is.EqualTo(expect));
        }
        [Test]
        [TestCase(0, 155)]
        [TestCase(1, 156)]
        [TestCase(30, 171)]
        [TestCase(31, 172)]
        public void Upper(int i, int expect)
        {
            Assert.That(Calc(new Upper(), 50, 105, i, 252), Is.EqualTo(expect));
        }
        [Test]
        [TestCase(0, 126)]
        [TestCase(1, 127)]
        [TestCase(30, 140)]
        [TestCase(31, 141)]
        public void Lower(int i, int expect)
        {
            Assert.That(Calc(new Lower(), 50, 105, i, 252), Is.EqualTo(expect));
        }

        public int Calc(ICalculator c, int l, int s, int i, int b)
        {
            var res = c.Calculate(new Level(l), new Species(s), new Individuals(i), new BasePoints(b));
            return res.Value;
        }
    }
}
