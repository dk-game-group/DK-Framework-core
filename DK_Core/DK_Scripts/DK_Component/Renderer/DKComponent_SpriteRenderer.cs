using UnityEngine;

namespace DK
{
    public abstract partial class DKComponent : MonoBehaviour
    {
        public SpriteRenderer spriteRenderer => _renderer as SpriteRenderer;

        public Sprite sprite => spriteRenderer.sprite;

    }
}
