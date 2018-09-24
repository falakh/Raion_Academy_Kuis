using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public Text highschore;
	// Use this for initialization
	void Start () {
        highschore.text = "High Score : "+PlayerPrefs.GetInt("highScore").ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public  void goPlay(int index)
    {
        SceneManager.LoadSceneAsync(index);
    }
    public void quit()
    {
        Application.Quit();
    }
}
