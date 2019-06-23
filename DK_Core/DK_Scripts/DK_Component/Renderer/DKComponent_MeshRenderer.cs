using UnityEngine;

namespace DK
{
    public abstract partial class DKComponent : MonoBehaviour
    {
        MeshRenderer _meshRenderer;
        public MeshRenderer meshRenderer => _meshRenderer = _meshRenderer ?? GetComponent<MeshRenderer>();

    }
}
