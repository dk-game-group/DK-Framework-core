using UnityEngine;
using System.Collections;

using DK.Tweening;

using DG.Tweening;
using DG.Tweening.Core;

namespace DK
{
    public abstract partial class DKTweener : DKComponent
    {
        public virtual void Value(float time, float start, float finish, DOSetter<float> action, params DK.Tweening.TweenParams[] par)
        {
            Sequence().Value(time, start, finish, action, par);
        }

        public virtual void Delay(float time, TweenCallback callback)
        {
            Sequence().Delay(time).Do(callback);
        }
    }
}
