using UnityEngine;

using DG;
using DG.Tweening;

namespace DK.Tweening
{
    public static partial class SequenceMaster
    {
        public static void ImageColor(float time, Color color)
        {
            sequence.Append(
              tween = target.GetComponent<UnityEngine.UI.Image>().DOColor(color, time)
            );
        }

        public static void ImageFade(float time, float value)
        {
            sequence.Append(
              tween = target.GetComponent<UnityEngine.UI.Image>().DOFade(value, time)
            );
        }

        public static void ImageFill(float time, float value)
        {
            sequence.Append(
              tween = target.GetComponent<UnityEngine.UI.Image>().DOFillAmount(value, time)
            );
        }
    }
}
