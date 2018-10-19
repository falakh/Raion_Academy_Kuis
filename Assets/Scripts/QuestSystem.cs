using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[DisallowMultipleComponent]
public class QuestSystem : MonoBehaviour {
    public Soal[] data;
    public Text score;
    public Text soal;
    private Soal currentSoal;
    private static List<Soal> soalList;
    private static int poin;

    private void Start()
    {
        score.text = "Score : " + poin.ToString();
        if(soalList==null || soalList.Count < 1)
        {
            soalList = new List<Soal>(data);
        }
        int index = Random.Range(0, soalList.Count);
        currentSoal = soalList[index];
        soal.text = currentSoal.soalString;
        soalList.RemoveAt(index);
    }

    public void Answer(bool answer)
    {
        if (answer == currentSoal.answer)
        {
            poin++;
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex,LoadSceneMode.Single);
        }
        else
        {
            if (PlayerPrefs.HasKey("highScore"))
            {
                if (poin > PlayerPrefs.GetInt("highScore"))
                {
                    PlayerPrefs.SetInt("highScore", poin);
                }
            }
            else
            {
                PlayerPrefs.SetInt("highScore", poin);
            }
            SceneManager.LoadSceneAsync("Main Menu",LoadSceneMode.Single);
        }
    }
}
