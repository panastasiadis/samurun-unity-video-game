using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public Text highscoreText;

    // Start is called before the first frame update
    void Start()
    {
        highscoreText.text = "Highscore: " + ((int)PlayerPrefs.GetFloat("Highscore"));
    }

    // Update is called once per frame

    public void ToGame()
    {
        SceneManager.LoadScene("3d_endless_runner");
    }

    public void ExitApplication()
    {
        Application.Quit();
    }
}
