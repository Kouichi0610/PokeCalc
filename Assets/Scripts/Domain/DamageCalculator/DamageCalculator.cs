using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PokeCalc.Domain.DamageCalculator
{
    /// <summary>
    /// https://latest.pokewiki.net/%E3%83%80%E3%83%A1%E3%83%BC%E3%82%B8%E8%A8%88%E7%AE%97%E5%BC%8F
    /// 
    /// (攻撃側のレベル*2 / 5 + 2)小数点以下切り捨て
    /// * (技の威力 * 攻撃側ステータス / 防御側のステータス)小数点以下切り捨て
    /// / 50 + 2
    /// *乱数(0.85 ～ 1.00まで0.01刻み)小数点以下切り捨て
    /// 
    /// ちきゅうなげ->攻撃側のレベル(ゴーストには無効)
    /// </summary>
    public class DamageCalculator
    {

    }
}
