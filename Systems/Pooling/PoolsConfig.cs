using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DK.Systems.Pooling
{
    internal class PoolsConfig : ScriptableObject
    {
        [SerializeField]
        internal List<PoolData> poolsData = new List<PoolData>(10);

        internal void CResetPoolsCapacity()
        {
            for (int i = 0; i < poolsData.Count; i++)
            {
                PoolData pd = poolsData[i];

                pd.size = 0;
            }
        }

        internal void ClearConfig()
        {
            poolsData.Clear();
        }
    }
    
    [System.Serializable]
    internal struct PoolData
    {
        [SerializeField]
        internal bool isScript;

        [SerializeField]
        internal string type;

        [SerializeField]
        internal MonoBehaviour instance;

        [SerializeField]
        internal int size;
    }
}
