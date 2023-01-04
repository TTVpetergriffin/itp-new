using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossPistol : MonoBehaviour
{
    public AudioSource reloadnoise;
    public GameObject bullet;
    public float Ammo;
    public bool shootcd;
    // Start is called before the first frame update
    void Start()
    {
        Ammo = 6;
        shootcd = true;
        reloadnoise = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && Ammo > 0 && shootcd == true)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            shootcd = false;
            StartCoroutine(shootcool());
            Ammo --;
        }
        if (Input.GetKey("r"))
        {
            StartCoroutine(reload());
        }
    }
    IEnumerator shootcool()
    {
        yield return new WaitForSeconds(0.5f);
        shootcd = true;
    }
    IEnumerator reload()
    {
        yield return new WaitForSeconds(1f);
        reloadnoise.Play();
        Ammo = 6f;
    }
}
