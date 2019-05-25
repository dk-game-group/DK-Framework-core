using UnityEngine;

namespace DK.Tweening
{
    public partial class DKSequence
    {
        public DKSequence Move(float time, float x, float y, float z, params TweenParams[] par)
        {
            SequenceMaster.Move(time, new Vector3(x, y, z));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence Move(float time, Vector3 point, params TweenParams[] par)
        {
            SequenceMaster.Move(time, point);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence MoveToX(float time, float targetX, params TweenParams[] par)
        {
            SequenceMaster.MoveToX(time, targetX);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence MoveToY(float time, float targetY, params TweenParams[] par)
        {
            SequenceMaster.MoveToY(time, targetY);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence MoveToZ(float time, float targetZ, params TweenParams[] par)
        {
            SequenceMaster.MoveToZ(time, targetZ);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence MoveBy(float time, float x, float y, float z, params TweenParams[] par)
        {
            SequenceMaster.MoveBy(time, new Vector3(x, y, z));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence MoveBy(float time, Vector3 direction, params TweenParams[] par)
        {
            SequenceMaster.MoveBy(time, direction);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence MoveByX(float time, float shiftX, params TweenParams[] par)
        {
            SequenceMaster.MoveBy(time, new Vector3(shiftX, 0, 0));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence MoveByY(float time, float shiftY, params TweenParams[] par)
        {
            SequenceMaster.MoveBy(time, new Vector3(0, shiftY, 0));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence MoveByZ(float time, float shiftZ, params TweenParams[] par)
        {
            SequenceMaster.MoveBy(time, new Vector3(0, 0, shiftZ));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence Rotate(float time, float x, float y, float z, params TweenParams[] par)
        {
            SequenceMaster.Rotate(time, new Vector3(x, y, z));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence Rotate(float time, Vector3 eulerAngle, params TweenParams[] par)
        {
            SequenceMaster.Rotate(time, eulerAngle);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence Rotate(float time, Quaternion rotaion, params TweenParams[] par)
        {
            SequenceMaster.Rotate(time, rotaion);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence RotateBy(float time, float x, float y, float z, params TweenParams[] par)
        {
            SequenceMaster.RotateBy(time, new Vector3(x, y, z));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence RotateBy(float time, Vector3 direction, params TweenParams[] par)
        {
            SequenceMaster.RotateBy(time, direction);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence RotateByX(float time, float rotX, params TweenParams[] par)
        {
            SequenceMaster.RotateBy(time, new Vector3(rotX, 0, 0));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence RotateByY(float time, float rotY, params TweenParams[] par)
        {
            SequenceMaster.RotateBy(time, new Vector3(0, rotY, 0));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence RotateByZ(float time, float rotZ, params TweenParams[] par)
        {
            SequenceMaster.RotateBy(time, new Vector3(0, 0, rotZ));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence Scale(float time, float x, float y, float z, params TweenParams[] par)
        {
            SequenceMaster.Scale(time, new Vector3(x, y, z));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence Scale(float time, float scale, params TweenParams[] par)
        {
            SequenceMaster.Scale(time, new Vector3(scale, scale, scale));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence Scale(float time, Vector3 scale, params TweenParams[] par)
        {
            SequenceMaster.Scale(time, scale);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence ScaleBy(float time, float x, float y, float z, params TweenParams[] par)
        {
            SequenceMaster.ScaleBy(time, new Vector3(x, y, z));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence ScaleBy(float time, Vector3 scale, params TweenParams[] par)
        {
            SequenceMaster.ScaleBy(time, scale);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence ScaleByX(float time, float scaleX, params TweenParams[] par)
        {
            SequenceMaster.ScaleBy(time, new Vector3(scaleX, 0, 0));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence ScaleByY(float time, float scaleY, params TweenParams[] par)
        {
            SequenceMaster.ScaleBy(time, new Vector3(0, scaleY, 0));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence ScaleByZ(float time, float scaleZ, params TweenParams[] par)
        {
            SequenceMaster.ScaleBy(time, new Vector3(0, 0, scaleZ));
            SequenceMaster.ApplyParams(par);
            return this;
        }
    }
}
