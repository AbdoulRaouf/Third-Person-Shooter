using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAiming : MonoBehaviour
{
    float turnSpeed=15f;
    Camera mainCamera;
    void Start()
    {
        mainCamera=Camera.main;
        Cursor.visible=false;
        Cursor.lockState=CursorLockMode.Locked;
    }

    void FixedUpdate()
    {
        float CamAngle=mainCamera.transform.rotation.eulerAngles.y;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, CamAngle, 0),turnSpeed*Time.fixedDeltaTime);
    }
}
