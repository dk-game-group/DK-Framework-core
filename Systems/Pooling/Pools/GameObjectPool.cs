using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DK.Systems.Pooling
{
    public class GameObjectPool<T> : Pool<T> where T : IPoolable
    {
        public GameObject original;

        public virtual void Init(GameObject original, int startSize)
        {
            this.original = original;
            base.Init(startSize);
        }

        protected override T CreateElement()
        {
            throw new NotImplementedException();
        }

    }
}
