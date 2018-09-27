using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownManager : MonoBehaviour
{
    CitizenManager citizenManager;


	// Use this for initialization
	void Start ()
    {
        citizenManager = FindObjectOfType<CitizenManager>();

        if(citizenManager == null)
        {
            Debug.Log("No Citizen Manager was Found");
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
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
   
}
