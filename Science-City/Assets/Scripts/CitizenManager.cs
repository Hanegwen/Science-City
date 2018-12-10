using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CitizenManager : MonoBehaviour
{
    public BaseCitizen baseCitizen;

    public List<BaseCitizen> totalCitizens = new List<BaseCitizen>();

    public float totalHapinessOfTown;

    bool canMakeCitizens = true;

    PolutionManager polutionManager;

	// Use this for initialization
	void Awake ()
    {
        AddNewCitizens();

        WaitingToMakeCitizens();
	}
	
	// Update is called once per frame
	void Update ()
    {
        totalHapinessOfTown = SetHappinessOfCitizens();
        polutionManager = FindObjectOfType<PolutionManager>();
	}

    public void AddNewCitizens()
    {

        if (canMakeCitizens)
        {
            MakeNewCitizen();
        }

    }

    

    public void MakeNewCitizen()
    {
        Instantiate(baseCitizen);
        canMakeCitizens = false;

        StartCoroutine(WaitingToMakeCitizens());
    }

    public float SetHappinessOfCitizens()
    {

        float localHappiness = 1.5f - polutionManager.MaxPolution;
        return localHappiness;
    }


    IEnumerator WaitingToMakeCitizens()
    {
        //Debug.Log("Waiting To Make Citizens");

        yield return new WaitForSeconds(5);

        //Debug.Log("Baby is Born");

        canMakeCitizens = true;


    }
}
