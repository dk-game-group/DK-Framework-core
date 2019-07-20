using UnityEngine;

using DK.Tweening;

namespace DK
{
    public abstract partial class DKTweener : DKComponent
    {
        public virtual void Move(float time, float x, float y, float z = 0, params ITweenParam[] par)
        {
            Sequence().Move(time, x, y, z, par);
        }

        public virtual void Move(float time, Vector3 point, params ITweenParam[] par)
        {
            Sequence().Move(time, point, par);
        }

        public virtual void MoveBy(float time, float x, float y, float z, params ITweenParam[] par)
        {
            Sequence().MoveBy(time, x, y, z, par);
        }

        public virtual void MoveBy(float time, Vector3 shift, params ITweenParam[] par)
        {
            Sequence().MoveBy(time, shift, par);
        }

        public virtual void MoveByX(float time, float value, params ITweenParam[] par)
        {
            Sequence().MoveByX(time, value, par);
        }

        public virtual void MoveByY(float time, float value, params ITweenParam[] par)
        {
            Sequence().MoveByY(time, value, par);
        }

        public virtual void MoveByZ(float time, float value, params ITweenParam[] par)
        {
            Sequence().MoveByZ(time, value, par);
        }

        public virtual void Shake(float time, float strength, int vibrate, float randomness, params ITweenParam[] par)
        {
            Sequence().ShakePos(time, strength, vibrate, randomness, par);
        }
    }
}
