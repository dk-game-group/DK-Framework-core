using System.Runtime.CompilerServices;

using UnityEngine;

using DG;
using DG.Tweening;

namespace DK.Tweening
{
    public static partial class SequenceMaster
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MeshColor(float time, Color color)
        {
            int materialCount = target.GetComponent<MeshRenderer>().materials.Length;
            for (int i = 0; i < materialCount; i++)
            {
                MaterialColor(time, color, i);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MeshFade(float time, float value)
        {
            int materialCount = target.GetComponent<MeshRenderer>().materials.Length;
            for (int i = 0; i < materialCount; i++)
            {
                MaterialFade(time, value, i);
            }
        }
    }
}
