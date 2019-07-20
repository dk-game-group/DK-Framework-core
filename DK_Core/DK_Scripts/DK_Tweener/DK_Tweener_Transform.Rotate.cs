using UnityEngine;
using System.Collections;

using DK.Tweening;

namespace DK
{
    public abstract partial class DKTweener : DKComponent
    {
        public virtual void Rotate(float time, float x, float y, float z, params ITweenParam[] par)
        {
            Sequence().Rotate(time, x, y, z, par);
        }

        public virtual void RotateBy(float time, float x, float y, float z, params ITweenParam[] par)
        {
            Sequence().RotateBy(time, x, y, z, par);
        }
    }
}
