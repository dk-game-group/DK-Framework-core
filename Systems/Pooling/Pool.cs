using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DK.Systems
{
    public class Pool<T> where T : DKBehaviour
    {
        GameObject originalGameObject;

        private int poolSize;
        public int maxSize { get; protected set;}
        
        protected List<(GameObject go, T script)> pool;           //complete list of all elements linked to pool
        protected List<(GameObject go, T script)> activeElements; //list of all elements which are active in game
        protected List<(GameObject go, T script)> storedElements; //list of inactive elements stored for future use

        //TODO@DK:Think about using array and structs for DOTS compatibility

        public Pool(int poolSize, GameObject original)
        {
            this.poolSize = poolSize;
            originalGameObject = original;
            Init();
        }

        protected virtual void Init()
        {
            pool           = new List<(GameObject go, T script)>(poolSize);
            activeElements = new List<(GameObject go, T script)>(poolSize);
            storedElements = new List<(GameObject go, T script)>(poolSize);

            FillPool();
        }

        protected virtual void FillPool()
        {
            for (int i = 0; i < poolSize; i++)
            {
                (GameObject go, T script) element;
                element.go = GameObject.Instantiate(originalGameObject);
                element.script = element.go.GetComponent<T>();

                pool.Add(element);
                storedElements.Add(element);
            }
        }

        public T PopElement()
        {
            (GameObject go, T script) element;

            element = storedElements[0];

            storedElements.RemoveAt(0);
            activeElements.Add(element);

            element.go.SetActive(true);
            element.script.OnCreate();
            //element.pool = this;
                
            return element.script;
        }

        public void ForEach(Action<T> action)
        {
            for (int i = activeElements.Count - 1; i >= 0; i--)
                action(activeElements[i].script);
        }

        public void ForAll(Action<T> action)
        {
            for (int i = pool.Count - 1; i >= 0; i--)
                action(pool[i].script);
        }


    }
}
