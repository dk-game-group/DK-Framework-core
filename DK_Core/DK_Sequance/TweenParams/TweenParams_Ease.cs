using UnityEngine;

using DG;
using DG.Tweening;

namespace DK.Tweening
{
    public class Ease
    {
        /// Const Eases
        public static TweenParams Linear     => new TweenParams(DG.Tweening.Ease.Linear);

        public static TweenParams InSine     => new TweenParams(DG.Tweening.Ease.InSine);
        public static TweenParams InQuad     => new TweenParams(DG.Tweening.Ease.InQuad);
        public static TweenParams InCubic    => new TweenParams(DG.Tweening.Ease.InCubic);
        public static TweenParams InQuart    => new TweenParams(DG.Tweening.Ease.InQuart);
        public static TweenParams InQuint    => new TweenParams(DG.Tweening.Ease.InQuint);

        public static TweenParams OutSine    => new TweenParams(DG.Tweening.Ease.OutSine);
        public static TweenParams OutQuad    => new TweenParams(DG.Tweening.Ease.OutQuad);
        public static TweenParams OutCubic   => new TweenParams(DG.Tweening.Ease.OutCubic);
        public static TweenParams OutQuart   => new TweenParams(DG.Tweening.Ease.OutQuart);
        public static TweenParams OutQuint   => new TweenParams(DG.Tweening.Ease.OutQuint);

        public static TweenParams InOutSine  => new TweenParams(DG.Tweening.Ease.InOutSine);
        public static TweenParams InOutQuad  => new TweenParams(DG.Tweening.Ease.InOutQuad);
        public static TweenParams InOutCubic => new TweenParams(DG.Tweening.Ease.InOutCubic);
        public static TweenParams InOutQuart => new TweenParams(DG.Tweening.Ease.InOutQuart);
        public static TweenParams InOutQuint => new TweenParams(DG.Tweening.Ease.InOutQuint);


        public static TweenParams InExpo   => new TweenParams(DG.Tweening.Ease.InExpo);
        public static TweenParams InCirc   => new TweenParams(DG.Tweening.Ease.InCirc);
        public static TweenParams InBounce => new TweenParams(DG.Tweening.Ease.InBounce);

        public static TweenParams OutExpo   => new TweenParams(DG.Tweening.Ease.OutExpo);
        public static TweenParams OutCirc   => new TweenParams(DG.Tweening.Ease.OutCirc);
        public static TweenParams OutBounce => new TweenParams(DG.Tweening.Ease.OutBounce);

        public static TweenParams InOutExpo   => new TweenParams(DG.Tweening.Ease.InOutExpo);
        public static TweenParams InOutCirc   => new TweenParams(DG.Tweening.Ease.InOutCirc);
        public static TweenParams InOutBounce => new TweenParams(DG.Tweening.Ease.InOutBounce);

        /// Eases with pars 
        public static TweenParams InBack(float overshot)    => new TweenParams(DG.Tweening.Ease.InBack, overshot);
        public static TweenParams OutBack(float overshot)   => new TweenParams(DG.Tweening.Ease.OutBack, overshot);
        public static TweenParams InOutBack(float overshot) => new TweenParams(DG.Tweening.Ease.InOutBack, overshot);

        public static TweenParams InElastic(float amplitude, float period)    => new TweenParams(DG.Tweening.Ease.InElastic, amplitude, period);
        public static TweenParams OutElastic(float amplitude, float period)   => new TweenParams(DG.Tweening.Ease.OutElastic, amplitude, period);
        public static TweenParams InOutElastic(float amplitude, float period) => new TweenParams(DG.Tweening.Ease.InOutElastic, amplitude, period);
    }
}