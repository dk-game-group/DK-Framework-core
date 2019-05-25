using UnityEngine;

namespace DK.Tweening
{
    public partial class DKSequence
    {
        public DKSequence Volume(float time, float value, params TweenParams[] par)
        {
            SequenceMaster.Volume(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence Pitch(float time, float value, params TweenParams[] par)
        {
            SequenceMaster.Pitch(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }
    }
}
