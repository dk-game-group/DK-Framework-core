using System.Runtime.CompilerServices;

using UnityEngine;

using DG;
using DG.Tweening;

namespace DK.Tweening
{
    public static partial class SequenceMaster
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Color(float time, Color color)
        {
            if (tweener.colorMod == null)
            {
                     if (target.GetComponent<UnityEngine.MeshRenderer>())   tweener.colorMod = MeshColor;
                else if (target.GetComponent<UnityEngine.SpriteRenderer>()) tweener.colorMod = SpriteColor;
                else if (target.GetComponent<UnityEngine.UI.Image>())       tweener.colorMod = ImageColor;
                else if (target.GetComponent<UnityEngine.UI.Text>())        tweener.colorMod = TextColor;
                else if (target.GetComponent<UnityEngine.LineRenderer>())   tweener.colorMod = LineColor;
                else if (target.GetComponent<UnityEngine.Light>())          tweener.colorMod = LightColor;
                else if (target.GetComponent<UnityEngine.Camera>())         tweener.colorMod = CameraColor;
            }

            tweener.colorMod?.Invoke(time, color);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Fade(float time, float value)
        {
            if (tweener.fadeMod == null)
            {
                     if (target.GetComponent<UnityEngine.MeshRenderer>())   tweener.fadeMod = MeshFade;
                else if (target.GetComponent<UnityEngine.Light>())          tweener.fadeMod = LightIntensity;
                else if (target.GetComponent<UnityEngine.SpriteRenderer>()) tweener.fadeMod = SpriteFade;
                else if (target.GetComponent<UnityEngine.UI.Image>())       tweener.fadeMod = ImageFade;
                else if (target.GetComponent<UnityEngine.UI.Text>())        tweener.fadeMod = TextFade;
                else if (target.GetComponent<UnityEngine.CanvasGroup>())    tweener.fadeMod = CanvasFade;
            }

            tweener.fadeMod?.Invoke(time, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Move(float time, Vector3 dir)
        {      
            if (tweener.rectTransform)
                MoveUITo(time, dir);
            else
                MoveTo(time, dir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveX(float time, float pointX)
        {
            if (tweener.rectTransform)
                MoveUIToX(time, pointX);
            else
                MoveToX(time, pointX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveY(float time, float pointY)
        {
            if (tweener.rectTransform)
                MoveUIToY(time, pointY);
            else
                MoveToY(time, pointY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveZ(float time, float pointZ)
        {
            if (tweener.rectTransform)
                MoveUIToZ(time, pointZ);
            else
                MoveToZ(time, pointZ);
        }
    }
}
