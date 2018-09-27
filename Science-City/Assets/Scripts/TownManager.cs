using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownManager : MonoBehaviour
{
    CitizenManager citizenManager;


    public int DaysUntilReElection = 300;

	// Use this for initialization
	void Start ()
    {
        citizenManager = FindObjectOfType<CitizenManager>();

        if(citizenManager == null)
        {
            Debug.Log("No Citizen Manager was Found");
        }

        MinusDays();
    }
	
	// Update is called once per frame
	void Update ()
    {
        Loose();

        

		if(DaysUntilReElection == 0)
        {
            ReElectionDecision();
        }
	}

    void MinusDays()
    {
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
        yield return new WaitForSeconds(secondCount);

        DaysUntilReElection--;

        MinusDays();
    }
}
