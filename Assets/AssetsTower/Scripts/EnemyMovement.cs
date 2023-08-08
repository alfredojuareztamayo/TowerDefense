using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float velocity;
    void Start()
    {
        //velocity = 1;
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
