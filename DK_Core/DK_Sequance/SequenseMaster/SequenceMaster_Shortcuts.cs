using UnityEngine;

using DG;
using DG.Tweening;

namespace DK.Tweening
{
    public static partial class SequenceMaster
    {
        public static void Color(float time, Color color)
        {
                 if (target.GetComponent<UnityEngine.MeshRenderer>()) MeshColor(time, color);
            else if (target.GetComponent<UnityEngine.SpriteRenderer>()) SpriteColor(time, color);
            else if (target.GetComponent<UnityEngine.UI.Image>()) ImageColor(time, color);
            else if (target.GetComponent<UnityEngine.UI.Text>()) TextColor(time, color);
            else if (target.GetComponent<UnityEngine.LineRenderer>()) LineColor(time, color);
            else if (target.GetComponent<UnityEngine.Light>()) LightColor(time, color);
            else if (target.GetComponent<UnityEngine.Camera>()) CameraColor(time, color);
        }

        public static void Fade(float time, float value)
        {
                 if (target.GetComponent<UnityEngine.MeshRenderer>()) MeshFade(time, value);
            else if (target.GetComponent<UnityEngine.Light>()) LightIntensity(time, value);
            else if (target.GetComponent<UnityEngine.SpriteRenderer>()) SpriteFade(time, value);
            else if (target.GetComponent<UnityEngine.UI.Image>()) ImageFade(time, value);
            else if (target.GetComponent<UnityEngine.UI.Text>()) TextFade(time, value);
            else if (target.GetComponent<UnityEngine.CanvasGroup>()) CanvasFade(time, value);
        }

        public static void Move(float time, Vector3 dir)
        {
            if (target.GetComponent<UnityEngine.RectTransform>())
                MoveUITo(time, dir);
            else
                MoveTo(time, dir);
        }

        public static void MoveX(float time, float pointX)
        {
            if (target.GetComponent<UnityEngine.RectTransform>())
                MoveUIToX(time, pointX);
            else
                MoveToX(time, pointX);
        }

        public static void MoveY(float time, float pointY)
        {
            if (target.GetComponent<UnityEngine.RectTransform>())
                MoveUIToX(time, pointY);
            else
                MoveToX(time, pointY);
        }

        public static void MoveZ(float time, float pointZ)
        {
            if (target.GetComponent<UnityEngine.RectTransform>())
                MoveUIToX(time, pointZ);
            else
                MoveToX(time, pointZ);
        }
    }
}
