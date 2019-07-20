using System.Runtime.CompilerServices;

using UnityEngine;

using DG;
using DG.Tweening;

namespace DK.Tweening
{
    public static partial class SequenceMaster
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void LineColor(float time, Color color)
        {
            UnityEngine.LineRenderer lr = target.GetComponent<UnityEngine.LineRenderer>();
            sequence.Append(
              tween = lr.DOColor(new Color2(lr.startColor, lr.endColor), new Color2(color, color), time)
            );
        }
    }
}
