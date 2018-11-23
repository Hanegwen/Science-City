using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyManager : MonoBehaviour
{
    public NaturalGas naturalGas;
    public Coal coal;
    public Solar solar;

    public float CoalAmount = 100;
    public float NaturalGasAmount = 100;

    public float SolarAmount = 0;

    enum CurrentEnergy { Coal, Gas, Solar};
    CurrentEnergy energy;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void ChangeActivateEnergy()
    {
        switch(energy)
        {
            case Coal:
                break;
            case NaturalGas:
                break;
            case Solar:
                break;
            default:
                break;
        }
    }
}
