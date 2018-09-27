using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CitizenManager : MonoBehaviour
{
    public BaseCitizen baseCitizen;

    public List<BaseCitizen> totalCitizens = new List<BaseCitizen>();

    int totalHapinessOfTown;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public int SetHappinessOfCitizens()
    {
        int localTotalHapiness = 0;

        foreach (var Citizen in totalCitizens)
        {
            localTotalHapiness += Citizen.SendHapinessRank();
        }

        localTotalHapiness = localTotalHapiness / totalCitizens.Count;

        totalHapinessOfTown = localTotalHapiness;

        return totalHapinessOfTown;
    }
}
