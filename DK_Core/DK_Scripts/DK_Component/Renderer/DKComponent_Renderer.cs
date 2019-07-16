using UnityEngine;

namespace DK
{
    public abstract partial class DKComponent : MonoBehaviour
    {
        Renderer _renderer;
        public new Renderer renderer => _renderer = _renderer ?? GetComponent<Renderer>();

        public Material material => _renderer.sharedMaterial;
        public Material lMaterial => _renderer.material;

        public Material[] materials => _renderer.sharedMaterials;
        public Material[] lMaterials => _renderer.materials;

        public Shader shader => _renderer.material.shader;
    }
}
