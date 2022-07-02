using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovements : MonoBehaviour
{
    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider rearRight;
    [SerializeField] WheelCollider rearLeft;

    float rayDistance = 1.5f;
    private float currentAcceleration;
    private float currentBreakForce = 0f;

    float acceleration = 50f;

    private void Update()
    {
        if (Physics.Raycast(new Vector3(transform.position.x,transform.position.y+0.15f,transform.position.z),Vector3.forward,out RaycastHit hitinfo, rayDistance))
        {
            // Debug.Log("Hitting Something"+currentAcceleration);
            currentBreakForce = 1000f;
        }
        else{
            currentAcceleration = acceleration;
            currentBreakForce = 0;
        }

        frontRight.motorTorque = currentAcceleration;
        frontLeft.motorTorque = currentAcceleration;

        frontRight.brakeTorque = currentBreakForce;
        frontLeft.brakeTorque = currentBreakForce;
        rearRight.brakeTorque = currentBreakForce;
        rearLeft.brakeTorque = currentBreakForce;


    }
}