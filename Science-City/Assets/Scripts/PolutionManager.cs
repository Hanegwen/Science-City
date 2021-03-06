﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolutionManager : MonoBehaviour
{

    //Types of Polution Air, Water, Land

    public int MaxPolution = 2;

    public int MaxAirPolution = 1;
    public int MaxWaterPolution = 1;
    public int MaxLandPolution = 1;

    public float CurrentPolution = 0;

    public float CurrentAirPolution = 0;
    public float CurrentWaterPolution = 0;
    public float CurrentLandPolution = 0;

    UIManager uIManager;

    string lost = "polution";

    // Use this for initialization
    void Start ()
    {
        uIManager = FindObjectOfType<UIManager>();
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
            uIManager.GameIsOverUI(false, lost);
            Debug.Log("Current Polution is to High Dead");
        }

        if(CurrentAirPolution >= MaxAirPolution)
        {
            uIManager.GameIsOverUI(false, lost);

            Debug.Log("Current Air Polution is To High Dead");
        }

        if(CurrentLandPolution >= MaxLandPolution)
        {
            uIManager.GameIsOverUI(false, lost);

            Debug.Log("Current Land Polution is To High Dead");
        }

        if(CurrentWaterPolution >= MaxWaterPolution)
        {
            uIManager.GameIsOverUI(false, lost);

            Debug.Log("Current Water Polution is To High Dead");
        }
    }

    public void AddPolution(float PolutionAmount, string PolutionType)
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
