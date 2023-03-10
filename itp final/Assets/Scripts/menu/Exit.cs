using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public GameObject helper;
    public GameObject menu;
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Quit);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Quit()
    {
        Debug.Log(gameObject.name + " was clicked");
        Application.Quit();
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void start()
    {
        SceneManager.LoadScene("TESTING TESTING");
    }
    public void Help()
    {
        helper.SetActive(true);
        menu.SetActive(false);
    }
    public void menuload()
    {
        helper.SetActive(false);
        menu.SetActive(true);
    }
    public void Titlereturn()
    {
        SceneManager.LoadScene("Title");
    }
    public void Level2()
    {
        SceneManager.LoadScene("level 2");
    }
}