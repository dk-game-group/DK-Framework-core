using UnityEngine;

using DG;
using DG.Tweening;

namespace DK.Tweening
{
    public static partial class SequenceMaster
    {
        public static void CanvasFade(float time, float value)
        {
            sequence.Append(
              tween = target.GetComponent<UnityEngine.CanvasGroup>().DOFade(value, time)
            );
        }
    }
}
