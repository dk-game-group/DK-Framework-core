using UnityEngine;

namespace DK.Tweening
{
    public partial class DKSequence
    {
        public DKSequence Branch(DKSequence branch)
        {
            //create and edit branch tween when calculating arguments.
            SequenceMaster.CloseBranch();

            return SequenceMaster.instance; //TODO 
        }
    }
}
