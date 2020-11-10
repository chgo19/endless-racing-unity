using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{
	public GameObject RaceModeTitle;
	public GameObject RaceModeDescription;
	public GameObject SelectCarLabel;
	public GameObject CarDropdown;
	public GameObject SelectTrackLabel;
	public GameObject TrackDropdown;
	public GameObject SelectSceneryLabel;
	public GameObject SceneryDropdown;
	public GameObject SelectLapCountLabel;
	public GameObject StartRaceButton;
	public GameObject LapCountSlider;
	public GameObject LapCountText;
	public GameObject PracticeModeTitle;
	public GameObject PracticeModeDescription;
	public GameObject StartPracticeButton;
	public GameObject CreditsText;
	public GameObject CreditsTitle;
	public GameObject StartImage;

    public void OnRaceButtonClick() {
    	HideAll();
    	RaceModeTitle.SetActive(true);
    	RaceModeDescription.SetActive(true);
    	SelectCarLabel.SetActive(true);
    	CarDropdown.SetActive(true);
    	SelectTrackLabel.SetActive(true);
    	TrackDropdown.SetActive(true);
    	SelectSceneryLabel.SetActive(true);
    	SceneryDropdown.SetActive(true);
    	SelectLapCountLabel.SetActive(true);
    	LapCountSlider.SetActive(true);
    	LapCountText.SetActive(true);
    	StartRaceButton.SetActive(true);
    }

    public void OnPracticeButtonClick() {
    	HideAll();
    	PracticeModeTitle.SetActive(true);
    	PracticeModeDescription.SetActive(true);
    	SelectCarLabel.SetActive(true);
    	CarDropdown.SetActive(true);
    	SelectTrackLabel.SetActive(true);
    	TrackDropdown.SetActive(true);
    	SelectSceneryLabel.SetActive(true);
    	SceneryDropdown.SetActive(true);
    	StartPracticeButton.SetActive(true);
    }

    public void OnCreditsButtonClick() {
    	HideAll();
    	CreditsTitle.SetActive(true);
    	CreditsText.SetActive(true);
    }

    public void OnQuitButtonClick() {
    	Application.Quit();
    }

    public void OnLapCountChange(float val) {
    	LapCountText.GetComponent<Text>().text = val + ""; 
    }

    void HideAll() {
    	StartImage.SetActive(false);
    	RaceModeTitle.SetActive(false);
    	RaceModeDescription.SetActive(false);
    	SelectCarLabel.SetActive(false);
    	CarDropdown.SetActive(false);
    	SelectTrackLabel.SetActive(false);
    	TrackDropdown.SetActive(false);
    	SelectSceneryLabel.SetActive(false);
    	SceneryDropdown.SetActive(false);
    	SelectLapCountLabel.SetActive(false);
    	LapCountSlider.SetActive(false);
    	LapCountText.SetActive(false);
    	StartRaceButton.SetActive(false);
    	PracticeModeTitle.SetActive(false);
    	PracticeModeDescription.SetActive(false);
    	StartPracticeButton.SetActive(false);
    	CreditsTitle.SetActive(false);
    	CreditsText.SetActive(false);
    }
}
