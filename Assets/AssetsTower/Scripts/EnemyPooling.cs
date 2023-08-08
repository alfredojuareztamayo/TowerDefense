using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyPooling : MonoBehaviour
{
    public static EnemyPooling SharedInstance;
    public GameObject enemyToPool;
    private int amountToPool;
    public List<GameObject> enemyPooleds;

    private void Awake()
    {
        SharedInstance = this;
    }

    void Start()
    {
        enemyPooleds = new List<GameObject>();
        amountToPool = 10;
        GameObject tmp;
        for (int i = 0; i < amountToPool; i++)
        {
            tmp = Instantiate(enemyToPool);
            tmp.SetActive(false);
            enemyPooleds.Add(tmp);
        }

    }


    public GameObject GetPoolEnemy()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            if (!enemyPooleds[i].activeInHierarchy)
            {
                return enemyPooleds[i];
            }
        }
        return null;
    }
}
