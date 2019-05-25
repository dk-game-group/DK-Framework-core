using UnityEngine;

using System.Collections.Generic;

using DG.Tweening;
using DK.Tweening;

namespace DK
{
    public abstract partial class DKTweener : DKComponent
    {
        protected List<Sequence> sequences = new List<Sequence>();

        public DKSequence Sequence(string name = "")
        {
            SequenceMaster.CreateSequence(gameObject, name);
            sequences.Add(SequenceMaster.sequence);
            return SequenceMaster.instance;
        }

        protected virtual void DestroySequence(Sequence sequence)
        {
            sequences.Remove(sequence);
            sequence.Kill();
        }

        protected virtual void PauseSequence(Sequence sequence)
        {
            sequence.Pause();
        }

        protected virtual void ResumeSequence(Sequence sequence)
        {
            sequence.Play();
        }

        public virtual void StopTweens(bool reset = false)
        {
            for (int i = 0; i < sequences.Count; i++)
                DestroySequence(sequences[i]);

        }

        public virtual void PauseTweens()
        {
            for (int i = 0; i < sequences.Count; i++)
                PauseSequence(sequences[i]);
        }

        public virtual void ResumeTweens()
        {
            for (int i = 0; i < sequences.Count; i++)
                ResumeSequence(sequences[i]);
        }

        public virtual void StopTween(string name)
        {
            for (var i = sequences.Count - 1; i >= 0; i--)
                if (name == sequences[i].stringId)
                    DestroySequence(sequences[i]);
        }

        public virtual List<Sequence> GetTweens()
        {
            return sequences;
        }

        public virtual Tween GetTween(string name)
        {
            for (int i = 0; i < sequences.Count; i++)
                if (name == sequences[i].stringId)
                    if (sequences[i].IsPlaying())
                        return sequences[i];

            return null;
        }
    }
}
