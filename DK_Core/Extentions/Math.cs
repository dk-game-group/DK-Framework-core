using UnityEngine;
using System.Collections;

namespace DK.Tools
{
    public static class Math
    {
        public static float WrapAngle(float angle)
        {
            angle %= 360;

            if (angle > 180)
                angle -= 360;

            return angle;
        }



    }
}
