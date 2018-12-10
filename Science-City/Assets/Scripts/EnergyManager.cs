using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyManager : MonoBehaviour
{
    WeatherManager weatherManager;
    PolutionManager polutionManager;


    public NaturalGas naturalGas;
    public Coal coal;
    public Solar solar;

    public float CoalAmount = 100;
    public float NaturalGasAmount = 100;

    public float SolarAmount = 0;

    public enum CurrentEnergy { Coal, Gas, Solar};
    public CurrentEnergy energy;

	// Use this for initialization
	void Start ()
    {
        weatherManager = FindObjectOfType<WeatherManager>();

        if (weatherManager == null)
        {
            Debug.Log("No Weather Manager was Found");
        }

        polutionManager = FindObjectOfType<PolutionManager>();

        if (polutionManager == null)
        {
            Debug.Log("No Polution Manager was Found");
        }

        energy = CurrentEnergy.Coal;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void GenerateSolarEnergy()
    {
        if(weatherManager.TodaysWeather == WeatherManager.TypesOfDays.Sunny)
        {
            SolarAmount += solar.amountOfSolarPanel * .0001f;
        }
    }

    public void ChangeActivateEnergy()
    {
        switch(energy)
        {
            case CurrentEnergy.Coal:
                energy = CurrentEnergy.Gas;
                polutionManager.AddPolution(.01f, "Air");
                polutionManager.AddPolution(.005f, "Land");
                break;
            case CurrentEnergy.Gas:
                polutionManager.AddPolution(.02f, "Air");
                energy = CurrentEnergy.Solar;
                break;
            case CurrentEnergy.Solar:
                energy = CurrentEnergy.Coal;
                break;
            default:
                break;
        }
    }
}
