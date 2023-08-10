using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages the movement of an enemy game object.
/// </summary>
public class EnemyMovement : MonoBehaviour
{
    /// <summary>
    /// The velocity at which the enemy moves.
    /// </summary>
    public float velocity;

    void Start()
    {
        //velocity = 1;
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();

        // If the enemy goes too far, deactivate it.
        if (transform.position.z < -90f)
        {
            gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// Moves the enemy based on its velocity.
    /// </summary>
    public void MoveEnemy()
    {
        transform.Translate(new Vector3(0, 0, -1 * velocity));
    }
}