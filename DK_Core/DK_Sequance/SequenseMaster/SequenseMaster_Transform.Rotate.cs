using System.Runtime.CompilerServices;

using UnityEngine;

using DG.Tweening;

namespace DK.Tweening
{
    public static partial class SequenceMaster
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Rotate(float time, Vector3 eulerAngle)
        {
            sequence.Append(
              tween = target.transform.DORotate(eulerAngle, time)
            );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Rotate(float time, Quaternion rotaion)
        {
            sequence.Append(
              tween = target.transform.DORotateQuaternion(rotaion, time)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void RotateBy(float time, Vector3 direction)
        {
            sequence.Append(
              tween = target.transform.DOBlendableRotateBy(direction, time)
            );
        }
    }
}
