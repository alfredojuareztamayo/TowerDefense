//using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public enum AgentState
//{
//    None,
//    Seek,
//    Flee,
//    Wander
//}

public class Agent 
{
    public Vector3 position;
    public Vector3 currendtVel;
    public Vector3 desiredVel;
    public Vector3 steering;
    public float maxSpeed; 
    public float maxVel;
    public float maxForce;
    public float mass;
    Agent target;
    public SteeringBehaviour sb;

    public Agent(Vector3 pos, float maxSpd, float maxV, float maxF, float mss)
    {
        position = pos;
        currendtVel = new Vector3(0, 0, 0);
        desiredVel = new Vector3(0, 0,0);
        steering = new Vector3(0, 0, 0);
        maxSpeed = maxSpd;
        maxVel = maxV;
        maxForce = maxF;
        mass = mss;
        target = null;
        sb = new SteeringBehaviour();

    }
    
    public void SetTarget(Agent t)
    {
        target = t;
    }
    public Agent GetTarget() { return target; }

    

}
