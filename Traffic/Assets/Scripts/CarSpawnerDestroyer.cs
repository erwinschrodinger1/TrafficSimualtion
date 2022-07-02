using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawnerDestroyer : MonoBehaviour
{
    public GameObject car;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            Debug.Log("Here I am ");
            Instantiate(car,transform.position,transform.rotation);
        }
    }
}
