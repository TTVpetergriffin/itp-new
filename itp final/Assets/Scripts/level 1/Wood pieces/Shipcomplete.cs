using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shipcomplete : MonoBehaviour
{
    public GameObject Escape;
    public GameObject ShipBeacon;
    public GameObject Ship1;
    public GameObject Ship2;
    public GameObject Ship3;
    public GameObject Ship4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Ship1.activeSelf && Ship2.activeSelf && Ship3.activeSelf && Ship4.activeSelf)
        {
            ShipBeacon.SetActive(true);
            Escape.SetActive(true);
        }
    }
}
