using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thestunradius : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(timer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator timer()
    {
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
    }
}
