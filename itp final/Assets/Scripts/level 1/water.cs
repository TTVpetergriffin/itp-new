using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
    private bool BeterBriffin;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        BeterBriffin = true;
        speed = 15;
    }

    // Update is called once per frame
    void Update()
    {
        if(BeterBriffin = true)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
