using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages the pooling and shooting of bullets.
/// </summary>
public class BulletsPool : MonoBehaviour
{
    /// <summary>
    /// The spawn position for bullets.
    /// </summary>
    public GameObject spawnPlaceBullet;

    /// <summary>
    /// The object pool used for bullets.
    /// </summary>
    public ObjectPooling objectPool;

    /// <summary>
    /// The time interval between bullet respawn.
    /// </summary>
    public float respawnTime;

    /// <summary>
    /// The initial amount of bullets in the pool.
    /// </summary>
    public int amountBulletsCount;

    /// <summary>
    /// Indicates whether shooting is in progress.
    /// </summary>
    public bool isShoothing;

    void Start()
    {
        amountBulletsCount = objectPool.amountToPool;
        isShoothing = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Custom update logic can be added here.
    }

    /// <summary>
    /// Instantiates bullets from the object pool.
    /// </summary>
    public void InstanceBullets()
    {
        StartCoroutine(Shooting());
    }

    /// <summary>
    /// Coroutine that handles shooting bullets.
    /// </summary>
    /// <returns>Enumerator for yielding WaitForSeconds.</returns>
    IEnumerator Shooting()
    {
        GameObject bulletSpawn = objectPool.GetPoolObject();

        if (bulletSpawn != null)
        {
            bulletSpawn.transform.position = spawnPlaceBullet.transform.position;
            bulletSpawn.transform.rotation = spawnPlaceBullet.transform.rotation;
            bulletSpawn.SetActive(true);
        }

        yield return new WaitForSeconds(respawnTime);
    }
}