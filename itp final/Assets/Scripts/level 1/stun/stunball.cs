using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stunball : MonoBehaviour
{
    public GameObject stunradius;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Instantiate(stunradius, transform.position, transform.rotation);
            Destroy(this.gameObject);
        } 
    }
}
