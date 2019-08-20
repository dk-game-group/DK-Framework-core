
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DK;
using DK.Systems;

namespace DK.Systems.Pooling
{
    internal class DKBehaviourPoolFactory : PoolFactory
    {
        internal static DKBehaviourPoolFactory _instance;
        internal static DKBehaviourPoolFactory instance
        {
            get => _instance ?? (_instance = new DKBehaviourPoolFactory());
        }

        internal override Pool<T> CreatePool<T>(object instance, int initialCapacity = 10) 
        {
            DKBehaviour dkbeh = instance as DKBehaviour;
            DKBehaveourPool<T> pool = new DKBehaveourPool<T>();
            pool.Init(dkbeh.gameObject, initialCapacity);
            return pool;
        }
    }
}
