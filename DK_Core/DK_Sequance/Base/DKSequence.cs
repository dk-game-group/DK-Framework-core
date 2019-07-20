using System.Runtime.CompilerServices;

using UnityEngine;

using DG.Tweening;
using DG.Tweening.Core;


namespace DK.Tweening
{ 
    public partial class DKSequence
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Delay(float time)
        {
            SequenceMaster.Delay(time);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Loop(int count, LoopType type)
        {
            SequenceMaster.Loop(count, type);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Loop(int count)
        {
            SequenceMaster.Loop(count, LoopType.Restart);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Loop(LoopType type)
        {
            SequenceMaster.Loop(-1, type);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Loop()
        {
            SequenceMaster.Loop(-1, LoopType.Restart);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Delay(float time, TweenCallback callback)
        {
            SequenceMaster.Delay(time, callback);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Value(float time, float from, float to, DOSetter<float> action, params ITweenParam[] par)
        {
            SequenceMaster.Value(time, from, to, (v) => action(v));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Value01(float time, DOSetter<float> action, params ITweenParam[] par)
        {
            SequenceMaster.Value(time, 0, 1, (v) => action(v));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Value10(float time, DOSetter<float> action, params ITweenParam[] par)
        {
            SequenceMaster.Value(time, 1, 0, (v) => action(v));
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Do(TweenCallback action)
        {
            SequenceMaster.Do(action);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Compleate(System.Action action)
        {
            SequenceMaster.Complete(action);
        }
    }
}
