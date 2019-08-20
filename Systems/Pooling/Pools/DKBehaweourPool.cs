using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DK.Systems.Pooling
{
    public class DKBehaveourPool<T> : Pool<T> where T : IPoolable
    {
         GameObject original;

        public virtual void Init(GameObject original, int startSize)
        {
            this.original = original;
            base.Init(startSize);
        }

        protected override T CreateElement()
        {
            GameObject go = UnityEngine.Object.Instantiate(original) as GameObject;
            go.SetActive(false);
            return go.GetComponent<T>();
        }
    }
}
