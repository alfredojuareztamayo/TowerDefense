using System.Collections;
using System.Collections.Generic;
//using System.Net;
using UnityEngine;

/// <summary>
/// Manages the behavior and attributes of an enemy.
/// </summary>
public class EnemyManager : MonoBehaviour
{
    /// <summary>
    /// The current health points of the enemy.
    /// </summary>
    public int healPoint;

    /// <summary>
    /// The maximum health points the enemy can have.
    /// </summary>
    public int maxHeal = 100;

    /// <summary>
    /// The velocity at which the enemy moves.
    /// </summary>
    public float velocity;

    /// <summary>
    /// Indicates whether the enemy is alive or not.
    /// </summary>
    public bool isAlive;

    /// <summary>
    /// Indicates whether the enemy is the actual target.
    /// </summary>
    public bool actualTarget;

    /// <summary>
    /// Initializes the enemy's attributes and properties.
    /// </summary>
    void Start()
    {
        healPoint = maxHeal;
        isAlive = true;
        actualTarget = false;
    }

    /// <summary>
    /// Updates the enemy's behavior and state each frame.
    /// </summary>
    void Update()
    {
        MoveEnemy();

        if (Input.GetKeyDown(KeyCode.D))
        {
            SetDamage(10);
        }

        if (healPoint < 0)
        {
            isAlive = false;
            gameObject.SetActive(false);
        }

        if (transform.position.z < -25f)
        {
            isAlive = false;
            gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// Inflicts damage to the enemy's health.
    /// </summary>
    /// <param name="damage">The amount of damage to apply.</param>
    public void SetDamage(int damage)
    {
        healPoint -= damage;
    }

    /// <summary>
    /// Retrieves the current health of the enemy.
    /// </summary>
    /// <returns>The current health points of the enemy.</returns>
    public int GetHealt()
    {
        return healPoint;
    }

    /// <summary>
    /// Moves the enemy forward based on its velocity.
    /// </summary>
    public void MoveEnemy()
    {
        transform.Translate(new Vector3(0, 0, -1 * velocity));
    }
}