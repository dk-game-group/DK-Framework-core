using System.Runtime.CompilerServices;

using UnityEngine;

using DG.Tweening;

namespace DK.Tweening
{
    public static partial class SequenceMaster
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ShakePos(float time, Vector3 forse, int vibro, float random)
        {
            sequence.Append(
              tween = target.transform.DOShakePosition(time, forse, vibro, random, false)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ShakeRot(float time, Vector3 forse, int vibro, float random)
        {
            sequence.Append(
              tween = target.transform.DOShakePosition(time, forse, vibro, random)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ShakeScl(float time, Vector3 forse, int vibro, float random)
        {
            sequence.Append(
              tween = target.transform.DOShakeScale(time, forse, vibro, random)
            );
        }
    }
}
