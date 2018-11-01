using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerDisplay : MonoBehaviour {
    public Text timerText;
    public float startTime;
    public CatPlayer theCat;
    private float offTheScreen = -14f;
    private float timeToStopTheGame = 34f; //34 seconds

	void Start () {
        startTime = Time.time;
	}
	
	void Update () {
        float t = Time.time - startTime;
        if (theCat.transform.position.y < offTheScreen)
        {
            Invoke("GameEndFail", 3f);
        }
        else
        {
            string minute = ((int)t / 60).ToString();
            string second = (t % 60).ToString("f2");
            timerText.text = minute + ":" + second;
            if(t> timeToStopTheGame){
                timerText.color = Color.magenta;
                timerText.text = "ALL RIGHT! YOU'RE ALMOST HOME";
                Invoke("GameEndSuccess", 2f);
            }
        }
    }

    void GameEndSuccess(){
        SceneManager.LoadScene("_Scene_2");
    }

    void GameEndFail(){
        Destroy(theCat);
        SceneManager.LoadScene("_Scene_1");
    }
       
}
