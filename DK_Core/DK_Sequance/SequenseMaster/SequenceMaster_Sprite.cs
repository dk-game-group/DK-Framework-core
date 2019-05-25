using UnityEngine;

using DG;
using DG.Tweening;

namespace DK.Tweening
{
    public static partial class SequenceMaster
    {
        public static void SpriteColor(float time, Color color)
        {
            sequence.Append(
              tween = target.GetComponent<UnityEngine.SpriteRenderer>().DOColor(color, time)
            );
        }

        public static void SpriteFade(float time, float value)
        {
            sequence.Append(
              tween = target.GetComponent<UnityEngine.SpriteRenderer>().DOFade(value, time)
            );
        }
    }
}
