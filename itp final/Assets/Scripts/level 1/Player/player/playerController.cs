using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    public float speed;
    public int health;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;
    public TextMeshProUGUI healthText;
    public bool tomfoolery;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        health = 3;
        UpdateHealth(0);
        tomfoolery = false;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //right so the goal here is to get noah movin  
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        if(tomfoolery == true)
        {
            speed = 1;
        }
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
            UpdateHealth(0);
        }
    }
    private void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.tag == "5g")
        {
            speed = 1;
            tomfoolery = true;
        }
        if (trigger.gameObject.tag == "5gsoftball")
        {
            speed = 1;
            StartCoroutine(Soaft());
        }
    }
    private void OnTriggerExit(Collider trigger)
    {
        if (trigger.gameObject.tag == "5g")
        {
            speed = 5;
            tomfoolery = false;
        }
    }
    private void UpdateHealth(int healthToSteal)
    {
        health += healthToSteal;
        healthText.text = "Health: " + health;
    }
    IEnumerator Soaft()
    {
        yield return new WaitForSeconds(2);
        speed = 5;
    }
}

