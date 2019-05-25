using UnityEngine;

using DG.Tweening;

namespace DK.Tweening
{
    public static partial class SequenceMaster
    {
        public static void Scale(float time, Vector3 scale)
        {
            sequence.Append(
              tween = target.transform.DOScale(scale, time)
            );
        }

        public static void ScaleBy(float time, Vector3 scale)
        {
            sequence.Append(
              tween = target.transform.DOBlendableScaleBy(scale, time)
            );
        }
    }
}
