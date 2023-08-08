using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private int HealPoint;
    public float velocity;

    void Start()
    {
        HealPoint = 100;
       // velocity = .5f;
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
        if(transform.position.z < -90f)
        {
            gameObject.SetActive(false);
        }
    }
    public void MoveEnemy()
    {
        this.transform.Translate(new Vector3(0, 0, -1 * velocity));
    }
}
