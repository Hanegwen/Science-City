using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    WeatherManager weatherManager;
    EnergyManager energyManager;
    TownManager townManager;
    PolutionManager polutionManger;
    CitizenManager citizenManager;

    public Canvas introCanvas;
    public Canvas startCanvas;
    public Canvas baseGameCanvas;

    
    public TextMeshProUGUI CurrentWeatherText;
    public TextMeshProUGUI NaturalGasReservesText;
    public TextMeshProUGUI CoalReservesText;
    public TextMeshProUGUI SunReservesText;
    public TextMeshProUGUI CurrentMoneyText;
    public TextMeshProUGUI DaysUntilReElectionText;
    public TextMeshProUGUI TotalApprovalText;
    public TextMeshProUGUI TotalCitizenText;
    public TextMeshProUGUI TotalPolutionText;
    public TextMeshProUGUI AirPolutionText;
    public TextMeshProUGUI WaterPolutionText;
    public TextMeshProUGUI LandPolutionText;



    public GameObject polutionPanel;
    public GameObject resourcePanel;
    public GameObject defaultPanel;
    public GameObject buttonPanel;

    public InputField NameField;

    string mayorName;

    //Manual Because Bugs
    //public GameObject PolutionAButton;
    //public GameObject ResourceAButton;

    // Use this for initialization
    void Start ()
    {
        weatherManager = FindObjectOfType<WeatherManager>();
        energyManager = FindObjectOfType<EnergyManager>();
        townManager = FindObjectOfType<TownManager>();
        polutionManger = FindObjectOfType<PolutionManager>();
        citizenManager = FindObjectOfType<CitizenManager>();

        introCanvas.enabled = true;
        startCanvas.enabled = false;
        baseGameCanvas.enabled = false;

        polutionPanel.SetActive(false);
        resourcePanel.SetActive(false);
        buttonPanel.SetActive(false);
        defaultPanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
        UITextUpdate();
	}

    public void QuitButton()
    {
        Application.Quit();
    }

    public void PolutionButton()
    {
        polutionPanel.SetActive(true);
        resourcePanel.SetActive(false);
    }

    public void ResourceButton()
    {
        resourcePanel.SetActive(true);
        polutionPanel.SetActive(false);
    }

    public void BeginGameButton()
    {
        startCanvas.enabled = false;
        baseGameCanvas.enabled = true;
        defaultPanel.SetActive(true);
        buttonPanel.SetActive(true);

        mayorName = NameField.text;
        townManager.gameHasBegun = true;
    }

    public void ToggleResourceButton()
    {

    }

    public void StartGame()
    {
        Debug.Log("Start Game Here");

        introCanvas.enabled = false;
        startCanvas.enabled = true;
        baseGameCanvas.enabled = false;
        


        ////For Fixing Bugs
        //PolutionAButton.SetActive(true);
        //ResourceAButton.SetActive(true);
        
    }

    void UITextUpdate()
    {
        CurrentWeatherText.text = "Current Weather: " + weatherManager.TodaysWeather;
        Debug.Log(CurrentWeatherText.text);
        NaturalGasReservesText.text = "Natural Gas: " + energyManager.NaturalGasAmount;
        Debug.Log(NaturalGasReservesText.text);
        CoalReservesText.text = "Coal: " + energyManager.CoalAmount;
        Debug.Log(CoalReservesText.text);
        SunReservesText.text = "Solar Reserves: " + energyManager.SolarAmount;
        Debug.Log(SunReservesText.text);
        CurrentMoneyText.text = "Current Money: " + townManager.Money;
        Debug.Log(CurrentMoneyText.text);
        DaysUntilReElectionText.text = "Days Until ReElection: " + townManager.DaysUntilReElection;
        Debug.Log(DaysUntilReElectionText.text);
        TotalApprovalText.text = "Total Approval: " + citizenManager.totalHapinessOfTown;
        Debug.Log(TotalApprovalText.text);
        TotalCitizenText.text = "Total Population: " + citizenManager.totalCitizens.Count;
        Debug.Log(TotalCitizenText.text);
        TotalPolutionText.text = "Total Polution: " + polutionManger.CurrentPolution;
        Debug.Log(TotalPolutionText.text);
        AirPolutionText.text = "Air Polution: " + polutionManger.CurrentAirPolution;
        Debug.Log(AirPolutionText.text);
        WaterPolutionText.text = "Water Polution: " + polutionManger.CurrentWaterPolution;
        Debug.Log(WaterPolutionText.text);
        LandPolutionText.text = "Land Polution: " + polutionManger.CurrentLandPolution;
        Debug.Log(LandPolutionText.text);
    }
}
