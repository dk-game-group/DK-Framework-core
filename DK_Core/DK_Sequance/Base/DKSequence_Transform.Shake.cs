using UnityEngine;

namespace DK.Tweening
{
    public partial class DKSequence
    {
        public DKSequence ShakePos(float time, float forse, int vibro, float random, params TweenParams[] par)
        {
            SequenceMaster.ShakePos(time, new Vector3(forse, forse, forse), vibro, random);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence ShakePos(float time, Vector3 forse, int vibro, float random, params TweenParams[] par)
        {
            SequenceMaster.ShakePos(time, forse, vibro, random);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence ShakeRot(float time, float forse, int vibro, float random, params TweenParams[] par)
        {
            SequenceMaster.ShakeRot(time, new Vector3(forse, forse, forse), vibro, random);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence ShakeRot(float time, Vector3 forse, int vibro, float random, params TweenParams[] par)
        {
            SequenceMaster.ShakeRot(time, forse, vibro, random);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence ShakeScl(float time, float forse, int vibro, float random, params TweenParams[] par)
        {
            SequenceMaster.ShakeScl(time, new Vector3(forse, forse, forse), vibro, random);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence ShakeScl(float time, Vector3 forse, int vibro, float random, params TweenParams[] par)
        {
            SequenceMaster.ShakeScl(time, forse, vibro, random);
            SequenceMaster.ApplyParams(par);
            return this;
        }
    }
}
