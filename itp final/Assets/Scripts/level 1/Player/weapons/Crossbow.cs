using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Crossbow : MonoBehaviour
{
    public AudioSource reloadnoise;
    public GameObject bullet;
    public int Ammo;
    public bool shootcd;
    public TextMeshProUGUI AmmoText;
    
    // Start is called before the first frame update
    void Start()
    {
        Ammo = 6;
        shootcd = true;
        reloadnoise = GetComponent<AudioSource>();
        UpdateAmmo(0);
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
            UpdateAmmo(0);
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
        Ammo = 6;
        UpdateAmmo(0);
    }
    private void UpdateAmmo(int AmmoToLose)
    {
        Ammo += AmmoToLose;
        AmmoText.text = "Ammo: " + Ammo;
    }
}
