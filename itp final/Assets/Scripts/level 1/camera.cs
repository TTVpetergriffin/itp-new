using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public float horizontalInput;
    public float forwardInput;
    public float sens;
    void Start()
    {
        sens = 5;
    }
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //right so the goal here is to get the camera movin  
        transform.Rotate(Vector3.left * Time.deltaTime * sens * forwardInput);
        //transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}

