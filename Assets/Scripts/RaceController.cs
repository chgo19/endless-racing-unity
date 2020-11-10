using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RaceController : MonoBehaviour
{
	bool raceStarted = false;
	GameObject[] AiCars;

	public Material sky14;
	public Light light05;
	public Light light14;

    public GameObject car0;
    public GameObject car1;
    public GameObject carCamera0;
    public GameObject carCamera1;
    public GameObject inputPanel0;
    public GameObject inputPanel1;
    public GameObject dashboard0;
    public GameObject dashboard1;

    public Text LapCount;
    public Text LapCountTotal;
    public Text LapTime;
    public Text BestTime;

    public Text Countdown;
    public GameObject aicar0;
    public GameObject aicar1;

    int lapCount = 0;

    public float milli;
    public int sec;
    public int min;

    public string milliDisplay;
    public string secDisplay;
    public string minDisplay;
    float bestTime = Mathf.Infinity;
    public bool start = true;

    public GameObject LapTrigger;

    void Awake() {
        // set time of day
        if (GameOptions.timeSelection == 1) {
            RenderSettings.skybox = sky14;
            light14.enabled = true;
        } else {
            light05.enabled = true;
        }

        // enable selected car
        if (GameOptions.carSelection == 0) {
            car0.SetActive(true);
            carCamera0.SetActive(true);
            inputPanel0.SetActive(true);
            dashboard0.SetActive(true);
        } else {
            car1.SetActive(true);
            carCamera1.SetActive(true);
            inputPanel1.SetActive(true);
            dashboard1.SetActive(true);
        }

        // enable ai cars
        if(!GameOptions.isRace)
        {
            aicar0.SetActive(false);
            aicar1.SetActive(false);
        }

    }

    void Start() {
        if(GameOptions.isRace && !raceStarted)
        {
            LapCountTotal.text = "/ " + GameOptions.lapCountSelection;
            StartCoroutine(CountDown(0.5f));
            raceStarted = true;
        }
    }

    IEnumerator CountDown(float time) {
        Countdown.text = "Ready!";
        yield return new WaitForSeconds(time);
        Countdown.text = "3";
        yield return new WaitForSeconds(time);
        Countdown.text = "2";
        yield return new WaitForSeconds(time);
        Countdown.text = "1";
        yield return new WaitForSeconds(time);
        Countdown.text = "Start!";
        yield return new WaitForSeconds(time);
        Countdown.text = "";
        
        aicar0.GetComponent<CarAIControl>().enabled = true;
        aicar1.GetComponent<CarAIControl>().enabled = true;
     }

    void Update() {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                GotoMainMenu();
            }
        }

        
        milli += Time.deltaTime * 10;
        
        if (milli >= 10) {
            milli = 0;
            sec += 1;
        }
        if (sec >= 60) {
            sec = 0;
            min += 1;
        }

        milliDisplay = "0" + milli.ToString("F1");

        if (sec < 10) {
            secDisplay = "0" + sec.ToString();
        } else {
            secDisplay = sec.ToString();
        }
        if (min < 10) {
            minDisplay = "0" + min.ToString();
        } else {
            minDisplay = min.ToString();
        }

        LapTime.text = minDisplay + ":" + secDisplay + ":" + milliDisplay;
    }

    public void GotoMainMenu() {
        SceneManager.LoadScene("MainMenu");
    }

    void OnTriggerEnter(Collider body) {

        if (body.name == "JPickup collider" || body.name == "Sport Coupe Collider Base") {
            float totalTime = milli + sec * 10 + min * 60 * 10;
            if (lapCount > 0 && totalTime < bestTime) {
                bestTime = totalTime;
                BestTime.text = LapTime.text;
            }
            lapCount++;
            LapCount.text = lapCount + "";
            milli = 0;
            sec = 0;
            min = 0;
        }
    }
}
