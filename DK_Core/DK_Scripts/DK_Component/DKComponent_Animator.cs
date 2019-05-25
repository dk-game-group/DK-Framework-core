using UnityEngine;

namespace DK
{
    public abstract partial class DKComponent : MonoBehaviour
    {
        Animator _animator;
        public Animator animator => _animator = _animator ?? GetComponent<Animator>();

              
    }
}
