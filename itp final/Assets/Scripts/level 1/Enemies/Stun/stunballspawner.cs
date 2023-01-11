using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stunballspawner : MonoBehaviour
{
    public bool danger;
    public GameObject Softball;
    public bool canthrow;
    // Start is called before the first frame update
    void Start()
    {
        canthrow = true;
    }

    // Update is called once per frame
    void Update()
    {
        danger = GameObject.Find("softballdude").GetComponent<stun>().danger;
        if (danger == true)
        {
            StartCoroutine(Ballin());
        }
    }
    IEnumerator Ballin()
    {
        yield return new WaitForSeconds(0);
        Instantiate(Softball, transform.position, transform.rotation);
        canthrow = false;
        StartCoroutine(Cooldown());
    }
    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(2);
        canthrow = true;
    }
}
