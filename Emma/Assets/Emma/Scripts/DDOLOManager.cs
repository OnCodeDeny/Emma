using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///Dont Destroy On Load Objects Manager///
public static class DDOLOManager
{
    static List<GameObject> ddolObjects = new List<GameObject>();

    public static void DontDestroyOnLoad(this GameObject ddolObject)
    {
        Object.DontDestroyOnLoad(ddolObject);
        ddolObjects.Add(ddolObject);
    }

    public static void DestroyAllDDOLObjects()
    {
        foreach (var ddolObject in ddolObjects)
        {
            if (ddolObject != null)
            {
                Object.Destroy(ddolObject);
            }
        }
        ddolObjects.Clear();
    }
}
