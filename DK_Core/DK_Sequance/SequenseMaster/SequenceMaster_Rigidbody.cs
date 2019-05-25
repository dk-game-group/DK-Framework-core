using UnityEngine;

using DG;
using DG.Tweening;

namespace DK.Tweening
{
    public static partial class SequenceMaster
    {
        public static void RBMoveTo(float time, Vector3 point)
        {
            sequence.Append(
              tween = target.GetComponent<Rigidbody>().DOMove(point, time)
            );
        }

        public static void RBMoveToX(float time, float targetX)
        {
            sequence.Append(
              tween = target.GetComponent<Rigidbody>().DOMoveX(targetX, time)
            );
        }

        public static void RBMoveToY(float time, float targetY)
        {
            sequence.Append(
              tween = target.GetComponent<Rigidbody>().DOMoveY(targetY, time)
            );
        }

        public static void RBMoveToZ(float time, float targetZ)
        {
            sequence.Append(
              tween = target.GetComponent<Rigidbody>().DOMoveZ(targetZ, time)
            );
        }

        public static void RBRotate(float time, Vector3 angle)
        {
            sequence.Append(
              tween = target.GetComponent<Rigidbody>().DORotate(angle, time)
            );
        }
    }
}
