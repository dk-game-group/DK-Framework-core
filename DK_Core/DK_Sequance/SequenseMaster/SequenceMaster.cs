using UnityEngine;

using DG.Tweening;
using DG.Tweening.Core;

namespace DK.Tweening
{
    public partial class SequenceMaster
    {
        public static readonly DKSequence instance;
        public static GameObject target { get; private set; }
        public static DG.Tweening.Sequence sequence { get; private set; }
        public static Tween tween { get; private set; }

        static SequenceMaster()
        {
            instance = new DKSequence();
        }

        public static DKSequence CreateSequence(GameObject node, string name = "")
        {
            target = node;
            sequence = DG.Tweening.DOTween.Sequence();
            if (name != "")
                sequence.stringId = name;

            return instance;
        }
       
        public static void Loop(int count, LoopType type)
        {
            sequence.SetLoops(count, type);
        }        

        public static void Delay(float time)
        {
            sequence.AppendInterval(time);
        }

        public static void Delay(float time, TweenCallback callback)
        {
            sequence.AppendInterval(time).AppendCallback(callback);
        }

        public static void Value(float time, float from, float to, DOSetter<float> action)
        {
            sequence.Append(DOTween.To(() => from, action, to, time));
        }

        public static void Do(TweenCallback action)
        {
            sequence.AppendCallback(() => action());
        }

        public static void Complete(System.Action action)
        {
            sequence.OnComplete(() => action());
        }        

        public static void ApplyParams(TweenParams[] settings)
        {
            for (int i = 0; i < settings.Length; i++)
                settings[i].Apply();
        }
    }
}
