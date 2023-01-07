using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public float speed = 5f;
    public float distanceToGround = 0.5f;
    public LayerMask groundLayers;
    public GameObject movementPlane;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, -Vector3.up, out hit, distanceToGround, groundLayers))
        {
            movementPlane.transform.position = hit.point;
            movementPlane.transform.rotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Camera.main.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= Camera.main.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= Camera.main.transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Camera.main.transform.right * speed * Time.deltaTime;
        }
    }
}
