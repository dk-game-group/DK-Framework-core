using UnityEngine;
using System.Collections;

using DK.Tweening;

namespace DK
{
    public abstract partial class DKTweener : DKComponent
    {
        public virtual void Volume(float time, float volume, params ITweenParam[] par)
        {
            Sequence().Volume(time, volume, par);
        }

        public virtual void Pitch(float time, float pitch, params ITweenParam[] par)
        {
            Sequence().Pitch(time, pitch, par);
        }
    }
}
