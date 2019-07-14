using UnityEngine;

namespace DK
{
    public abstract partial class DKComponent : MonoBehaviour
    {
        Transform _transform;
        public new Transform transform => _transform = _transform ?? gameObject.transform;
        public Transform tr => transform;

        public Vector3 pos
        {
            get => tr.position;
            set => tr.position = value;
        }
        public Vector3 lPos
        {
            get => tr.localPosition;
            set => tr.localPosition = value;
        }
        public Quaternion rot
        {
            get => tr.rotation;
            set => tr.rotation = value;
        }
        public Vector3 eRot
        {
            get => tr.rotation.eulerAngles;
            set => tr.eulerAngles = value;
        }
        public Quaternion lRot
        {
            get => tr.localRotation;
            set => tr.localRotation = value;
        }
        public Vector3 leRot
        {
            get => tr.localEulerAngles;
            set => tr.localEulerAngles = value;
        }

        public Vector3 scale
        {
            get => tr.localScale;
            set => tr.localScale = value;
        }

    }
}
