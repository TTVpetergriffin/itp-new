using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class victory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider Trigger)
    {
        if (Trigger.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Lvl1done");
        }
    }
}
