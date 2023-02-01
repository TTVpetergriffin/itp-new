using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stunballspawner : MonoBehaviour
{
    public GameObject Softball;
    public bool canthrow;
    public bool thething;
    public bool thething0;
    public bool danger;
    // Start is called before the first frame update
    void Start()
    {
        danger = GameObject.Find("softballdude").GetComponent<stun>().danger;
        thething = true;
        thething0 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (thething0 == true && thething == true)
        {
            StartCoroutine(Ballin());
            Instantiate(Softball, transform.position, transform.rotation);
            
        }
    }
    private void OnTriggerEnter (Collider trigger)
    {
        if (danger = true)
        {
            thething0 = true;
        }
    }
    IEnumerator Ballin()
    {
        yield return new WaitForSeconds(2);
        thething = false;
        thething0 = false;
        Instantiate(Softball, transform.position, transform.rotation);
        StartCoroutine(Ballin());
    }
}
