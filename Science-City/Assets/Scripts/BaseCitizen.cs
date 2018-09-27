using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCitizen : MonoBehaviour
{
    public int happiness = 1;

    public int happinessThreashold;

    CitizenManager citizenManager;
    // Use this for initialization
	void Start ()
    {
		citizenManager = FindObjectOfType<CitizenManager>();

        citizenManager.totalCitizens.Add(this);
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

    

    private void OnDestroy()
    {
        citizenManager.totalCitizens.Remove(this);
    }
}
