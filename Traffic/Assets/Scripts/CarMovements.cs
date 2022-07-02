using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovements : MonoBehaviour
{
    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider rearRight;
    [SerializeField] WheelCollider rearLeft;

    float rayDistance = 1.2f;
    private float currentAcceleration = 50f;
    private float currentBreakForce = 0f;

    private void Update()
    {
        if (Physics.Raycast(transform.position,Vector3.forward,out RaycastHit hitinfo, rayDistance))
        {
            Debug.Log("Hitting Something");
            currentBreakForce = currentAcceleration*10000f;
        }
        else{
            currentBreakForce = 0;
        }

        frontRight.motorTorque = currentAcceleration;
        frontLeft.motorTorque = currentAcceleration;
        rearRight.motorTorque = currentAcceleration;
        rearLeft.motorTorque = currentAcceleration;

        frontRight.brakeTorque = currentBreakForce;
        frontLeft.brakeTorque = currentBreakForce;
        rearRight.brakeTorque = currentBreakForce;
        rearLeft.brakeTorque = currentBreakForce;


    }
}