using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// Manages the behavior and attributes of a bullet.
/// </summary>
public class BulletManager : MonoBehaviour
{
    [Header("Valores de la bala")]

    /// <summary>
    /// The velocity of the bullet.
    /// </summary>
    private float velocityBullet;

    /// <summary>
    /// The amount of damage the bullet can inflict.
    /// </summary>
    public int damage;

    /// <summary>
    /// Reference to the enemy manager for damage calculation.
    /// </summary>
    public EnemyManager enemyManager;

    [Header("valores como agente")]

    /// <summary>
    /// Reference to the steering manager for agent movement.
    /// </summary>
    public SteeringManager steeringManager;

    private Vector3 position;
    private Vector3 currentVel;
    private Vector3 desiredVel;
    private Vector3 steering;

    /// <summary>
    /// The maximum speed the agent can achieve.
    /// </summary>
    public float maxSpeed;

    /// <summary>
    /// The maximum velocity the agent can have.
    /// </summary>
    public float maxVel;

    /// <summary>
    /// The maximum force applied to the agent.
    /// </summary>
    public float maxForce;

    /// <summary>
    /// The mass of the agent.
    /// </summary>
    public float mass;

    /// <summary>
    /// The target the agent seeks.
    /// </summary>
    public GameObject target;

    /// <summary>
    /// The agent's game object.
    /// </summary>
    public GameObject agent;

    /// <summary>
    /// Reference to the perception manager for targeting.
    /// </summary>
    public PerceptionManager perceptionManager;

    void Start()
    {
        position = transform.position;
        currentVel = new Vector3(0, 0, 0);
        desiredVel = new Vector3(0, 0, 0);
        steering = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyManager.actualTarget)
        {
            SeekTarget(perceptionManager.target2);
        }
    }

    /// <summary>
    /// Moves the bullet based on its velocity.
    /// </summary>
    public void MoveBulletTest()
    {
        transform.Translate(new Vector3(0, 0, 1 * velocityBullet));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            enemyManager.SetDamage(damage);
            gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// Seeks the specified target using steering behaviors.
    /// </summary>
    /// <param name="target">The target to seek.</param>
    public void SeekTarget(GameObject target)
    {
        Vector3 newPos = steeringManager.Seek(agent, target.transform.position, maxVel, currentVel, maxForce, mass);
        steeringManager.ApplyForce(agent, newPos, currentVel, maxSpeed);
    }
}