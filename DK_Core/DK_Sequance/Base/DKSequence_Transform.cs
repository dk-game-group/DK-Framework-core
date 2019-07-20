using System.Runtime.CompilerServices;

using UnityEngine;

namespace DK.Tweening
{
    public partial class DKSequence
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Move(float time, float x, float y, float z, params ITweenParam[] par)
        {
            SequenceMaster.Move(time, new Vector3(x, y, z));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Move(float time, Vector3 point, params ITweenParam[] par)
        {
            SequenceMaster.Move(time, point);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence MoveToX(float time, float targetX, params ITweenParam[] par)
        {
            SequenceMaster.MoveToX(time, targetX);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence MoveToY(float time, float targetY, params ITweenParam[] par)
        {
            SequenceMaster.MoveToY(time, targetY);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence MoveToZ(float time, float targetZ, params ITweenParam[] par)
        {
            SequenceMaster.MoveToZ(time, targetZ);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence MoveBy(float time, float x, float y, float z, params ITweenParam[] par)
        {
            SequenceMaster.MoveBy(time, new Vector3(x, y, z));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence MoveBy(float time, Vector3 direction, params ITweenParam[] par)
        {
            SequenceMaster.MoveBy(time, direction);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence MoveByX(float time, float shiftX, params ITweenParam[] par)
        {
            SequenceMaster.MoveBy(time, new Vector3(shiftX, 0, 0));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence MoveByY(float time, float shiftY, params ITweenParam[] par)
        {
            SequenceMaster.MoveBy(time, new Vector3(0, shiftY, 0));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence MoveByZ(float time, float shiftZ, params ITweenParam[] par)
        {
            SequenceMaster.MoveBy(time, new Vector3(0, 0, shiftZ));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Rotate(float time, float x, float y, float z, params ITweenParam[] par)
        {
            SequenceMaster.Rotate(time, new Vector3(x, y, z));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Rotate(float time, Vector3 eulerAngle, params ITweenParam[] par)
        {
            SequenceMaster.Rotate(time, eulerAngle);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Rotate(float time, Quaternion rotaion, params ITweenParam[] par)
        {
            SequenceMaster.Rotate(time, rotaion);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence RotateBy(float time, float x, float y, float z, params ITweenParam[] par)
        {
            SequenceMaster.RotateBy(time, new Vector3(x, y, z));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence RotateBy(float time, Vector3 direction, params ITweenParam[] par)
        {
            SequenceMaster.RotateBy(time, direction);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence RotateByX(float time, float rotX, params ITweenParam[] par)
        {
            SequenceMaster.RotateBy(time, new Vector3(rotX, 0, 0));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence RotateByY(float time, float rotY, params ITweenParam[] par)
        {
            SequenceMaster.RotateBy(time, new Vector3(0, rotY, 0));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence RotateByZ(float time, float rotZ, params ITweenParam[] par)
        {
            SequenceMaster.RotateBy(time, new Vector3(0, 0, rotZ));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Scale(float time, float x, float y, float z, params ITweenParam[] par)
        {
            SequenceMaster.Scale(time, new Vector3(x, y, z));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Scale(float time, float scale, params ITweenParam[] par)
        {
            SequenceMaster.Scale(time, new Vector3(scale, scale, scale));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Scale(float time, Vector3 scale, params ITweenParam[] par)
        {
            SequenceMaster.Scale(time, scale);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence ScaleBy(float time, float x, float y, float z, params ITweenParam[] par)
        {
            SequenceMaster.ScaleBy(time, new Vector3(x, y, z));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence ScaleBy(float time, Vector3 scale, params ITweenParam[] par)
        {
            SequenceMaster.ScaleBy(time, scale);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence ScaleByX(float time, float scaleX, params ITweenParam[] par)
        {
            SequenceMaster.ScaleBy(time, new Vector3(scaleX, 0, 0));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence ScaleByY(float time, float scaleY, params ITweenParam[] par)
        {
            SequenceMaster.ScaleBy(time, new Vector3(0, scaleY, 0));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence ScaleByZ(float time, float scaleZ, params ITweenParam[] par)
        {
            SequenceMaster.ScaleBy(time, new Vector3(0, 0, scaleZ));
            SequenceMaster.ApplyParams(par);
            return this;
        }
    }
}
