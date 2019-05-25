using UnityEngine;

namespace DK
{
    public abstract partial class DKComponent : MonoBehaviour
    {
        SpriteRenderer _sprite;
        public SpriteRenderer spriteRenderer => _sprite = _sprite ?? GetComponent<SpriteRenderer>();

        public Sprite sprite => _sprite.sprite;

    }
}
