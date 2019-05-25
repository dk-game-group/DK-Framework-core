using UnityEngine;
using UnityEngine.UI;

using DG;
using DG.Tweening;

namespace DK.Tweening
{
    public static partial class SequenceMaster
    {
        //TODO add 2d ui support

        public static void MoveTo(float time, Vector3 point)
        {
            sequence.Append(
              tween = target.transform.DOMove(point, time)
            );
        }

        public static void MoveToX(float time, float targetX)
        {
            sequence.Append(
              tween = target.transform.DOMoveX(targetX, time)
            );
        }

        public static void MoveToY(float time, float targetY)
        {
            sequence.Append(
              tween = target.transform.DOMoveY(targetY, time)
            );
        }

        public static void MoveToZ(float time, float targetZ)
        {
            sequence.Append(
              tween = target.transform.DOMoveZ(targetZ, time)
            );
        }

        public static void MoveBy(float time, Vector3 direction)
        {
            sequence.Append(
              tween = target.transform.DOBlendableMoveBy(direction, time)
            );
        }


        public static void MoveUITo(float time, Vector3 point)
        {
            sequence.Append(
              tween = target.GetComponent<RectTransform>().DOAnchorPos3D(point, time)
            );
        }

        public static void MoveUIToX(float time, float targetX)
        {
            sequence.Append(
              tween = target.GetComponent<RectTransform>().DOAnchorPos3DX(targetX, time)
            );
        }

        public static void MoveUIToY(float time, float targetY)
        {
            sequence.Append(
              tween = target.GetComponent<RectTransform>().DOAnchorPos3DY(targetY, time)
            );
        }

        public static void MoveUIToZ(float time, float targetZ)
        {
            sequence.Append(
              tween = target.GetComponent<RectTransform>().DOAnchorPos3DZ(targetZ, time)
            );
        }
    }
}
