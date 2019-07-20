using System.Runtime.CompilerServices;

using UnityEngine;

namespace DK.Tweening
{
    public partial class DKSequence
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence RBMove(float time, Vector3 point, params ITweenParam[] par)
        {
            SequenceMaster.RBMoveTo(time, point);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence RBMove(float time, float x, float y, float z, params ITweenParam[] par)
        {
            SequenceMaster.RBMoveTo(time, new Vector3(x, y, z));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence RBMoveX(float time, float x, params ITweenParam[] par)
        {
            SequenceMaster.RBMoveTo(time, new Vector3(x, 0, 0));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence RBMoveY(float time, float y, params ITweenParam[] par)
        {
            SequenceMaster.RBMoveTo(time, new Vector3(0, y, 0));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence RBMoveZ(float time, float z, params ITweenParam[] par)
        {
            SequenceMaster.RBMoveTo(time, new Vector3(0, 0, z));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence RBRotate(float time, Vector3 angle, params ITweenParam[] par)
        {
            SequenceMaster.RBRotate(time, angle);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence RBRotate(float time, float x, float y, float z, params ITweenParam[] par)
        {
            SequenceMaster.RBRotate(time, new Vector3(x, y, z));
            SequenceMaster.ApplyParams(par);
            return this;
        }
    }
}
