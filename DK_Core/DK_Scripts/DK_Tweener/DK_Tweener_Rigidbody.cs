using UnityEngine;
using System.Collections;

using DK.Tweening;

namespace DK
{
    public abstract partial class DKTweener : DKComponent
    {
        public virtual void RBMove(float time, Vector3 to, params ITweenParam[] par)
        {
            Sequence().RBMove(time, to, par);
        }

        public virtual void RBMove(float time, float x, float y, float z, params ITweenParam[] par)
        {
            Sequence().RBMove(time, new Vector3(x, y, z), par);
        }

        public virtual void RBMoveX(float time, float to, params ITweenParam[] par)
        {
            Sequence().RBMoveX(time, to, par);
        }

        public virtual void RBMoveY(float time, float to, params ITweenParam[] par)
        {
            Sequence().RBMoveY(time, to, par);
        }

        public virtual void RBMoveZ(float time, float to, params ITweenParam[] par)
        {
            Sequence().RBMoveZ(time, to, par);
        }

        public virtual void RBRotate(float time, Vector3 angle, params ITweenParam[] par)
        {
            Sequence().RBRotate(time, angle, par);
        }

        public virtual void RBRotate(float time, float x, float y, float z, params ITweenParam[] par)
        {
            Sequence().RBRotate(time, new Vector3(x, y, z), par);
        }
    }
}
