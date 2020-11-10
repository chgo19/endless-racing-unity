using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//track default y -0.666473
public class GameOptions : MonoBehaviour
{
    public static int carSelection = 0;
    public static int timeSelection = 0;
    public static int lapCountSelection = 5;
    public static bool isRace;

    int trackSelection = 0;

    public void OnStartRaceButtonClick() {
    	isRace = true;
    	ChangeScene();
    }

    public void OnStartPracticeButtonClick() {
    	isRace = false;
    	ChangeScene();
    }

    public void OnCarSelection(int val) {
    	carSelection = val;
    	Debug.Log("car: " + carSelection);
    }

    public void OnTrackSelection(int val) {
    	trackSelection = val;
    	Debug.Log("track: " + trackSelection);
    }

    public void OnTimeSelection(int val) {
    	timeSelection = val;
    	Debug.Log("time: " + timeSelection);
    }

    public void OnLapCountSelection(float val) {
    	lapCountSelection = (int) val;
    	Debug.Log("laps: " + lapCountSelection);
    }

    void ChangeScene() {
    	if (trackSelection == 0) {
    		// Debug.Log("im here");
    		SceneManager.LoadScene("SampleScene");
    	} else if (trackSelection == 1) {
    		SceneManager.LoadScene("Shmider");
    	}
    }

}
