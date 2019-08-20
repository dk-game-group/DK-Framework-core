using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DK.Systems.Pooling
{
    public abstract class Pool<T> where T : IPoolable
    {
        protected List<T> pool;           //complete list of all elements linked to pool
        protected List<T> activeElements; //list of all elements which are active in game
        protected List<T> storedElements; //list of inactive elements stored for future use

        //TODO @DK:Think about using array and structs for DOTS compatibility

        internal Pool()
        {

        }

/// <summary>
/// Set list sizes and fill;
/// </summary>
/// <param name="startSize"></param>
        internal virtual void Init(int startSize)
        {
            pool           = new List<T>(startSize);
            activeElements = new List<T>(startSize);
            storedElements = new List<T>(startSize);

            IncreacePool(startSize);
        }

        //Each pool should define way to create element they store
        protected abstract T CreateElement();

        /// <summary>
        /// Increase pool size and fill up
        /// </summary>
        /// <param name="incSize"></param>
        protected virtual void IncreacePool(int amaunt)
        {
            for (int i = 0; i < amaunt; i++)
            {
                T element = CreateElement();

                pool.Add(element);
                storedElements.Add(element);
                element.action = () => PushElement(element); //return self to pool;
            }
        }

        /// <summary>
        /// Retrieve element from pool
        /// </summary>
        /// <returns></returns>
        public virtual T PopElement()
        {
            if (storedElements.Count == 0)
                IncreacePool(10);

            T element = storedElements[storedElements.Count - 1];

            storedElements.RemoveAt(storedElements.Count-1);
            activeElements.Add(element);

            element.Reset();
            element.OnCreate();

            return element;
        }

        /// <summary>
        /// Return element to pool
        /// </summary>
        /// <param name="element"></param>
        public void PushElement(T element)
        {
            activeElements.Remove(element);
            storedElements.Add(element);

            element.OnDestroy();
        }

        /// <summary>
        /// Iterate over active elements
        /// </summary>
        /// <param name="action"></param>
        public void ForEach(Action<T> action)
        {
            for (int i = activeElements.Count - 1; i >= 0; i--)
                action(activeElements[i]);
        }

        /// <summary>
        /// Iterate over all elements
        /// </summary>
        /// <param name="action"></param>
        public void ForAll(Action<T> action)
        {
            for (int i = pool.Count - 1; i >= 0; i--)
                action(pool[i]);
        }
    }
}
