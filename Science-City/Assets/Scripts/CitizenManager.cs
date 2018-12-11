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

    private void Start()
    {
        polutionManager = FindObjectOfType<PolutionManager>();
    }

    // Update is called once per frame
    void Update ()
    {
        totalHapinessOfTown = SetHappinessOfCitizens();
        
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

        float localHappiness;
        localHappiness = (298f - polutionManager.MaxPolution) - (polutionManager.MaxPolution /100) ;
        print("Max Polution: " + polutionManager.MaxPolution);
        print("Local Hapiness: " + localHappiness);
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
