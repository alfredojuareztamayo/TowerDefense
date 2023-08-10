using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages the pooling and spawning of enemies.
/// </summary>
public class EnemyPooling : MonoBehaviour
{
    private float timeToPool;
    public GameObject spawnPlace;
    public ObjectPooling objectPool;

    void Start()
    {
        timeToPool = 0;
    }

    // Update is called once per frame
    void Update()
    {
        InstanceEnemys();
    }

    /// <summary>
    /// Instantiates enemies from the object pool based on a timer.
    /// </summary>
    public void InstanceEnemys()
    {
        timeToPool += Time.fixedDeltaTime;

        GameObject enemyToSpawn = objectPool.GetPoolObject();

        if (timeToPool > 5)
        {
            if (enemyToSpawn != null)
            {
                enemyToSpawn.transform.position = spawnPlace.transform.position;
                enemyToSpawn.transform.rotation = spawnPlace.transform.rotation;
                enemyToSpawn.SetActive(true);
                timeToPool = 0;
            }
        }
    }
}