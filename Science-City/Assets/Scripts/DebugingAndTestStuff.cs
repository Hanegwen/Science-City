using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugingAndTestStuff : MonoBehaviour
{
    CitizenManager citizenManager;
    PolutionManager polutionManager;

	// Use this for initialization
	void Start ()
    {
        citizenManager = FindObjectOfType<CitizenManager>();
        polutionManager = FindObjectOfType<PolutionManager>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Debug: New Citizen Time");
            citizenManager.MakeNewCitizen();
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            polutionManager.AddPolution(1 , "Air");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            polutionManager.AddPolution(1 , "Water");
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            polutionManager.AddPolution(1, "Land");
        }
    }
}
