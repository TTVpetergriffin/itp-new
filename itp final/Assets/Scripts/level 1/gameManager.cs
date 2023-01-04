using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject gameover;
    public float Health;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Health = GameObject.Find("Main Character").GetComponent<playerController>().health;
        if (Health == 0)
        {
            player.SetActive(false);
            gameover.SetActive(true);
        }
    }
}
