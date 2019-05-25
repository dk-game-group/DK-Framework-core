using UnityEngine;

using DG;
using DG.Tweening;

namespace DK.Tweening
{
    public static partial class SequenceMaster
    {
        public static void TextColor(float time, Color color)
        {
            sequence.Append(
              tween = target.GetComponent<UnityEngine.UI.Text>().DOColor(color, time)
            );
        }

        public static void TextFade(float time, float value)
        {
            sequence.Append(
              tween = target.GetComponent<UnityEngine.UI.Text>().DOFade(value, time)
            );
        }
    }
}
