using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public Text highScore;

	// Use this for initialization
	void Start () {
        highScore.text = "High Score : " + PlayerPrefs.GetInt("highScore").ToString();
	}
	
    public void goPlay(string levelName)
    {
        SceneManager.LoadSceneAsync(levelName);
    }

    public void quit()
    {
        Application.Quit();
    }

}
