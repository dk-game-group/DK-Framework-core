using System.Collections.Generic;

using UnityEditor;
using UnityEngine;

[ExecuteInEditMode]
public static class ReferenceLister
{
    static ReferenceLister()
    {
        Debug.Log("ReferenceLister Init");
    }

    static void Init()
    {
        AssemblyReloadEvents.afterAssemblyReload += OnAfterAssemblyReload;
    }

    static void OnAfterAssemblyReload()
    {
        
    }
}
