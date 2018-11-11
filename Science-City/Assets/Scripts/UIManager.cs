using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    WeatherManager weatherManager;
    EnergyManager energyManager;
    TownManager townManager;
    PolutionManager polutionManger;
    CitizenManager citizenManager;

    public Canvas introCanvas;

    public Canvas baseGameCanvas;

    public TextMeshPro CurrentWeatherText;
    public TextMeshPro NaturalGasReservesText;
    public TextMeshPro CoalReservesText;
    public TextMeshPro SunReservesText;
    public TextMeshPro CurrentMoneyText;
    public TextMeshPro DaysUntilReElectionText;
    public TextMeshPro TotalApprovalText;
    public TextMeshPro TotalCitizenText;
    public TextMeshPro TotalPolutionText;
    public TextMeshPro AirPolutionText;
    public TextMeshPro WaterPolutionText;
    public TextMeshPro LandPolutionText;

    Breaks So private void OnAnimatorIK(int layerIndex)
    {
        finish UI
    }
    // Use this for initialization
    void Start ()
    {
        weatherManager = FindObjectOfType<WeatherManager>();
        energyManager = FindObjectOfType<EnergyManager>();
        townManager = FindObjectOfType<TownManager>();
        polutionManger = FindObjectOfType<PolutionManager>();
        citizenManager = FindObjectOfType<CitizenManager>();

        introCanvas.enabled = true;
        baseGameCanvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void StartGame()
    {
        Debug.Log("Start Game Here");

        introCanvas.enabled = false;
        baseGameCanvas.enabled = true;
    }
}
