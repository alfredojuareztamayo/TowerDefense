using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
   // private  ObjectPooling SharedInstance;
    public GameObject[] objectToPool;
    public int amountToPool;
    public List<GameObject> pooledList;

    private void Awake()
    {
       // SharedInstance = this;
    }

    void Start()
    {
        Debug.Log(objectToPool.Length);
       
        pooledList = new List<GameObject>();
        //amountToPool = 10;
        GameObject tmp;
        for (int i = 0; i < amountToPool; i++)
        {
            tmp = Instantiate(objectToPool[Random.Range(0, objectToPool.Length)]);
            tmp.SetActive(false);
            pooledList.Add(tmp);
        }

    }


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
