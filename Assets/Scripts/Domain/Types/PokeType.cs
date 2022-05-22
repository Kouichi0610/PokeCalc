using System.Collections.Generic;

namespace PokeCalc.Domain.Types
{
	/// <summary>
	/// タイプ。複数の役割を持つ。
	/// ->タイプ相性(ほのお->くさ こうかはばつぐん)
	/// ->タイプ一致補正(わざとポケモンのタイプが一致なら1.5倍)
	/// ->状態異常(ほのおタイプはやけどにならない)
	/// </summary>
	public enum PokeType
	{
		Normal,
		Fire,
		Water,
		Electric,
		Grass,
		Ice,
		Fighting,
		Poison,
		Ground,
		Flying,
		Psychic,
		Bug,
		Rock,
		Ghost,
		Dragon,
		Dark,
		Steel,
		Fairy,
	}

	public static class PokeTypeExtensions
    {
		private static readonly Dictionary<PokeType, string> names = new Dictionary<PokeType, string>()
		{
			{PokeType.Normal, "ノーマル"},
			{PokeType.Fire, "ほのお"},
			{PokeType.Water, "みず"},
			{PokeType.Electric, "でんき"},
			{PokeType.Grass, "くさ"},
			{PokeType.Ice, "こおり"},
			{PokeType.Fighting, "かくとう"},
			{PokeType.Poison, "どく"},
			{PokeType.Ground, "じめん"},
			{PokeType.Flying, "ひこう"},
			{PokeType.Psychic, "エスパー"},
			{PokeType.Bug, "むし"},
			{PokeType.Rock, "いわ"},
			{PokeType.Ghost, "ゴースト"},
			{PokeType.Dragon, "ドラゴン"},
			{PokeType.Dark, "あく"},
			{PokeType.Steel, "はがね"},
			{PokeType.Fairy, "フェアリー"},
		};
		public static string Name(this PokeType type)
        {
			return names[type];
        }
    }
}
