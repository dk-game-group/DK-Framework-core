using UnityEngine;

namespace DK.Tweening
{
    public partial class DKSequence
    {
        public DKSequence Color(float time, Color color, params TweenParams[] par)
        {
            SequenceMaster.Color(time, color);
            SequenceMaster.ApplyParams(par);
            return this;
        }
        #region Specific components
        public DKSequence MeshColor(float time, Color color, params TweenParams[] par)
        {
            SequenceMaster.MeshColor(time, color);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence SpriteColor(float time, Color color, params TweenParams[] par)
        {
            SequenceMaster.SpriteColor(time, color);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence ImageColor(float time, Color color, params TweenParams[] par)
        {
            SequenceMaster.ImageColor(time, color);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence TextColor(float time, Color color, params TweenParams[] par)
        {
            SequenceMaster.TextColor(time, color);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence LineColor(float time, Color color, params TweenParams[] par)
        {
            SequenceMaster.LineColor(time, color);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence LightColor(float time, Color color, params TweenParams[] par)
        {
            SequenceMaster.LightColor(time, color);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence CameraColor(float time, Color color, params TweenParams[] par)
        {
            SequenceMaster.CameraColor(time, color);
            SequenceMaster.ApplyParams(par);
            return this;
        }
        #endregion

        public DKSequence Fade(float time, float value, params TweenParams[] par)
        {
            SequenceMaster.Fade(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }
        #region Specific compontets
        public DKSequence MeshFade(float time, float value, params TweenParams[] par)
        {
            SequenceMaster.MeshFade(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }
        public DKSequence SpriteFade(float time, float value, params TweenParams[] par)
        {
            SequenceMaster.SpriteFade(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }
        public DKSequence ImageFade(float time, float value, params TweenParams[] par)
        {
            SequenceMaster.ImageFade(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }
        public DKSequence TextFade(float time, float value, params TweenParams[] par)
        {
            SequenceMaster.TextFade(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }
        public DKSequence CanvasFade(float time, float value, params TweenParams[] par)
        {
            SequenceMaster.CanvasFade(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }
        #endregion

        public DKSequence Field(float time, float value, params TweenParams[] par)
        {
            SequenceMaster.Field(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence LightIntensity(float time, float value, params TweenParams[] par)
        {
            SequenceMaster.LightIntensity(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence ShadowStrength(float time, float value, params TweenParams[] par)
        {
            SequenceMaster.ShadowStrength(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        public DKSequence ImageFill(float time, float value, params TweenParams[] par)
        {
            SequenceMaster.ImageFill(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }
    }
}