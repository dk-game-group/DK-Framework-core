using UnityEngine;

namespace DK.Tweening
{
    public partial class DKSequence
    {
        public DKSequence RBMove(float time, Vector3 point, params TweenParams[] par)
        {
            SequenceMaster.RBMoveTo(time, point);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence RBMove(float time, float x, float y, float z, params TweenParams[] par)
        {
            SequenceMaster.RBMoveTo(time, new Vector3(x, y, z));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence RBMoveX(float time, float x, params TweenParams[] par)
        {
            SequenceMaster.RBMoveTo(time, new Vector3(x, 0, 0));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence RBMoveY(float time, float y, params TweenParams[] par)
        {
            SequenceMaster.RBMoveTo(time, new Vector3(0, y, 0));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence RBMoveZ(float time, float z, params TweenParams[] par)
        {
            SequenceMaster.RBMoveTo(time, new Vector3(0, 0, z));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence RBRotate(float time, Vector3 angle, params TweenParams[] par)
        {
            SequenceMaster.RBRotate(time, angle);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence RBRotate(float time, float x, float y, float z, params TweenParams[] par)
        {
            SequenceMaster.RBRotate(time, new Vector3(x, y, z));
            SequenceMaster.ApplyParams(par);
            return this;
        }
    }
}
