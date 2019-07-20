using System.Runtime.CompilerServices;

using UnityEngine;

namespace DK.Tweening
{
    public partial class DKSequence
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Volume(float time, float value, params ITweenParam[] par)
        {
            SequenceMaster.Volume(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Pitch(float time, float value, params ITweenParam[] par)
        {
            SequenceMaster.Pitch(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }
    }
}
