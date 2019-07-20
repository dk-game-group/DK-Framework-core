using UnityEngine;

using DG;
using DG.Tweening;
using System.Runtime.CompilerServices;

namespace DK.Tweening
{
    public static partial class SequenceMaster
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SpriteColor(float time, Color color)
        {
            sequence.Append(
              tween = target.GetComponent<UnityEngine.SpriteRenderer>().DOColor(color, time)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SpriteFade(float time, float value)
        {
            sequence.Append(
              tween = target.GetComponent<UnityEngine.SpriteRenderer>().DOFade(value, time)
            );
        }
    }
}
