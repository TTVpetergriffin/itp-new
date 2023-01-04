using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaser : MonoBehaviour
{
    public float speed;
    public float health;
    private Rigidbody enemyRb;
    private GameObject player;
    public bool danger;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1;
        health = 2f;
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Main Character");
        danger = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            Destroy(this.gameObject);
        }
     if (danger == true)
        {
            Vector3 lookDirection = (player.transform.position - transform.position).normalized;
            enemyRb.AddForce(lookDirection * speed);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            health--;
        }
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(hitstop());
        }
    }
    private void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.tag == "aoe")
        {
            danger = true;
        }
    }
    IEnumerator hitstop()
    {
        yield return new WaitForSeconds(0);
        speed = 0;
        StartCoroutine(hitrecovery());
    }
    IEnumerator hitrecovery()
    {
        yield return new WaitForSeconds(2);
        speed = 1;
    }
}
