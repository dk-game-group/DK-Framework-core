using System;

using UnityEngine;

using DK.Systems;

namespace DK
{
    public partial class DKBehaviour : DKTweener
    {
        public Pool<DKBehaviour> parentPool;

        // DK systems callbacks
        public virtual void OnCreate() {            
        }


        //Unity MonoBehaveour overrides
        public void Instantiate()
        {
            
        }
    }
}
