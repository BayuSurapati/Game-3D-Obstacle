using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CONGRATS : MonoBehaviour
{
    public static CONGRATS instance;
    public GameObject congrats;
    // Start is called before the first frame update
    void Start()
    {
        congrats.SetActive(true);
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenuQuit()
    {
        SceneManager.LoadScene("MainMenu");
        congrats.SetActive(false);
    }

    public void Retry()
    {
        SceneManager.LoadScene("Level1");
        Destroy(congrats);
        congrats.SetActive(false);
    }
}
