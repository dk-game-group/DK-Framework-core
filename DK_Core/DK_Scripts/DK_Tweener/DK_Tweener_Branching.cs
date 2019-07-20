using UnityEngine;

using DK.Tweening;

namespace DK
{
    public abstract partial class DKTweener : DKComponent
    {
        public DKSequence Async()
        {
            return Branch.Async();
        }

        public DKSequence Sync()
        {
            return Branch.Sync();
        }
    }
}
