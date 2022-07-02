using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBehaviour : MonoBehaviour
{
    public Camera cam1, cam2,cam3,cam4, cam5;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z)){
           switchCam(1);
        }
        if(Input.GetKeyDown(KeyCode.X)){
              switchCam(2);
        }
        if(Input.GetKeyDown(KeyCode.C)){
              switchCam(3);
        }
        if(Input.GetKeyDown(KeyCode.V)){
              switchCam(4);
        }
        if(Input.GetKeyDown(KeyCode.B)){
              switchCam(5);
        }
    }
    void switchCam(int x){
        Debug.Log("Pressed Key! Switched to Cam "+ x+ " this!!" );
        disableAll();
        switch (x){
            case 1:
                cam1.enabled = true;
                break;
            case 2:
                cam2.enabled = true;
                break;
            case 3:
                cam3.enabled = true;
                break;
            case 4:
                cam4.enabled = true;
                break;
            case 5:
                cam5.enabled = true;
                break;
            default :
                cam1.enabled = true;
                break;
        }
    }
    void disableAll(){
        cam1.enabled=false;
        cam2.enabled = false;
        cam3.enabled=false;
        cam4.enabled = false;
        cam5.enabled=false;
    }
}
