using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DK.Systems.Pooling
{
    public class ObjectPool<T> : Pool<T> where T : IPoolable, new()
    {
        //Each pool should define way to create element they store
        protected override T CreateElement()
        {
            return new T();
        }
    }
}
