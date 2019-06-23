using UnityEngine;

namespace DK.Tweening
{
    public static class Branch
    {
        public static DKSequence Sync()
        {
            return SequenceMaster.CreateBranch(SequenceMaster.BranchType.Sync);
        }

        public static DKSequence Async()
        {
            return SequenceMaster.CreateBranch(SequenceMaster.BranchType.Async);
        }
    }
}
