using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/// <summary>
/// Manages object pooling for reusing game objects.
/// </summary>
public class ObjectPooling : MonoBehaviour
{
    /// <summary>
    /// Array of object prefabs to be pooled.
    /// </summary>
    public GameObject[] objectToPool;

    /// <summary>
    /// The total number of objects to be pooled.
    /// </summary>
    public int amountToPool;

    /// <summary>
    /// List of pooled game objects.
    /// </summary>
    public List<GameObject> pooledList;

    private void Awake()
    {
        // SharedInstance = this;
    }

    void Start()
    {
        pooledList = new List<GameObject>();

        // Instantiate and deactivate objects for pooling.
        GameObject tmp;
        for (int i = 0; i < amountToPool; i++)
        {
            tmp = Instantiate(objectToPool[Random.Range(0, objectToPool.Length)]);
            tmp.SetActive(false);
            pooledList.Add(tmp);
        }
    }

    /// <summary>
    /// Retrieves an available object from the pool.
    /// </summary>
    /// <returns>An inactive game object from the pool, or null if none are available.</returns>
    public GameObject GetPoolObject()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            if (!pooledList[i].activeInHierarchy)
            {
                return pooledList[i];
            }
        }
        return null;
    }
}
