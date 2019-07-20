using System.Runtime.CompilerServices;

using UnityEngine;

using DG.Tweening;

namespace DK.Tweening
{
    public static partial class SequenceMaster
    {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Field(float time, float value)
        {
            sequence.Append(tween = target.GetComponent<UnityEngine.Camera>().DOFieldOfView(value, time));
            return;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CameraColor(float time, Color color)
        {
            sequence.Append(tween = target.GetComponent<UnityEngine.Camera>().DOColor(color, time));
            return;
        }
    }
}
