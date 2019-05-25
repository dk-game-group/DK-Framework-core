using UnityEngine;

namespace DK
{
    public abstract partial class DKComponent : MonoBehaviour
    {
        Rigidbody _rigidbody;
        public new Rigidbody rigidbody => _rigidbody = _rigidbody ?? gameObject.GetComponent<Rigidbody>();
        public Rigidbody rb => rigidbody;

        public Vector3 velocity
        {
            get => rb ? rb.velocity : Vector3.zero;
        }
    }
}
