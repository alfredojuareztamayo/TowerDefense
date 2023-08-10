using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using Unity.VisualScripting;

public class SteeringBehaviour
{
   public Vector3 Seek(Agent agent, Agent targetPosition)
    {
        Vector3 desiredVel = new Vector3(targetPosition.position.x - agent.position.x, targetPosition.position.y - agent.position.y, targetPosition.position.z - agent.position.z);
        desiredVel.Normalize();
        desiredVel *= agent.maxVel;
        Vector3 steering =new Vector3(desiredVel.x - agent.currendtVel.x, desiredVel.y - agent.currendtVel.y, desiredVel.z - agent.currendtVel.z);
        limit(steering, agent.maxForce);
        return steering;
    }
    
    Vector3 limit(Vector3 limitVector, float limit)
    {
        float newMag = limit/limitVector.magnitude;
        limitVector.x *= newMag;
        limitVector.y *= newMag;
        limitVector.z *= newMag;
        return limitVector;  
    }
    Vector3 Flee(Agent agent, Agent targetPosition)
    {
        return (Seek(agent, targetPosition)*-1);
    }
    public void ApplyForce(Agent agent, Vector3 steering)
    {
        agent.currendtVel += steering;
        limit(agent.currendtVel, agent.maxSpeed);
        agent.position+= agent.currendtVel;
    }

}
