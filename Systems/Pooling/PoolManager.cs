using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using Object = UnityEngine.Object;

namespace DK.Systems.Pooling
{
    public static class PoolManager
    {
        #region Config
        //TODO implement
        public static bool allowPoolCreationAfterApplicationLoad;
        public static bool allowPoolResizeAfterApplicationLoad;

        public static bool logPoolCreation;

        #endregion

        static PoolsConfig config;

        readonly static Hashtable pools = new Hashtable(50);

        readonly static DKBehaviourPoolFactory DKBehFactory = DKBehaviourPoolFactory.instance;
        readonly static PoolFactory ObjectFactory = ObjectPoolFactory.instance;

        const int defaultPoolCapasity = 10;

        //TODO @DK make internal after testings
        public static void Init()
        {
            if (config == null)
                config = GetConfig();

            CreatePools();
        }

        static PoolsConfig GetConfig()
        {
            PoolsConfig config = Resources.Load<PoolsConfig>("PoolsConfig");

            if (config == null)
            {
                config = ScriptableObject.CreateInstance<PoolsConfig>();
                AssetDatabase.CreateAsset(config, "Assets/Resources/PoolsConfig.asset");
            }

            return config;
        }

        static void CreatePools()
        {
            for (int i = 0; i < config.poolsData.Count; i++)
            {
                PoolData pd = config.poolsData[i];
                if (pd.isScript)
                {
                    //Assembly-CSharp
                    Type t = Type.GetType(pd.type + ", Assembly-CSharp");
                    if (t.IsSubclassOf(typeof(DKBehaviour)))
                    {
                        MethodInfo mf = typeof(PoolManager).GetMethod(nameof(CreateDKBehaveourPool), BindingFlags.Static | BindingFlags.NonPublic);
                        mf = mf.MakeGenericMethod(t);
                        mf.Invoke(null, new object[] { pd.instance });
                    }
                    //else create Object pool
                }
                //else create GameObject pool
            }
        }

        public static void CreatePool<T>(System.Object instance) where T : IPoolable, new()
        {
            #region input check
            #if UNITY_EDITOR
            if(pools.ContainsKey(typeof(T)))
                throw new System.Exception($"Error: Pool of {typeof(T)} already created");
            #endif //UNITY_EDITOR
            #endregion

            Pool<T> pool = CreateObjectPool<T>();
            pools.Add(typeof(T), pool);

            if(logPoolCreation)
                Debug.Log($"Created {typeof(T)} pool");
        }

        public static void CreatePool<T>(DKBehaviour instance) where T : IPoolable, new()
        {
            #region input check
            #if UNITY_EDITOR
            if (pools.ContainsKey(typeof(T)))
                throw new System.Exception($"Error: Pool of {typeof(T)} already created");
            #endif //UNITY_EDITOR
            #endregion

            Object obj = PrefabUtility.GetPrefabInstanceHandle(instance);
            if (obj == null)
            {
                Debug.Log("!!!!!!!!!!!!!!!!! " + instance.GetInstanceID());
            }
            Selection.activeGameObject = obj as GameObject;
            Debug.Log(AssetDatabase.GetAssetPath(obj));

            config.poolsData.Add(
                new PoolData() {
                    isScript = true,
                    type = typeof(T).FullName,
                    size = defaultPoolCapasity,
                    instance = null
                }
            );

            Pool<T> pool = CreateDKBehaveourPool<T>(instance);
            pools.Add(typeof(T), pool);

            if (logPoolCreation)
                Debug.Log($"Created {typeof(T)} pool");
        }

        internal static Pool<T> CreateObjectPool<T>() where T : IPoolable, new()
        {
            return ObjectFactory.CreatePool<T>();
        }

        internal static Pool<T> CreateDKBehaveourPool<T>(System.Object instance) where T : IPoolable, new()
        {
            Debug.Log("Will create pool of " + typeof(T));
            return DKBehFactory.CreatePool<T>(instance);
        }

        public static Pool<IPoolable> GetPool(Type type)
        {
            #region input check
            #if UNITY_EDITOR
            Type[] interfaces = type.GetInterfaces();
            bool isPoolable = false;
            for (int i = 0; i < interfaces.Length; i++)
                if (interfaces[i] == typeof(IPoolable))
                {
                    isPoolable = true;
                    break;
                }

            if (isPoolable == false)
                throw new System.Exception($"Error: Type {type} not implement IPoolable interface!");

            if ((pools[type] as Pool<IPoolable>) == null)
                throw new System.Exception($"Error: Pool of {type} not found! Make sure to create it first");
            #endif //UNITY_EDITOR
            #endregion

            return pools[type] as Pool<IPoolable>;
        }

        public static Pool<T> GetPool<T>() where T : IPoolable
        {
            #region input check
            #if UNITY_EDITOR
            if (pools.ContainsKey(typeof(T)) == false)
                throw new System.Exception($"Error: Cannot get pool of {typeof(T)}!");
            #endif //UNITY_EDITOR
            #endregion

            return pools[typeof(T)] as Pool<T>;
        }
    }
}
