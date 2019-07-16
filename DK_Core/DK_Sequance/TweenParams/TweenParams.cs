using DG.Tweening;

namespace DK.Tweening
{
    public class TweenParams
    {
        enum Mode { None, Ease }

        readonly Mode mode;
        readonly DG.Tweening.Ease ease;

        //default ease params (copied from DOTween)
        readonly float overshot = 1.70158f;
        readonly float amplitude = 1.70158f;
        readonly float period;

        public TweenParams(DG.Tweening.Ease ease)
        {
            this.mode = Mode.Ease;
            this.ease = ease;
        }

        public TweenParams(DG.Tweening.Ease ease, float overshot)
        {
            this.mode = Mode.Ease;
            this.ease = ease;
            this.overshot = overshot;
        }

        public TweenParams(DG.Tweening.Ease ease, float amplitude, float period)
        {
            this.mode = Mode.Ease;
            this.ease = ease;
            this.amplitude = amplitude;
            this.period = period;
        }

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
