using UnityEngine;

using DG.Tweening;

namespace DK.Tweening
{
    public static partial class SequenceMaster
    {
        public static void Rotate(float time, Vector3 eulerAngle)
        {
            sequence.Append(
              tween = target.transform.DORotate(eulerAngle, time)
            );
        }
        public static void Rotate(float time, Quaternion rotaion)
        {
            sequence.Append(
              tween = target.transform.DORotateQuaternion(rotaion, time)
            );
        }

        public static void RotateBy(float time, Vector3 direction)
        {
            sequence.Append(
              tween = target.transform.DOBlendableRotateBy(direction, time)
            );
        }
    }
}
