using System.Runtime.CompilerServices;

using UnityEngine;

using DG;
using DG.Tweening;

namespace DK.Tweening
{
    public static partial class SequenceMaster
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void LightColor(float time, Color color)
        {
            sequence.Append(
              tween = target.GetComponent<UnityEngine.Light>().DOColor(color, time)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void LightIntensity(float time, float value)
        {
            sequence.Append(
              tween = target.GetComponent<UnityEngine.Light>().DOIntensity(value, time)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ShadowStrength(float time, float value)
        {
            sequence.Append(
              tween = target.GetComponent<UnityEngine.Light>().DOShadowStrength(value, time)
            );
        }
    }
}
