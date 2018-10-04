using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCitizen : MonoBehaviour
{
    public int happiness;

    public int happinessThreashold;

    CitizenManager citizenManager;

    
    // Use this for initialization
	void Start ()
    {
		citizenManager = FindObjectOfType<CitizenManager>();

        citizenManager.totalCitizens.Add(this);

        happiness = 50;

        happinessThreashold = Random.Range(10, 20);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public int SendHapinessRank()
    {
        return happiness;
    }

    void LeaveTown()
    {

    }

    public void AddHapiness(int happinessAdd)
    {
        happiness += happinessAdd;
    }

    private void OnDestroy()
    {
        citizenManager.totalCitizens.Remove(this);
    }
}
