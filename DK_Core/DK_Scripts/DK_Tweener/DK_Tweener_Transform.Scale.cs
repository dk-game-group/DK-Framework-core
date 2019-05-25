using UnityEngine;
using System.Collections;

using DK.Tweening;

namespace DK
{
    public abstract partial class DKTweener : DKComponent
    {
        public virtual void Scale(float time, float x, float y, float z, params TweenParams[] par)
        {
            Sequence().Scale(time, x, y, z, par);
        }

        public virtual void Scale(float time, float scale, params TweenParams[] par)
        {
            Sequence().Scale(time, scale, scale, scale, par);
        }

        public virtual void ScaleBy(float time, float x, float y, float z, params TweenParams[] par)
        {
            Sequence().ScaleBy(time, x, y, z, par);
        }

        public virtual void ScaleBy(float time, float scale, params TweenParams[] par)
        {
            Sequence().ScaleBy(time, scale, scale, scale, par);
        }
    }
}
