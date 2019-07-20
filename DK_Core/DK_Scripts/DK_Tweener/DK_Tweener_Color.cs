using UnityEngine;
using System.Collections;

using DK.Tweening;

namespace DK
{
    public abstract partial class DKTweener : DKComponent
    {
        internal delegate void colorCall(float time, Color color);
        internal delegate void fadeCall(float time, float alpha);

        internal colorCall colorMod;
        internal fadeCall fadeMod;

        public virtual void Fade(float time, float fade, params ITweenParam[] par)
        {
            Sequence().Fade(time, fade, par);
        }

        public virtual void Color(float time, float r, float g, float b, params ITweenParam[] par)
        {
            Sequence().Color(time, new Color(r, g, b), par);
        }

        public virtual void Color(float time, Color color, params ITweenParam[] par)
        {
            Sequence().Color(time, color, par);
        }
    }
}

