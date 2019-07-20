using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;

namespace DK.Tools
{
    public static class Mathf
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float WrapAngle(float angle)
        {
            angle %= 360;

            if (angle > 180)
                angle -= 360;

            return angle;
        }
    }
}
