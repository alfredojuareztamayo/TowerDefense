using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringManager : MonoBehaviour
{
  
  public Vector3 Seek(GameObject agent, Vector3 posTarget, float maxVel, Vector3 currentVel, float maxForce,float mass)
    {
        Vector3 desiredVel = posTarget - agent.transform.position;
        desiredVel.Normalize();
        desiredVel *= maxVel;
        Vector3 steering = desiredVel - currentVel;
        Limit(steering, maxForce);
        steering /= mass;
        return steering;

    }
    Vector3 Limit(Vector3 limitVector, float limit)
    {
        float newMag = limit / limitVector.magnitude;
        limitVector.x *= newMag;
        limitVector.y *= newMag;
        limitVector.z *= newMag;
        return limitVector;
    }

    public void ApplyForce(GameObject agent ,Vector3 steering, Vector3 currentVel, float maxSpeed)
    {
        currentVel += steering;
        Limit(currentVel, maxSpeed);
        agent.transform.position += currentVel;
    }
}
