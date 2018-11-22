using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownManager : MonoBehaviour
{
    //https://www.eia.gov/tools/faqs/faq.php?id=97&t=3

    //.03 Megawatt per citizen

    public bool gameHasBegun = false;

    CitizenManager citizenManager;
    EnergyManager energyManager;
    PolutionManager polutionManager;
    WeatherManager weatherManager;

    float CitizenEnergyUsage = .03f;

    public int DaysUntilReElection = 300;

    public float Money = 100;


    enum FavoriteEnergy { Coal, NaturalGas, Nuclear, Solar}
    FavoriteEnergy townsFavroiteEnergy;

    bool continueTimeCycle = true;
	// Use this for initialization
	void Start ()
    {
        

        citizenManager = FindObjectOfType<CitizenManager>();

        if(citizenManager == null)
        {
            Debug.Log("No Citizen Manager was Found");
        }

        energyManager = FindObjectOfType<EnergyManager>();

        if(energyManager == null)
        {
            Debug.Log("No Energy Manager was Found");
        }

        polutionManager = FindObjectOfType<PolutionManager>();

        if(polutionManager == null)
        {
            Debug.Log("No Polution Manager was Found");
        }

        weatherManager = FindObjectOfType<WeatherManager>();

        if(weatherManager == null)
        {
            Debug.Log("No Weather Manager was Found");
        }

        
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (gameHasBegun)
        {
            Debug.Log("Continue Time Cycle Bool: " + continueTimeCycle);
            if (continueTimeCycle)
            {
                MinusDays();
            }

            Loose();

            if (energyManager == null)
            {
                Debug.Log("Energy Manager Catch");
            }

            if (DaysUntilReElection == 0)
            {
                ReElectionDecision();
            }
        }
	}

    void MinusDays()
    {
        weatherManager.ChangeWeather();
        StartCoroutine(MakeSeconds(1));
    }

    void ReElectionDecision()
    {
        if(true) // Pass ReElection
        {

        }
        else // Fail ReElection
        {

        }
    }

    void UseEnergy()
    {
        if(energyManager.NaturalGasAmount > CitizenEnergyUsage * citizenManager.totalCitizens.Capacity)
        {
            Money -= energyManager.naturalGas.CostOfMegawattHour * CitizenEnergyUsage * citizenManager.totalCitizens.Capacity;
            float UsedMegawattHour = CitizenEnergyUsage * citizenManager.totalCitizens.Capacity;

            energyManager.NaturalGasAmount -= UsedMegawattHour;
        }

        if(energyManager.CoalAmount > CitizenEnergyUsage * citizenManager.totalCitizens.Capacity)
        {
            Money -= energyManager.coal.CostOfMegawattHour * CitizenEnergyUsage * citizenManager.totalCitizens.Capacity;
            float UsedMegawattHour = CitizenEnergyUsage * citizenManager.totalCitizens.Capacity;

            energyManager.CoalAmount -= UsedMegawattHour;
        }

        if(energyManager.SolarAmount > CitizenEnergyUsage * citizenManager.totalCitizens.Capacity)
        {
            Money -= energyManager.solar.CostOfMegawattHour * CitizenEnergyUsage * citizenManager.totalCitizens.Capacity;

            float UsedMegawattHour = CitizenEnergyUsage * citizenManager.totalCitizens.Capacity;

            energyManager.SolarAmount -= UsedMegawattHour;
        }
    }

    

    void Loose()
    {
        if(citizenManager.SetHappinessOfCitizens() == 0)
        {
            Debug.Log("Town Hapiness is 0");
        }

        if(citizenManager.totalCitizens.Count == 0)
        {
            Debug.Log("There are no Citizens");
        }
    }
   

    IEnumerator MakeSeconds (int secondCount)
    {
        continueTimeCycle = false;
        
        Debug.Log("Time has Passed");
        yield return new WaitForSeconds(secondCount);
        continueTimeCycle = true;


        DaysUntilReElection--;

        UseEnergy();
        

        //StartCoroutine(MakeSeconds(1));
        //MinusDays();
    }
}
