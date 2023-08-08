using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    private float velocityBullet;
    private float timeRespawn;
    public int damage;
    void Start()
    {
        velocityBullet = 3f;
        timeRespawn = 0;
    }

    // Update is called once per frame
    void Update()
    {
        MoveBulletTest();
        timeRespawn += Time.fixedDeltaTime;
        if(timeRespawn > 10f)
        {
            gameObject.SetActive(false);
            timeRespawn = 0;
        }
        
    }
    public void MoveBulletTest()
    {
        this.transform.Translate(new Vector3(0, 0, 1 * velocityBullet));
    }
}
