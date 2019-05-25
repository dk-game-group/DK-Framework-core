using UnityEngine;
using System.Collections;

using DK.Tweening;

namespace DK
{
    public abstract partial class DKTweener : DKComponent
    {
        public virtual void RBMove(float time, Vector3 to, params TweenParams[] par)
        {
            Sequence().RBMove(time, to, par);
        }

        public virtual void RBMove(float time, float x, float y, float z, params TweenParams[] par)
        {
            Sequence().RBMove(time, new Vector3(x, y, z), par);
        }

        public virtual void RBMoveX(float time, float to, params TweenParams[] par)
        {
            Sequence().RBMoveX(time, to, par);
        }

        public virtual void RBMoveY(float time, float to, params TweenParams[] par)
        {
            Sequence().RBMoveY(time, to, par);
        }

        public virtual void RBMoveZ(float time, float to, params TweenParams[] par)
        {
            Sequence().RBMoveZ(time, to, par);
        }

        public virtual void RBRotate(float time, Vector3 angle, params TweenParams[] par)
        {
            Sequence().RBRotate(time, angle, par);
        }

        public virtual void RBRotate(float time, float x, float y, float z, params TweenParams[] par)
        {
            Sequence().RBRotate(time, new Vector3(x, y, z), par);
        }
    }
}
