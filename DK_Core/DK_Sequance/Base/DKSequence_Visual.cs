using System.Runtime.CompilerServices;

using UnityEngine;

namespace DK.Tweening
{
    public partial class DKSequence
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Color(float time, Color color, params ITweenParam[] par)
        {
            SequenceMaster.Color(time, color);
            SequenceMaster.ApplyParams(par);
            return this;
        }
        #region Specific components
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence MeshColor(float time, Color color, params ITweenParam[] par)
        {
            SequenceMaster.MeshColor(time, color);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence SpriteColor(float time, Color color, params ITweenParam[] par)
        {
            SequenceMaster.SpriteColor(time, color);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence ImageColor(float time, Color color, params ITweenParam[] par)
        {
            SequenceMaster.ImageColor(time, color);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence TextColor(float time, Color color, params ITweenParam[] par)
        {
            SequenceMaster.TextColor(time, color);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence LineColor(float time, Color color, params ITweenParam[] par)
        {
            SequenceMaster.LineColor(time, color);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence LightColor(float time, Color color, params ITweenParam[] par)
        {
            SequenceMaster.LightColor(time, color);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence CameraColor(float time, Color color, params ITweenParam[] par)
        {
            SequenceMaster.CameraColor(time, color);
            SequenceMaster.ApplyParams(par);
            return this;
        }
        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Fade(float time, float value, params ITweenParam[] par)
        {
            SequenceMaster.Fade(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        #region Specific compontets
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence MeshFade(float time, float value, params ITweenParam[] par)
        {
            SequenceMaster.MeshFade(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence SpriteFade(float time, float value, params ITweenParam[] par)
        {
            SequenceMaster.SpriteFade(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence ImageFade(float time, float value, params ITweenParam[] par)
        {
            SequenceMaster.ImageFade(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence TextFade(float time, float value, params ITweenParam[] par)
        {
            SequenceMaster.TextFade(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence CanvasFade(float time, float value, params ITweenParam[] par)
        {
            SequenceMaster.CanvasFade(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }
        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Field(float time, float value, params ITweenParam[] par)
        {
            SequenceMaster.Field(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence LightIntensity(float time, float value, params ITweenParam[] par)
        {
            SequenceMaster.LightIntensity(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence ShadowStrength(float time, float value, params ITweenParam[] par)
        {
            SequenceMaster.ShadowStrength(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence ImageFill(float time, float value, params ITweenParam[] par)
        {
            SequenceMaster.ImageFill(time, value);
            SequenceMaster.ApplyParams(par);
            return this;
        }
    }
}