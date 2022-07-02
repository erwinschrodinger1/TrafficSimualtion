using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDespawner : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "cars"){
            Debug.Log("Car Colided");
            Destroy(other.gameObject);
        }
    }
}
