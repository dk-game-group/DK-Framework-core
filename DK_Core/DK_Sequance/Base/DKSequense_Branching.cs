using System.Runtime.CompilerServices;

using UnityEngine;

namespace DK.Tweening
{
    public partial class DKSequence
    {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DKSequence Branch(DKSequence branch)
        {
            //create and edit branch tween when calculating arguments.
            SequenceMaster.CloseBranch();

            return SequenceMaster.instance;
        }
    }
}
