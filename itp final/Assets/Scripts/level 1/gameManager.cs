using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject gameover;
    public GameObject player;
    private int health;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        health = GameObject.Find("Main Character").GetComponent<playerController>().health;
        if (health == 0)
        {
            player.SetActive(false);
            gameover.SetActive(true);
        }
    }
}
