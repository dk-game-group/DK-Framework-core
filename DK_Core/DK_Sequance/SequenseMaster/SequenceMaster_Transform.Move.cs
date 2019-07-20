using System.Runtime.CompilerServices;

using UnityEngine;
using UnityEngine.UI;

using DG;
using DG.Tweening;

namespace DK.Tweening
{
    public static partial class SequenceMaster
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveTo(float time, Vector3 point)
        {
            sequence.Append(
              tween = target.transform.DOMove(point, time)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveToX(float time, float targetX)
        {
            sequence.Append(
              tween = target.transform.DOMoveX(targetX, time)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveToY(float time, float targetY)
        {
            sequence.Append(
              tween = target.transform.DOMoveY(targetY, time)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveToZ(float time, float targetZ)
        {
            sequence.Append(
              tween = target.transform.DOMoveZ(targetZ, time)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveBy(float time, Vector3 direction)
        {
            sequence.Append(
              tween = target.transform.DOBlendableMoveBy(direction, time)
            );
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveUITo(float time, Vector3 point)
        {
            sequence.Append(
              tween = target.GetComponent<RectTransform>().DOAnchorPos3D(point, time)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveUIToX(float time, float targetX)
        {
            sequence.Append(
              tween = target.GetComponent<RectTransform>().DOAnchorPos3DX(targetX, time)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveUIToY(float time, float targetY)
        {
            sequence.Append(
              tween = target.GetComponent<RectTransform>().DOAnchorPos3DY(targetY, time)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveUIToZ(float time, float targetZ)
        {
            sequence.Append(
              tween = target.GetComponent<RectTransform>().DOAnchorPos3DZ(targetZ, time)
            );
        }
    }
}
