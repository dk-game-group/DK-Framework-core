using UnityEngine;

using DG.Tweening;

namespace DK.Tweening
{
    public static partial class SequenceMaster
    {
        public static void ShakePos(float time, Vector3 forse, int vibro, float random)
        {
            sequence.Append(
              tween = target.transform.DOShakePosition(time, forse, vibro, random, false)
            );
        }

        public static void ShakeRot(float time, Vector3 forse, int vibro, float random)
        {
            sequence.Append(
              tween = target.transform.DOShakePosition(time, forse, vibro, random)
            );
        }

        public static void ShakeScl(float time, Vector3 forse, int vibro, float random)
        {
            sequence.Append(
              tween = target.transform.DOShakeScale(time, forse, vibro, random)
            );
        }
    }
}
