using System.Collections.Generic;

namespace PokeCalc.Domain.Types
{
	/// <summary>
	/// �^�C�v�B�����̖��������B
	/// ->�^�C�v����(�ق̂�->���� �������͂΂���)
	/// ->�^�C�v��v�␳(�킴�ƃ|�P�����̃^�C�v����v�Ȃ�1.5�{)
	/// ->��Ԉُ�(�ق̂��^�C�v�͂₯�ǂɂȂ�Ȃ�)
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
			{PokeType.Normal, "�m�[�}��"},
			{PokeType.Fire, "�ق̂�"},
			{PokeType.Water, "�݂�"},
			{PokeType.Electric, "�ł�"},
			{PokeType.Grass, "����"},
			{PokeType.Ice, "������"},
			{PokeType.Fighting, "�����Ƃ�"},
			{PokeType.Poison, "�ǂ�"},
			{PokeType.Ground, "���߂�"},
			{PokeType.Flying, "�Ђ���"},
			{PokeType.Psychic, "�G�X�p�["},
			{PokeType.Bug, "�ނ�"},
			{PokeType.Rock, "����"},
			{PokeType.Ghost, "�S�[�X�g"},
			{PokeType.Dragon, "�h���S��"},
			{PokeType.Dark, "����"},
			{PokeType.Steel, "�͂���"},
			{PokeType.Fairy, "�t�F�A���["},
		};
		public static string Name(this PokeType type)
        {
			return names[type];
        }
    }
}
