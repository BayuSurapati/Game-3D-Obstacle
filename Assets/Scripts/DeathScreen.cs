using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public static DeathScreen instance;
    public GameObject deathScreen;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        deathScreen.SetActive(false);
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenuQuit()
    {
        SceneManager.LoadScene("MainMenu");
        deathScreen.SetActive(false);
    }

    public void Retry()
    {
        SceneManager.LoadScene("Level1");
        Destroy(deathScreen);
        deathScreen.SetActive(false);
    }
}
