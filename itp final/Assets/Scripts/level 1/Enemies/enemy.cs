using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float health;
    // Start is called before the first frame update
    void Start()
    {
        health = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0){
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            health--;
        }
    }
    
}
