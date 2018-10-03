using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolutionManager : MonoBehaviour
{

    //Types of Polution Air, Water, Land

    int MaxPolution = 200;

    int MaxAirPolution = 100;
    int MaxWaterPolution = 100;
    int MaxLandPolution = 100;

    int CurrentPolution = 0;

    int CurrentAirPolution = 0;
    int CurrentWaterPolution = 0;
    int CurrentLandPolution = 0;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        TotalPolutionLevels();
        CheckPolutionLevels();
	}

    void TotalPolutionLevels()
    {
        CurrentPolution = CurrentAirPolution + CurrentLandPolution + CurrentWaterPolution;
    }

    void CheckPolutionLevels()
    {
        if(CurrentPolution >= MaxPolution)
        {
            Debug.Log("Current Polution is to High Dead");
        }

        if(CurrentAirPolution >= MaxAirPolution)
        {
            Debug.Log("Current Air Polution is To High Dead");
        }

        if(CurrentLandPolution >= MaxLandPolution)
        {
            Debug.Log("Current Land Polution is To High Dead");
        }

        if(CurrentWaterPolution >= MaxWaterPolution)
        {
            Debug.Log("Current Water Polution is To High Dead");
        }
    }

    public void AddPolution(int PolutionAmount, string PolutionType)
    {
        switch(PolutionType)
        {
            case "Air":
                CurrentAirPolution += PolutionAmount;
                break;
            case "Water":
                CurrentWaterPolution += PolutionAmount;
                break;
            case "Land":
                CurrentLandPolution += PolutionAmount;
                break;
            default:
                Debug.Log("Wrong Polution Type has Been Sent to Polution Manager");
                break;
        }

        CurrentPolution += PolutionAmount;
    }
}
