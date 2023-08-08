using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private int HealPoint;
    private float timeToPool;
    public GameObject spawnPlace;
    private bool activateEnemy;

    public float velocity;// Start is called before the first frame update
    
    void Start()
    {
        HealPoint = 100;
        timeToPool = 0;
        activateEnemy = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log(timeToPool);
        InstanceEnemys();
    }
   
    public void InstanceEnemys()
    {
       timeToPool += Time.deltaTime;
       
        GameObject enemyToSpawn = EnemyPooling.SharedInstance.GetPoolEnemy();
        if (timeToPool > 5 && activateEnemy)
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
