using System.Runtime.CompilerServices;

using DG.Tweening;

namespace DK.Tweening
{
    public struct TweenParams : ITweenParam
    {
        enum Mode { None, Ease }

        readonly Mode mode;
        readonly DG.Tweening.Ease ease;
        
        float overshot;
        float amplitude;
        float period;

        //default ease params (copied from DOTween)
        const float defOvershoot = 1.70158f;
        const float defAmplitude = 1.70158f;

        public TweenParams(DG.Tweening.Ease ease)
        {
            this.mode = Mode.Ease;
            this.ease = ease;

            overshot = defOvershoot;
            amplitude = defAmplitude;
            period = 0;
        }

        public TweenParams(DG.Tweening.Ease ease, float overshot)
        {
            this.mode = Mode.Ease;
            this.ease = ease;
            this.overshot = overshot;
            
            amplitude = defAmplitude;
            period = 0;
        }

        public TweenParams(DG.Tweening.Ease ease, float amplitude, float period)
        {
            this.mode = Mode.Ease;
            this.ease = ease;
            this.amplitude = amplitude;
            this.period = period;

            overshot = defOvershoot;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Apply()
        {
            if (this.mode == Mode.Ease)
                switch (this.ease)
                {
                    default:
                        SequenceMaster.tween.SetEase(this.ease);
                        break;
                    case DG.Tweening.Ease.InBack:
                    case DG.Tweening.Ease.OutBack:
                    case DG.Tweening.Ease.InOutBack:
                        SequenceMaster.tween.SetEase(this.ease, this.overshot);
                        break;
                    case DG.Tweening.Ease.InElastic:
                    case DG.Tweening.Ease.OutElastic:
                    case DG.Tweening.Ease.InOutElastic:
                        SequenceMaster.tween.SetEase(this.ease, this.amplitude, this.period);
                        break;
                }
        }
    }
}
