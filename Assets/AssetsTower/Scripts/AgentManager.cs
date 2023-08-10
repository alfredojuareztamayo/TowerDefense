using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
   public BulletManager bulletManager;
   public SteeringManager steeringManager;

   private Vector3 position;
   private Vector3 currentVel;
   private Vector3 desiredVel;
   private Vector3 steering;
   private float maxSpeed;
   private float maxVel;
   private float maxForce;
   private float mass;

}
