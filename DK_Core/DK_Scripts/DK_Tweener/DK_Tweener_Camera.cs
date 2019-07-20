using UnityEngine;
using System.Collections;

using DK.Tweening;

namespace DK
{
    public abstract partial class DKTweener : DKComponent
    {
        public virtual void Field(float time, float value, params ITweenParam[] par)
        {
            Sequence().Field(time, value, par);
        }
    }
}
