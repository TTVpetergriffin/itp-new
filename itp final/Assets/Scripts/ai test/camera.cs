using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public float sensitivity = 2f;
    public float clampAngle = 80f;

    private float rotY = 0f;
    private float rotX = 0f;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = -Input.GetAxis("Mouse Y");

        rotY += mouseX * sensitivity;
        rotX += mouseY * sensitivity;

        rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);

        transform.rotation = Quaternion.Euler(rotX, rotY, 0);
    }
}

