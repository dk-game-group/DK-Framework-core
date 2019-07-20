using System.Runtime.CompilerServices;

using UnityEngine;

using DG;
using DG.Tweening;

namespace DK.Tweening
{
    public static partial class SequenceMaster
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MaterialColor(float time, Color color, int materialNum = 0)
        {
            sequence.Append(
              tween = target.GetComponent<MeshRenderer>().materials[materialNum].DOColor(color, time)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MaterialFade(float time, string property, Color color, int materialNum = 0)
        {
            sequence.Append(
              tween = target.GetComponent<MeshRenderer>().materials[materialNum].DOColor(color, property, time)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MaterialFade(float time, float value, int materialNum = 0)
        {
            sequence.Append(
              tween = target.GetComponent<MeshRenderer>().materials[materialNum].DOFade(value, time)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MaterialFade(float time, string property, float value, int materialNum = 0)
        {
            sequence.Append(
              tween = target.GetComponent<MeshRenderer>().materials[materialNum].DOFade(value, property, time)
            );
        }
    }
}
