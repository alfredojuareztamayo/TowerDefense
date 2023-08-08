using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsPool : MonoBehaviour
{
    private float timeToPoolBullet;
    public GameObject spawnPlaceBullet;
    public ObjectPooling objectPool;
    public float respawnTime;
    
    void Start()
    {
        timeToPoolBullet = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(timeToPoolBullet);
       // InstanceBullets();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entra en la zona");
    }
    public void InstanceBullets()
    {
        timeToPoolBullet += Time.fixedDeltaTime;
        GameObject bulletSpawn = objectPool.GetPoolObject();
        if (timeToPoolBullet > respawnTime)
        {
            if (bulletSpawn != null)
            {
                bulletSpawn.transform.position = spawnPlaceBullet.transform.position;
                bulletSpawn.SetActive(true);
                timeToPoolBullet = 0;
            }
        }

    }
}
