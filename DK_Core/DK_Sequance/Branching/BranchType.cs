using System.Runtime.CompilerServices;

using UnityEngine;

namespace DK.Tweening
{
    public static class Branch
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DKSequence Sync()
        {
            return SequenceMaster.CreateBranch(SequenceMaster.Branch.Mode.Sync);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DKSequence Async()
        {
            return SequenceMaster.CreateBranch(SequenceMaster.Branch.Mode.Async);
        }
    }
}
