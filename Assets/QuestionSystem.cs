using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestionSystem : MonoBehaviour {
    public Soal[] data;
    public Text score;
    public Text soal;
    private Soal current;
    private static List<Soal> soalList;
    private static int poin;
	// Use this for initialization
	void Start () {
        score.text = "Score : "+poin.ToString();
        if (soalList == null ||  soalList.Count<=1)
        {
            soalList = new List<Soal>(data);
            Debug.Log(soalList.Count);
        }
        int index = Random.Range(0, soalList.Count-1);
        current = soalList[Mathf.Clamp(index, 0, data.Length)];
        soal.text = current.soal;
        soalList.RemoveAt(index);
        Debug.Log(soalList.Count);
	}
	
    public void answer(bool answer)
    {
        Debug.Log(answer);

        if(answer == current.answer)
        {
            poin += 1;
            
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex,LoadSceneMode.Single);
        }
        else
        {
          //  PlayerPrefs.SetInt("highScore : ", poin);
            SceneManager.LoadSceneAsync(0,LoadSceneMode.Single);
          
    
        }
    
   
    
    }
	
}
