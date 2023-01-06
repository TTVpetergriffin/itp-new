using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI Time;
    private int Seconds;
    // Start is called before the first frame update
    void Start()
    {
        Seconds = 120;
        StartCoroutine(clock());
    }

    // Update is called once per frame
    void Update()
    {
        if(Seconds < 0)
        {
            StopAllCoroutines();
        }
    }
    private void UpdateTime(int TimeToBurn)
    {
        Seconds -= TimeToBurn;
        Time.text = "Time: " + Seconds;
    }
    IEnumerator clock()
    {
        yield return new WaitForSeconds(1);
        UpdateTime(1);
        StartCoroutine(clock());
    }
}
