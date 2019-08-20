
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DK;
using DK.Systems;

namespace DK.Systems.Pooling
{
    internal class ObjectPoolFactory : PoolFactory
    {
        internal static ObjectPoolFactory _instance;
        internal static ObjectPoolFactory instance
        {
            get => _instance ?? (_instance = new ObjectPoolFactory());
        }

        internal override object CreatePool(object instance, int initialCapacity = defaultInitCApasity)
        {
            throw new System.NotImplementedException();
        }
    }
}
