using System.Runtime.CompilerServices;

using UnityEngine;

using DG;
using DG.Tweening;

namespace DK.Tweening
{
    public static partial class SequenceMaster
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ImageColor(float time, Color color)
        {
            sequence.Append(
              tween = target.GetComponent<UnityEngine.UI.Image>().DOColor(color, time)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ImageFade(float time, float value)
        {
            sequence.Append(
              tween = target.GetComponent<UnityEngine.UI.Image>().DOFade(value, time)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ImageFill(float time, float value)
        {
            sequence.Append(
              tween = target.GetComponent<UnityEngine.UI.Image>().DOFillAmount(value, time)
            );
        }
    }
}
