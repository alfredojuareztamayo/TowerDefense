using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPooling : MonoBehaviour
{
    
    private float timeToPool;
    public GameObject spawnPlace;
    public ObjectPooling objectPool;
    //private bool activateEnemy;

    //public float velocity;// Start is called before the first frame update
    
    void Start()
    {
       
        timeToPool = 0;
       // activateEnemy = true;
    }

    // Update is called once per frame
    void Update()
    {
        
       // Debug.Log(timeToPool);
       // InstanceEnemys();
    }
   
    public void InstanceEnemys()
    {
       timeToPool += Time.fixedDeltaTime;
       
        GameObject enemyToSpawn = objectPool.GetPoolObject();
        if (timeToPool > 5)
        {
           
            if(enemyToSpawn != null )
            {
                enemyToSpawn.transform.position = spawnPlace.transform.position;
                enemyToSpawn.transform.rotation = spawnPlace.transform.rotation;
                enemyToSpawn.SetActive(true);
                timeToPool = 0;
                //activateEnemy = false;              
            }
           
        }

       
    }
}
