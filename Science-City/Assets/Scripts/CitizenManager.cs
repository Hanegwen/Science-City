using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CitizenManager : MonoBehaviour
{
    public BaseCitizen baseCitizen;

    public List<BaseCitizen> totalCitizens = new List<BaseCitizen>();

    public int totalHapinessOfTown;

	// Use this for initialization
	void Awake ()
    {
        MakeNewCitizen();

        WaitingToMakeCitizens();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void AddNewCitizens()
    {
        

        if(SetHappinessOfCitizens() > totalCitizens.Count)
        {
            Debug.Log("Make New Citizen");

            MakeNewCitizen();
        }

        WaitingToMakeCitizens();
    }

    

    public void MakeNewCitizen()
    {
        Instantiate(baseCitizen);
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


    IEnumerator WaitingToMakeCitizens()
    {
        Debug.Log("Waiting To Make Citizens");

        yield return new WaitForSeconds(5);

        AddNewCitizens();


    }
}
