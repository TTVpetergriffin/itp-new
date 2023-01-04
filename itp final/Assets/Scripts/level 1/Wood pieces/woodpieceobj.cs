using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woodpieceobj : MonoBehaviour
{
    public GameObject Woodpiece1;
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
        if (collision.gameObject.tag == "Player")
        {
            Woodpiece1.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
