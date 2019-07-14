using System;

using UnityEngine;

using DK.Systems;

namespace DK
{
    public partial class DKBehaviour : DKTweener
    {

        public Pool<DKBehaviour> parentPool;

        // DK systems callbacks
        protected virtual void OnCreate()
        {

        }

        protected virtual void OnDestroy()
        {

        }
         
        //Unity MonoBehaveour overrides
        public static void Instantiate()
        {
            Debug.Log(nameof(DKBehaviour));
        }
    }
}
