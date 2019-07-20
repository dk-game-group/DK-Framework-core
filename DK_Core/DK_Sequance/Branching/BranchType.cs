using System.Runtime.CompilerServices;

using UnityEngine;

namespace DK.Tweening
{
    public static class Branch
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DKSequence Sync()
        {
            return SequenceMaster.CreateBranch(SequenceMaster.BranchType.Sync);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DKSequence Async()
        {
            return SequenceMaster.CreateBranch(SequenceMaster.BranchType.Async);
        }
    }
}
