
using UnityEngine;

using DK.Systems.Pooling;

namespace DK
{
    public partial class DKBehaviour : DKTweener, IPoolable
    {
        ReturnOnDestroy IPoolable.action { get; set; }

        void Awake()
        {
        }

        protected virtual void OnDestroy()
        {

        }

        #region Lock default Unity function
        public new Object Instantiate(Object obj)
        {
            throw new System.Exception("You are not allowed to use Unity Instantiate! Only instantiate through pool");
        }

        public new Object Destroy(Object obj)
        {
            throw new System.Exception("You are not allowed to use Unity Destroy! Only destroy through pool");
        }
        public new Object Destroy(Object obj, float time)
        {
            throw new System.Exception("You are not allowed to use Unity Destroy! Only destroy through pool");
        }
        #endregion

        /// <summary>
        /// Create instance of *GameObject*
        /// </summary>
        /// <returns> Instance object of this type </returns>
        public static DKBehaviour Instantiate()
        {
            throw new System.NotImplementedException();
            //return null; // PoolManager.GetPool<DKBehaviour>().PopElement() as DKBehaviour;
        }
        
        public static DKBehaviour Instantiate(Vector3 position)
        {
            DKBehaviour instance = PoolManager.GetPool<DKBehaviour>().PopElement() as DKBehaviour;
            instance.pos = position;
            return instance;
        }
        public static DKBehaviour Instantiate(Vector3 position, Quaternion rotation)
        {
            DKBehaviour instance = PoolManager.GetPool<DKBehaviour>().PopElement() as DKBehaviour;
            instance.pos = position;
            instance.rot = rotation;
            return instance;
        }
        public static DKBehaviour Instantiate(Vector3 position, Vector3 rotation)
        {
            DKBehaviour instance = PoolManager.GetPool<DKBehaviour>().PopElement() as DKBehaviour;
            instance.pos = position;
            instance.eRot = rotation;
            return instance;
        }

        void IPoolable.Reset()
        {
            // throw new System.NotImplementedException();
        }

        void IPoolable.OnCreate()
        {
            gameObject.SetActive(true);
        }

        void IPoolable.OnDestroy()
        {
            gameObject.SetActive(true);
        }
    }
}
