using System.Runtime.CompilerServices;

using UnityEngine;

using DG;
using DG.Tweening;

namespace DK.Tweening
{
    public static partial class SequenceMaster
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Volume(float time, float value)
        {
            sequence.Append(
              tween = target.GetComponent<UnityEngine.AudioSource>().DOFade(value, time)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Pitch(float time, float value)
        {
            sequence.Append(
              tween = target.GetComponent<UnityEngine.AudioSource>().DOPitch(value, time)
            );
        }
    }
}
