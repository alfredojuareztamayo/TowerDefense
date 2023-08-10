using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
/// <summary>
/// Manages the perception and targeting of enemies for attack.
/// </summary>
public class PerceptionManager : MonoBehaviour
{

    public BulletsPool bullets;
    /// <summary>
    /// The pool of bullets available for attack.
    /// </summary>
    private int amountBullets;
    /// <summary>
    /// List of colliders for enemies detected by perception.
    /// </summary>
    public List<Collider> enemysColliders = new List<Collider>();
    /// <summary>
    /// The secondary target object for enemies.
    /// </summary>
    public GameObject target2;

    private void Start()
    {
        amountBullets = bullets.amountBulletsCount;
    }

    private void Update()
    {
        
    }
    /// <summary>
    /// Called when another collider enters the trigger collider of this object.
    /// </summary>
    /// <param //name="other">The collider of the object that entered the trigger.</param>
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
           enemysColliders.Add(other);
           EnemyManager enemyManager = other.GetComponent<EnemyManager>();
           // BulletManager bulletManager =
            if (enemyManager)
            {
                enemyManager.actualTarget = true;
                enemyManager.isAlive = true;
                target2 = other.gameObject;

                while (amountBullets > 0 && enemyManager.isAlive)
                {
                    StartCoroutine(StartAttack());
                    //bullets.InstanceBullets();
                    //amountBullets--;
                }
                amountBullets = bullets.amountBulletsCount;
            }
            
            
           
           // bullets.InstanceBullets();
           
        }
        
    }
    /// <summary>
    /// Called when another collider exits the trigger collider of this object.
    /// </summary>
    /// <param //name ="other">The collider of the object that exited the trigger.</param>

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Enemy")
        {
            enemysColliders.Remove(other);
           
        }
    }

    /// <summary>
    /// Coroutine that performs the attack action.
    /// </summary>
    /// <returns>Enumerator for yielding WaitForSeconds.</returns>
    IEnumerator StartAttack()
    {
       
        bullets.InstanceBullets();
        amountBullets--;
        yield return new WaitForSeconds(1f);

    }

}
